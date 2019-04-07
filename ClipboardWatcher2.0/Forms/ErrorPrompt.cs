using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardWatcher
{
    public partial class ErrorPrompt : Form
    {
        public ErrorPrompt(Exception ex)
        {
            InitializeComponent();
            lblException.Text = ex.ToString();
            lblException.MaximumSize = new Size(panel1.Width - 25, panel1.Height*100);
            panel1.VerticalScroll.Visible = true;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
