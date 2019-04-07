using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Business_Logic_Layer;
using System.Diagnostics;
using System.Threading;

namespace ClipboardWatcher
{
    public partial class UCHistory : UserControl
    {
        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);

        //Contains the path to the selected year/month/day
        private string imageString = "";

        public UCHistory()
        {
            InitializeComponent();
            SetWindowTheme(this.lvImageFiles.Handle, "Explorer", null);

            new Thread(() =>
            {
                LoadComboboxes();
            }
            ).Start();
        }

        private void UCHistory_Load(object sender, EventArgs e)
        {
            //Set hint texts on the comboboxes
            cbFilterYear.ForeColor = Color.Gray;
            cbFilterMonth.ForeColor = Color.Gray;
            cbFilterDay.ForeColor = Color.Gray;

            cbFilterYear.Text = "Year";
            cbFilterMonth.Text = "Month";
            cbFilterDay.Text = "Day";

        }

        private void LoadComboboxes()
        {
            //Add the years folders to the combobox
            if (lvImageFiles.Visible) //if lvImageFiles is visible, images are selected
            {
                foreach (string year in Directory.GetDirectories(BLSettings.Settings.SaveImagePath))
                {
                    string t = Path.GetDirectoryName(year);
                    cbFilterYear.Items.Add(Path.GetFileName(year));
                }
            }
            else
            {
                foreach (string year in Directory.GetDirectories(BLSettings.Settings.SaveTextPath))
                {
                    string t = Path.GetDirectoryName(year);
                    cbFilterYear.Items.Add(Path.GetFileName(year));
                }
            }
        }

        private void cbFilterYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFilterMonth.Items.Clear();
            cbFilterMonth.Text = "Month";
            cbFilterMonth.ForeColor = Color.Gray;

            //Start with resetting the color to black
            cbFilterYear.ForeColor = Color.Black;
            //Look for month folders inside folder\\year\\

