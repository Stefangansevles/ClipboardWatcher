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
using Business_Logic_Layer;
using System.IO;

namespace ClipboardWatcher
{
    public partial class UCText : UserControl
    {
        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);

        //Determines if it's allowed to copy the clipboard text to the listview. When copying an url from a browser, it somehow gives the link twice, and it appears twice because of that
        //So, we add a small timeout. The listview still gets spammed when you hold down ctrl C on text, we don't want to disable that. If the user wants to do that for some reason, go ahead. (Maybe change this in the future, maybe not ¯\_(ツ)_/¯)
        private bool allowClipboard = true;

        public UCText()
        {
            InitializeComponent();
            //Set the listview theme to that of windows explorer
            SetWindowTheme(this.lvCopiedText.Handle, "Explorer", null);
        }

        /// <summary>
        /// Adds a line of text to the listview in UCText
        /// </summary>
        /// <param name="text"></param>
        public void AddText(string text)
        {
            if (!allowClipboard)
                return;

            ListViewItem item = new ListViewItem(text);
            item.SubItems.Add(DateTime.Now.ToLongTimeString() + " | " + DateTime.Now.ToShortDateString());
            lvCopiedText.Items.Add(item);

            //Set to false and start the timer so that no other text can be spammed into the listview
            allowClipboard = false;
            tmrTextTimeout.Start();
        }

        private void tmrTextTimeout_Tick(object sender, EventArgs e)
        {
            //After 10 miliseconds, allow it again and stop the timer
            allowClipboard = true;
            tmrTextTimeout.Stop();
        }

        public void SaveText()
        {
            if (lvCopiedText.Items.Count == 0)
                return;

            List<string> lines = new List<string>();
            //Get the datetime item, split it by | and get the second element, so you get the date from: time | date
            string strDate = lvCopiedText.Items[0].SubItems[1].Text.Split('|')[1].Replace(" ", "");
            //Set the save date to the first item in the listview
            DateTime date = Convert.ToDateTime(strDate);
            string path = BLSettings.Settings.SaveTextPath + "\\" + date.Year + "\\" + GetStringMonth(date) + "\\" + date.Day + " " + GetStringMonth(date) + "\\Copied text.txt";

            //Create folder if it doesn't exist yet
            if (!Directory.Exists(Path.GetDirectoryName(path)))
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            

            foreach (ListViewItem item in lvCopiedText.Items)
            {
                //Every new list item, we check if the date is a new date. The user can run clipboardwatcher for example for 2 days, 
                //it will then have text copies of different days, which should be saved at different locations
                if (item.SubItems[1].Text.Split('|')[1].Replace(" ", "") != strDate)
                {
                    //Write every line so far from date x to the correct path. (it only gets into this if statement if a new date has been detected, which means 
                    //the list of lines has lines of the previous day, so write them
                    Write(lines, path);
                    //Then, clear the list for future lines with a new date
                    lines.Clear();

                    //We have a new date!
                    strDate = item.SubItems[1].Text.Split('|')[1].Replace(" ", "");
                    date = Convert.ToDateTime(strDate);
                    path = BLSettings.Settings.SaveTextPath + "\\" + date.Year + "\\" + GetStringMonth(date) + "\\" + date.Day + " " + GetStringMonth(date) + "\\Copied text.txt";

                    //Create folder if it doesn't exist yet
                    if (!Directory.Exists(Path.GetDirectoryName(path)))
                        Directory.CreateDirectory(Path.GetDirectoryName(path));
                }
                //subitems[1] is the date
                lines.Add("[" + item.SubItems[1].Text + "] " + item.Text);                
            }
            //Write the last lines
            Write(lines, path);
        }

        private void Write(List<string> lines, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write)) //Append the file
            using (StreamWriter sw = new StreamWriter(fs))
            {
                foreach (string line in lines)
                {
                    sw.WriteLine(line);
                }
            }

        }



        //TODO: Move to a BL class?
        private string GetStringMonth()
        {
            switch (DateTime.Now.Month)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default: return null;
            }
        }

        private string GetStringMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default: return null;
            }
        }

        private void lvCopiedText_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (ListViewItem itm in lvCopiedText.SelectedItems)
                    lvCopiedText.Items.Remove(itm);
            }
        }

        private void lvCopiedText_KeyDown(object sender, KeyEventArgs e)
        {
            allowClipboard = true;
            
            //Select all items in the listview (Ctrl+A)
            if (e.KeyCode == Keys.Control | e.KeyCode == Keys.A)
            {
                foreach (ListViewItem itm in lvCopiedText.Items)
                    itm.Selected = true;
            }

            //Copy the selected text to the clipboard (Ctrl+C)
            if (e.KeyCode == Keys.Control | e.KeyCode == Keys.C)
            {
                allowClipboard = false;

                BLFormLogic.CopyListviewTextToClipboard(lvCopiedText);
            }
            tmrTextTimeout.Start();
        }

       
    }
}
