namespace ClipboardWatcher
{
    partial class UCText
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
            this.components = new System.ComponentModel.Container();
            this.lvCopiedText = new System.Windows.Forms.ListView();
            this.chText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tmrTextTimeout = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lvCopiedText
            // 
            this.lvCopiedText.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chText,
            this.chDate});
            this.lvCopiedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCopiedText.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lvCopiedText.FullRowSelect = true;
            this.lvCopiedText.Location = new System.Drawing.Point(0, 0);
            this.lvCopiedText.Name = "lvCopiedText";
            this.lvCopiedText.Size = new System.Drawing.Size(704, 442);
            this.lvCopiedText.TabIndex = 0;
            this.lvCopiedText.UseCompatibleStateImageBehavior = false;
            this.lvCopiedText.View = System.Windows.Forms.View.Details;
            this.lvCopiedText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvCopiedText_KeyDown);
            this.lvCopiedText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lvCopiedText_KeyUp);
            // 
            // chText
            // 
            this.chText.Text = "Copied Text";
            this.chText.Width = 550;
            // 
            // chDate
            // 
            this.chDate.Text = "Date of Copy";
            this.chDate.Width = 130;
            // 
            // tmrTextTimeout
            // 
            this.tmrTextTimeout.Interval = 10;
            this.tmrTextTimeout.Tick += new System.EventHandler(this.tmrTextTimeout_Tick);
            // 
            // UCText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.lvCopiedText);
            this.Name = "UCText";
            this.Size = new System.Drawing.Size(704, 442);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvCopiedText;
        private System.Windows.Forms.ColumnHeader chText;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.Timer tmrTextTimeout;
    }
}
