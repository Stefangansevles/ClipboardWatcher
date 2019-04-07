namespace ClipboardWatcher
{
    partial class UCSettings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.lblTextPath = new System.Windows.Forms.Label();
            this.btnImagePath = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnTextPath = new Bunifu.Framework.UI.BunifuImageButton();
            this.cbEnableWindowsStartup = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblEnableWindowsStartup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnImagePath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTextPath)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folder options";
            // 
            // lblImagePath
            // 
            this.lblImagePath.AutoSize = true;
            this.lblImagePath.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblImagePath.Location = new System.Drawing.Point(49, 61);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(82, 16);
            this.lblImagePath.TabIndex = 3;
            this.lblImagePath.Text = "Folder options";
            // 
            // lblTextPath
            // 
            this.lblTextPath.AutoSize = true;
            this.lblTextPath.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblTextPath.Location = new System.Drawing.Point(49, 101);
            this.lblTextPath.Name = "lblTextPath";
            this.lblTextPath.Size = new System.Drawing.Size(82, 16);
            this.lblTextPath.TabIndex = 4;
            this.lblTextPath.Text = "Folder options";
            // 
            // btnImagePath
            // 
            this.btnImagePath.BackColor = System.Drawing.Color.Transparent;
            this.btnImagePath.Image = global::ClipboardWatcher.Properties.Resources.folder;
            this.btnImagePath.ImageActive = null;
            this.btnImagePath.Location = new System.Drawing.Point(13, 49);
            this.btnImagePath.Name = "btnImagePath";
            this.btnImagePath.Size = new System.Drawing.Size(30, 30);
            this.btnImagePath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnImagePath.TabIndex = 5;
            this.btnImagePath.TabStop = false;
            this.btnImagePath.Zoom = 8;
            this.btnImagePath.Click += new System.EventHandler(this.btnImagePath_Click);
            // 
            // btnTextPath
            // 
            this.btnTextPath.BackColor = System.Drawing.Color.Transparent;
            this.btnTextPath.Image = global::ClipboardWatcher.Properties.Resources.folder;
            this.btnTextPath.ImageActive = null;
            this.btnTextPath.Location = new System.Drawing.Point(13, 89);
            this.btnTextPath.Name = "btnTextPath";
            this.btnTextPath.Size = new System.Drawing.Size(30, 30);
            this.btnTextPath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnTextPath.TabIndex = 6;
            this.btnTextPath.TabStop = false;
            this.btnTextPath.Zoom = 8;
            this.btnTextPath.Click += new System.EventHandler(this.btnTextPath_Click);
            // 
            // cbEnableWindowsStartup
            // 
            this.cbEnableWindowsStartup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbEnableWindowsStartup.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbEnableWindowsStartup.Checked = true;
            this.cbEnableWindowsStartup.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbEnableWindowsStartup.ForeColor = System.Drawing.Color.White;
            this.cbEnableWindowsStartup.Location = new System.Drawing.Point(23, 138);
            this.cbEnableWindowsStartup.Name = "cbEnableWindowsStartup";
            this.cbEnableWindowsStartup.Size = new System.Drawing.Size(20, 20);
            this.cbEnableWindowsStartup.TabIndex = 7;
            this.cbEnableWindowsStartup.OnChange += new System.EventHandler(this.cbEnableWindowsStartup_OnChange);
            // 
            // lblEnableWindowsStartup
            // 
            this.lblEnableWindowsStartup.AutoSize = true;
            this.lblEnableWindowsStartup.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblEnableWindowsStartup.Location = new System.Drawing.Point(49, 142);
            this.lblEnableWindowsStartup.Name = "lblEnableWindowsStartup";
            this.lblEnableWindowsStartup.Size = new System.Drawing.Size(263, 16);
            this.lblEnableWindowsStartup.TabIndex = 8;
            this.lblEnableWindowsStartup.Text = "Launch ClipboardWatcher on windows startup";
            this.lblEnableWindowsStartup.Click += new System.EventHandler(this.lblEnableWindowsStartup_Click);
            // 
            // UCSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.lblEnableWindowsStartup);
            this.Controls.Add(this.cbEnableWindowsStartup);
            this.Controls.Add(this.btnTextPath);
            this.Controls.Add(this.btnImagePath);
            this.Controls.Add(this.lblTextPath);
            this.Controls.Add(this.lblImagePath);
            this.Controls.Add(this.label1);
            this.Name = "UCSettings";
            this.Size = new System.Drawing.Size(704, 442);
            this.Load += new System.EventHandler(this.UCSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnImagePath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTextPath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.Label lblTextPath;
        private Bunifu.Framework.UI.BunifuImageButton btnImagePath;
        private Bunifu.Framework.UI.BunifuImageButton btnTextPath;
        private Bunifu.Framework.UI.BunifuCheckbox cbEnableWindowsStartup;
        private System.Windows.Forms.Label lblEnableWindowsStartup;
    }
}
