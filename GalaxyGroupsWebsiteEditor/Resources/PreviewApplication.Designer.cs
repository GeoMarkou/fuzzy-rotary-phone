namespace GalaxyGroupsWebsiteEditor
{
    partial class PreviewApplication
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PreviewWebsite = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // PreviewWebsite
            // 
            this.PreviewWebsite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewWebsite.Location = new System.Drawing.Point(0, 0);
            this.PreviewWebsite.MinimumSize = new System.Drawing.Size(20, 20);
            this.PreviewWebsite.Name = "PreviewWebsite";
            this.PreviewWebsite.Size = new System.Drawing.Size(726, 529);
            this.PreviewWebsite.TabIndex = 0;
            // 
            // PreviewApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 529);
            this.Controls.Add(this.PreviewWebsite);
            this.DoubleBuffered = true;
            this.Name = "PreviewApplication";
            this.Text = "Preview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser PreviewWebsite;
    }
}