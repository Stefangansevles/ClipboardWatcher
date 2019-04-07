namespace ClipboardWatcher
{
    partial class ImageItem
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
            this.lblPictureName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPictureName
            // 
            this.lblPictureName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPictureName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPictureName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(98)))));
            this.lblPictureName.Location = new System.Drawing.Point(0, 0);
            this.lblPictureName.Name = "lblPictureName";
            this.lblPictureName.Size = new System.Drawing.Size(205, 23);
            this.lblPictureName.TabIndex = 1;
            this.lblPictureName.Text = "This is the name.png";
            this.lblPictureName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPictureName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 23);
            this.panel1.TabIndex = 2;
            // 
            // pbPicture
            // 
            this.pbPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPicture.Location = new System.Drawing.Point(0, 0);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(205, 113);
            this.pbPicture.TabIndex = 3;
            this.pbPicture.TabStop = false;
            // 
            // ImageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.panel1);
            this.Name = "ImageItem";
            this.Size = new System.Drawing.Size(205, 136);
            this.Load += new System.EventHandler(this.ImageItem_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblPictureName;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pbPicture;
    }
}