            if (lvImageFiles.Visible)
                foreach (string Month in Directory.GetDirectories(BLSettings.Settings.SaveImagePath + "\\" + cbFilterYear.SelectedItem.ToString()))
                    cbFilterMonth.Items.Add(Path.GetFileName(Month));
            else
                foreach (string Month in Directory.GetDirectories(BLSettings.Settings.SaveTextPath + "\\" + cbFilterYear.SelectedItem.ToString()))
                    cbFilterMonth.Items.Add(Path.GetFileName(Month));
        }

        private void btnTextHistory_Click(object sender, EventArgs e)
        {
            if (btnTextHistory.selected)
                return;

            //Hide the right panel containing the image files. With text you just load the copied text that day.
            if (lvImageFiles.Visible)
            {
                pnlImages.BackgroundImage = null;
            }

            ResetControls();
        }

        private void btnImageHistory_Click(object sender, EventArgs e)
        {
            if (btnImageHistory.selected)
                return;

            //Don't need to reset everything if the user pressed the image button when it's already on images
            if (!lvImageFiles.Visible)
            {
                pnlImages.BackgroundImage = null;
            }

            ResetControls();            
        }

        /// <summary>
        /// Resets the controls, for example when an user is viewing text history, and continues to switch to image history.
        /// </summary>
        private void ResetControls()
        {
            lvImageFiles.Visible = !lvImageFiles.Visible;

            pnlImages.Visible = !pnlImages.Visible;
            pnlText.Visible = !pnlText.Visible;

            cbFilterDay.Items.Clear();
            cbFilterDay.SelectedItem = null;

            cbFilterMonth.Items.Clear();
            cbFilterMonth.SelectedItem = null;

            cbFilterYear.Items.Clear();
            cbFilterYear.SelectedItem = null;

            cbFilterDay.Text = "Day";
            cbFilterMonth.Text = "Month";
            cbFilterYear.Text = "Year";

            cbFilterDay.ForeColor = Color.Gray;
            cbFilterMonth.ForeColor = Color.Gray;
            cbFilterYear.ForeColor = Color.Gray;

            LoadComboboxes();
        }


        private void cbFilterMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFilterDay.Items.Clear();
            cbFilterDay.Text = "Day";
            cbFilterDay.ForeColor = Color.Gray;

            cbFilterMonth.ForeColor = Color.Black;
            List<string> imageDirectories = Directory.GetDirectories(BLSettings.Settings.SaveImagePath + "\\" + cbFilterYear.SelectedItem.ToString() + "\\" + cbFilterMonth.SelectedItem.ToString()).ToList();
            List<string> textDirectories = Directory.GetDirectories(BLSettings.Settings.SaveTextPath + "\\" + cbFilterYear.SelectedItem.ToString() + "\\" + cbFilterMonth.SelectedItem.ToString()).ToList();

            int maxTextlen = textDirectories.Max(x => x.Length);
            int maxImglen = imageDirectories.Max(x => x.Length);

            if (lvImageFiles.Visible)
                foreach (string day in imageDirectories.OrderBy(x => x.PadLeft(maxImglen, '0'))) //Order 1-31
                    cbFilterDay.Items.Add(Path.GetFileName(day));
            else
                foreach (string day in textDirectories.OrderBy(x => x.PadLeft(maxTextlen, '0')))
                    cbFilterDay.Items.Add(Path.GetFileName(day));                   
        }

        private void cbFilterDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFilterDay.ForeColor = Color.Black;
            lvImageFiles.Items.Clear();
            if (lvImageFiles.Visible)
            {
                foreach (string file in FSManager.Files.GetFileNamesInFolder(BLSettings.Settings.SaveImagePath + "\\" + cbFilterYear.SelectedItem.ToString() + "\\" + cbFilterMonth.SelectedItem.ToString() + "\\" + cbFilterDay.SelectedItem.ToString()))
                    lvImageFiles.Items.Add(Path.GetFileName(file));

                imageString = BLSettings.Settings.SaveImagePath + "\\" + cbFilterYear.SelectedItem.ToString() + "\\" + cbFilterMonth.SelectedItem.ToString() + "\\" + cbFilterDay.SelectedItem.ToString() + "\\";
            }
            else
            {
                //Text              
                lvCopiedText.Items.Clear();
                //TODO: 3 january doesnt exist. is it somehow checking at the image folder?
                foreach (string file in Directory.GetFiles(BLSettings.Settings.SaveTextPath + "\\" + cbFilterYear.SelectedItem.ToString() + "\\" + cbFilterMonth.SelectedItem.ToString() + "\\" + cbFilterDay.SelectedItem.ToString()))                
                    AddTextFileToListview(file);                
            }

        }

        private void AddTextFileToListview(string file)
        {
            //Put all the lines of text from the file into an array
            string[] lines = System.IO.File.ReadAllLines(file);
            string date = "";
            string text = "";

            foreach(string line in lines)
            {
                date = line.Substring(0, line.IndexOf(']')+1);
                text = line.Substring(line.IndexOf(']') + 1);

                lvCopiedText.Items.Add(text).SubItems.Add(date);
            }
        }

        private void lvImageFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvImageFiles.SelectedItems.Count > 0)
            {
                if (!File.Exists(imageString + lvImageFiles.SelectedItems[0].Text))
                    return;

                Image picture = Image.FromFile(imageString + lvImageFiles.SelectedItems[0].Text);

                Image oldImage = pnlImages.BackgroundImage;
                if (picture.Size.Width > pnlImages.Size.Width || picture.Size.Height > pnlImages.Size.Height)
                {
                    pnlImages.BackgroundImageLayout = ImageLayout.Stretch;
                    pnlImages.BackgroundImage = picture;
                }
                else
                {
                    pnlImages.BackgroundImageLayout = ImageLayout.None;
                    pnlImages.BackgroundImage = picture;                    
                }

                if(oldImage != null)
                    oldImage.Dispose();
            }
        }        

        private void lvImageFiles_DoubleClick(object sender, EventArgs e)
        {
            
            if (lvImageFiles.SelectedItems.Count > 0)
                Process.Start(imageString + lvImageFiles.SelectedItems[0].Text);
        }

        private void lvImageFiles_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvImageFiles.SelectedItems.Count > 0)
            {
                if (e.Button == MouseButtons.Right)
                    imageContextMenuStrip.Show(Cursor.Position);
            }
        }

        private void openContainingFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(imageString);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteImages();
        }

        private void DeleteImages()
        {
            if (lvImageFiles.SelectedItems.Count > 0)
            {
                pnlImages.BackgroundImage.Dispose();

                foreach (ListViewItem img in lvImageFiles.SelectedItems)
                {
                    if (File.Exists(imageString + img.Text)) //imageString + img = path to the image.png
                    {
                        File.Delete(imageString + img.Text);
                    }
                }

                foreach (ListViewItem itm in lvImageFiles.SelectedItems)
                    lvImageFiles.Items.Remove(itm);
            }
        }

        private void lvImageFiles_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                DeleteImages();
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvImageFiles.SelectedItems.Count > 0)
            {
                //File in use if you don't dispose
                pnlImages.BackgroundImage.Dispose();

                //Ask the user for a new filename
                string newFileName = Prompt.Show("Enter a new file name:", lvImageFiles.SelectedItems[0].Text);

                if (string.IsNullOrWhiteSpace(newFileName))
                    return;
                

                int counter = 1;
                foreach (ListViewItem itm in lvImageFiles.SelectedItems)
                {
                    if(lvImageFiles.SelectedItems.Count > 1)
                    {                        
                        File.Move(imageString + itm.Text, imageString + newFileName + "~" + counter + ".png");
                        itm.Text = newFileName + "~" + counter + ".png"; 
                    }
                    else
                    {
                        File.Move(imageString + itm.Text, imageString + newFileName + ".png");
                        itm.Text = newFileName + ".png";
                    }
                    counter++;
                }
            }
        }

        private void lvImageFiles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                //Ctrl+a = select all items                
                foreach (ListViewItem item in lvImageFiles.Items)
                    item.Selected = true;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process paint = new Process();
            foreach (ListViewItem itm in lvImageFiles.SelectedItems)
            {
                string path = imageString + itm.Text;
                paint.StartInfo.FileName = @"C:\Windows\System32\mspaint.exe";
                paint.StartInfo.Arguments = string.Format("\"{0}\"", path); 
                paint.Start();                
            }
        }

        private void UCHistory_VisibleChanged(object sender, EventArgs e)
        {
            pnlImages.Controls.Clear();
        }

        private void lvCopiedText_KeyDown(object sender, KeyEventArgs e)
        {
            //Select all items in the listview (Ctrl+A)
            if (e.KeyCode == Keys.Control | e.KeyCode == Keys.A)
            {
                foreach (ListViewItem itm in lvCopiedText.Items)
                    itm.Selected = true;
            }

            //Copy the selected text to the clipboard (Ctrl+C)
            if (e.KeyCode == Keys.Control | e.KeyCode == Keys.C)
            {
                //allowClipboard = false;

                BLFormLogic.CopyListviewTextToClipboard(lvCopiedText);
            }
        }
    }
}
