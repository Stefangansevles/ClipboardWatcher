using Business_Logic_Layer;
using Database.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardWatcher
{
    public partial class MainForm : Form
    {
        #region Clipboard import data variables
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

        private const int WM_DRAWCLIPBOARD = 0x0308;        // WM_DRAWCLIPBOARD message   
        private IntPtr _clipboardViewerNext;                // Our variable that will hold the value to identify the next window in the clipboard viewer chain     
        #endregion

        #region Content usercontrols
        //------Content usercontrols------\\
        private UCText ucText;
        private UCImages ucImages;
        private UCHistory ucHistory;
        private UCSettings ucSettings;
        #endregion

        private bool pausing = false;

        public MainForm()
        {
            InitializeComponent();
            _clipboardViewerNext = SetClipboardViewer(this.Handle);      // Adds our form to the chain

            //Set the data directory of our .db file
            AppDomain.CurrentDomain.SetData("DataDirectory", IOVariables.databaseFile);

            Directory.CreateDirectory(IOVariables.clipboardWatcherLocalFolder);
            BLIO.CreateDatabaseIfNotExist();

            //Create folders if they dont exist
            Directory.CreateDirectory(BLSettings.Settings.SaveImagePath);
            Directory.CreateDirectory(BLSettings.Settings.SaveTextPath);

            //------Content usercontrols------\\
            ucText = new UCText();
            ucImages = new UCImages();
            ucHistory = new UCHistory();
            ucSettings = new UCSettings();

            
            //Delete empty folders in /images and /text
            BLIO.DeleteEmptyDirectories(BLSettings.Settings.SaveImagePath);
            BLIO.DeleteEmptyDirectories(BLSettings.Settings.SaveTextPath);

            TrayContextMenuStrip.Renderer = new ToolStripMenuRenderer();
            this.Opacity = 0;        
        }

        /// <summary>
        /// Catches the different types of clipboard data (image/text) and redistrubutes them to their respective user controls
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);            

            //Here, we catch the user's clipboard actions. Ctrl + v on text, copy image, print screen, etc. Images or text on the users clipboard.
            if (m.Msg == WM_DRAWCLIPBOARD && !pausing)
            {
                try
                {
                    IDataObject iData = Clipboard.GetDataObject();      // Clipboard's data

                    if (iData.GetDataPresent(DataFormats.Text))
                    {
                        string text = (string)iData.GetData(DataFormats.Text);      // Clipboard text
                        //Now that we have the text  from the clipboard, send it to UCText so it can display it
                        ucText.AddText(text);
                    }
                    else if (iData.GetDataPresent(DataFormats.Bitmap))
                    {
                        Bitmap image = (Bitmap)iData.GetData(DataFormats.Bitmap);   // Clipboard image
                        //Now that we have the ImageItem, send it to UCImages so it can display it
                        ucImages.AddImage(image);
                    }


                }                
                catch (Exception ex) { }

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {          
            this.pnlContents.Controls.Add(ucText);            
            //hide the form on startup
            BeginInvoke(new MethodInvoker(delegate
            {                
                Hide();
            }));
            
            //Create an shortcut in the windows startup folder if it doesn't already exist
            if (!File.Exists(IOVariables.startupFolderPath + "\\ClipboardWatcher" + ".lnk"))
                FSManager.Shortcuts.CreateShortcut(IOVariables.startupFolderPath, "ClipboardWatcher", Application.StartupPath + "\\" + "ClipboardWatcher.exe", "Shortcut of ClipboardWatcher");

            lblVersion.Text = "Version " + IOVariables.ClipboardWatcherVersion;                        
        }

        private void btnImages_Click(object sender, EventArgs e)
        {
            pnlContents.Controls.Clear();
            pnlContents.Controls.Add(ucImages);
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            pnlContents.Controls.Clear();
            pnlContents.Controls.Add(ucText);           
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            pnlContents.Controls.Clear();
            pnlContents.Controls.Add(ucHistory);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlContents.Controls.Clear();
            pnlContents.Controls.Add(ucSettings);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save text entries before closing
            ucText.SaveText();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            this.Hide();
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowClipboardWatcher();
        }

        private void showClipboardWatcherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowClipboardWatcher();
        }

        private void ShowClipboardWatcher()
        {
            if (this.Visible)
                return;

            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Minimized;

            //Instead of calling .Show() on a form with 100% opacity making it visible instantly, we call .Show() on the form with 0% opacity.
            //The form will be drawn invisibly, and then increase the opacity until it reaches 100%. This way the form:
            //1. Has a fade-in like animation when showing
            //2. No longer shows flickery that occurs when drawing the form(windows-forms issue)
            this.Show();
            this.WindowState = FormWindowState.Normal;
            tmrFadeIn.Start();
        }

        private void tmrFadeIn_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.13;
            if (this.Opacity >= 1)
                tmrFadeIn.Stop();
        }

        private void pauseClipboardWatcherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pauseClipboardWatcherToolStripMenuItem.Text == "Pause ClipboardWatcher")
                pauseClipboardWatcherToolStripMenuItem.Text = "Resume ClipboardWatcher";
            else
                pauseClipboardWatcherToolStripMenuItem.Text = "Pause ClipboardWatcher";

            pausing = !pausing;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
