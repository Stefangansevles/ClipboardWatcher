using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardWatcher
{
    public partial class Prompt : Form
    {
        private static string strReturnValue;
        private static Prompt newPrompt;
        public Prompt(string title)
        {            
            InitializeComponent();         
            this.Opacity = 0;
            lblText.MaximumSize = new Size((pnlMainGradient.Width - lblText.Location.X) - 10, 0);
            lblTitle.MaximumSize = new Size((pnlMainGradient.Width - lblTitle.Location.X) - 10, 0);

            lblTitle.Text = title;


            //Set the location within the remindme window. 
            //This prompt can be moved, but inititally will be set to the middle of the location of RemindMe
            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            if (mainForm != null)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(mainForm.Location.X + ((mainForm.Width / 2) - this.Width / 2), mainForm.Location.Y + ((mainForm.Height / 2) - (this.Height / 2)));
            }

            tmrFadeIn.Start();
            strReturnValue = "";
        }
        public Prompt(string title, string tbText) : this(title)
        {
            tbPrompt.Text = tbText;
        }

        /// <summary>
        /// Shows a prompt where the user can enter a string
        /// </summary>
        /// <param name="title">The title the user should see when this prompt shows up</param>
        /// <returns>The input string</returns>
        public static string Show(string title)
        {
            newPrompt = new Prompt(title);
            newPrompt.ShowDialog();            
            return strReturnValue;
        }

        /// <summary>
        /// Shows a prompt where the user can enter a string
        /// </summary>
        /// <param name="title">The title the user should see when this prompt shows up</param>
        /// <param name="textboxString">The textbox text, if you want to set that.</param>
        /// <returns>The input string</returns>
        public static string Show(string title,string textboxString)
        {            
            newPrompt = new Prompt(title,textboxString);
            newPrompt.ShowDialog();
            return strReturnValue;
        }        
        private void tmrFadeIn_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.08;
            if (this.Opacity >= 1)
                tmrFadeIn.Stop();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Confirm();
        }

        private void tbPrompt_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPrompt.Text) || !IsValidFilename(tbPrompt.Text))
            {
                tbPrompt.BorderColorFocused = Color.Red;
                return;
            }
            tbPrompt.BorderColorFocused = Color.Transparent;


            if (e.KeyCode == Keys.Enter)
                Confirm();            
        }

        private void Confirm()
        {
            if (string.IsNullOrWhiteSpace(tbPrompt.Text) || !IsValidFilename(tbPrompt.Text))                            
                return;                        

            strReturnValue = tbPrompt.Text;
            this.Close();
        }

        private bool IsValidFilename(string filename)
        {
            //Put all the invalid characters in 1 string
            string invalidCharacters = new string(Path.GetInvalidFileNameChars());
            Regex regexInvalidCharacters = new Regex("[" + Regex.Escape(invalidCharacters) + "]");
            
            if (regexInvalidCharacters.IsMatch(filename))
                return false;            
            return true;
        }
    }
}
