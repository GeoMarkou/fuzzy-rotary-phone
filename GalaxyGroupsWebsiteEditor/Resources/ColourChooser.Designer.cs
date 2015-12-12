namespace GalaxyGroupsWebsiteEditor
{
    partial class ColourChooser
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
            this.Ok = new System.Windows.Forms.Button();
            this.ReturnPanel = new System.Windows.Forms.Panel();
            this.Cancel = new System.Windows.Forms.Button();
            this.ColourPanel = new System.Windows.Forms.Panel();
            this.ColourBarsPanel = new System.Windows.Forms.Panel();
            this.BlueBar = new System.Windows.Forms.TrackBar();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.GreenBar = new System.Windows.Forms.TrackBar();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.RedBar = new System.Windows.Forms.TrackBar();
            this.RedLabel = new System.Windows.Forms.Label();
            this.ColourPreviewPanel = new System.Windows.Forms.Panel();
            this.ReturnPanel.SuspendLayout();
            this.ColourPanel.SuspendLayout();
            this.ColourBarsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Dock = System.Windows.Forms.DockStyle.Left;
            this.Ok.Location = new System.Drawing.Point(3, 3);
            this.Ok.MaximumSize = new System.Drawing.Size(75, 23);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 0;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // ReturnPanel
            // 
            this.ReturnPanel.Controls.Add(this.Cancel);
            this.ReturnPanel.Controls.Add(this.Ok);
            this.ReturnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReturnPanel.Location = new System.Drawing.Point(0, 198);
            this.ReturnPanel.Name = "ReturnPanel";
            this.ReturnPanel.Padding = new System.Windows.Forms.Padding(3);
            this.ReturnPanel.Size = new System.Drawing.Size(156, 29);
            this.ReturnPanel.TabIndex = 1;
            // 
            // Cancel
            // 
            this.Cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Cancel.Location = new System.Drawing.Point(78, 3);
            this.Cancel.MaximumSize = new System.Drawing.Size(75, 23);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ColourPanel
            // 
            this.ColourPanel.Controls.Add(this.ColourBarsPanel);
            this.ColourPanel.Controls.Add(this.ColourPreviewPanel);
            this.ColourPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColourPanel.Location = new System.Drawing.Point(0, 0);
            this.ColourPanel.Name = "ColourPanel";
            this.ColourPanel.Padding = new System.Windows.Forms.Padding(3);
            this.ColourPanel.Size = new System.Drawing.Size(156, 198);
            this.ColourPanel.TabIndex = 2;
            // 
            // ColourBarsPanel
            // 
            this.ColourBarsPanel.AutoSize = true;
            this.ColourBarsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ColourBarsPanel.Controls.Add(this.BlueBar);
            this.ColourBarsPanel.Controls.Add(this.BlueLabel);
            this.ColourBarsPanel.Controls.Add(this.GreenBar);
            this.ColourBarsPanel.Controls.Add(this.GreenLabel);
            this.ColourBarsPanel.Controls.Add(this.RedBar);
            this.ColourBarsPanel.Controls.Add(this.RedLabel);
            this.ColourBarsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ColourBarsPanel.Location = new System.Drawing.Point(3, 52);
            this.ColourBarsPanel.Name = "ColourBarsPanel";
            this.ColourBarsPanel.Size = new System.Drawing.Size(150, 146);
            this.ColourBarsPanel.TabIndex = 2;
            // 
            // BlueBar
            // 
            this.BlueBar.AutoSize = false;
            this.BlueBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlueBar.LargeChange = 50;
            this.BlueBar.Location = new System.Drawing.Point(0, 116);
            this.BlueBar.Maximum = 255;
            this.BlueBar.Name = "BlueBar";
            this.BlueBar.Size = new System.Drawing.Size(150, 30);
            this.BlueBar.TabIndex = 6;
            this.BlueBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BlueBar.Scroll += new System.EventHandler(this.BlueBar_Scroll);
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueLabel.Location = new System.Drawing.Point(0, 93);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.BlueLabel.Size = new System.Drawing.Size(42, 23);
            this.BlueLabel.TabIndex = 5;
            this.BlueLabel.Text = "Blue";
            // 
            // GreenBar
            // 
            this.GreenBar.AutoSize = false;
            this.GreenBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.GreenBar.LargeChange = 50;
            this.GreenBar.Location = new System.Drawing.Point(0, 69);
            this.GreenBar.Maximum = 255;
            this.GreenBar.Name = "GreenBar";
            this.GreenBar.Size = new System.Drawing.Size(150, 24);
            this.GreenBar.TabIndex = 4;
            this.GreenBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GreenBar.Scroll += new System.EventHandler(this.GreenBar_Scroll);
            // 
            // GreenLabel
            // 
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GreenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenLabel.Location = new System.Drawing.Point(0, 46);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.GreenLabel.Size = new System.Drawing.Size(54, 23);
            this.GreenLabel.TabIndex = 3;
            this.GreenLabel.Text = "Green";
            // 
            // RedBar
            // 
            this.RedBar.AutoSize = false;
            this.RedBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.RedBar.LargeChange = 50;
            this.RedBar.Location = new System.Drawing.Point(0, 23);
            this.RedBar.Maximum = 255;
            this.RedBar.Name = "RedBar";
            this.RedBar.Size = new System.Drawing.Size(150, 23);
            this.RedBar.TabIndex = 2;
            this.RedBar.TickFrequency = 5;
            this.RedBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RedBar.Scroll += new System.EventHandler(this.RedBar_Scroll);
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedLabel.Location = new System.Drawing.Point(0, 0);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.RedLabel.Size = new System.Drawing.Size(40, 23);
            this.RedLabel.TabIndex = 0;
            this.RedLabel.Text = "Red";
            // 
            // ColourPreviewPanel
            // 
            this.ColourPreviewPanel.BackColor = System.Drawing.Color.Black;
            this.ColourPreviewPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ColourPreviewPanel.Location = new System.Drawing.Point(3, 3);
            this.ColourPreviewPanel.Name = "ColourPreviewPanel";
            this.ColourPreviewPanel.Padding = new System.Windows.Forms.Padding(5);
            this.ColourPreviewPanel.Size = new System.Drawing.Size(150, 49);
            this.ColourPreviewPanel.TabIndex = 0;
            // 
            // ColourChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(156, 227);
            this.Controls.Add(this.ColourPanel);
            this.Controls.Add(this.ReturnPanel);
            this.MaximumSize = new System.Drawing.Size(999999, 265);
            this.MinimumSize = new System.Drawing.Size(172, 265);
            this.Name = "ColourChooser";
            this.Text = "Colour Chooser";
            this.ReturnPanel.ResumeLayout(false);
            this.ColourPanel.ResumeLayout(false);
            this.ColourPanel.PerformLayout();
            this.ColourBarsPanel.ResumeLayout(false);
            this.ColourBarsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Panel ReturnPanel;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Panel ColourPanel;
        private System.Windows.Forms.Panel ColourPreviewPanel;
        private System.Windows.Forms.Panel ColourBarsPanel;
        private System.Windows.Forms.TrackBar RedBar;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.TrackBar BlueBar;
        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.TrackBar GreenBar;
        private System.Windows.Forms.Label GreenLabel;
    }
}