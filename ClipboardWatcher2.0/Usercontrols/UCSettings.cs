using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logic_Layer;
using Database.Entity;

namespace ClipboardWatcher
{
    public partial class UCSettings : UserControl
    {
        public UCSettings()
        {
            InitializeComponent();
        }

        private void UCSettings_Load(object sender, EventArgs e)
        {
            lblImagePath.Text = "Save location for image files: " + BLSettings.Settings.SaveImagePath;
            lblTextPath.Text =  "Save location for text files:  " + BLSettings.Settings.SaveTextPath;
            cbEnableWindowsStartup.Checked = BLSettings.Settings.StartOnWindows == 1;
        }

        private void btnTextPath_Click(object sender, EventArgs e)
        {
            Settings currentSettings = BLSettings.Settings;

            string path = FSManager.Folders.GetSelectedFolderPath();
            if (path != null && path != string.Empty)
            {
                currentSettings.SaveTextPath = path;

                BLSettings.Settings = currentSettings;

                UCSettings_Load(sender, e);
            }
        }

        private void btnImagePath_Click(object sender, EventArgs e)
        {
            Settings currentSettings = BLSettings.Settings;

            string path = FSManager.Folders.GetSelectedFolderPath();
            if (path != null && path != string.Empty)
            {
                currentSettings.SaveImagePath = path;

                BLSettings.Settings = currentSettings;

                UCSettings_Load(sender, e);
            }
        }

        private void lblEnableWindowsStartup_Click(object sender, EventArgs e)
        {
            cbEnableWindowsStartup.Checked = !cbEnableWindowsStartup.Checked;
        }

        private void cbEnableWindowsStartup_OnChange(object sender, EventArgs e)
        {
            Settings currentSettings = BLSettings.Settings;

            currentSettings.StartOnWindows = Convert.ToInt32(cbEnableWindowsStartup.Checked);

            BLSettings.Settings = currentSettings;            
        }
    }
}
