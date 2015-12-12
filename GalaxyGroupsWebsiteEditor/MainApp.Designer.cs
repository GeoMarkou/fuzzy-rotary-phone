namespace GalaxyGroupsWebsiteEditor
{
    partial class MainApp
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
            this.components = new System.ComponentModel.Container();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.HomePage = new System.Windows.Forms.TabPage();
            this.HomeTextArea = new System.Windows.Forms.RichTextBox();
            this.RightClickTextArea = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulletPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeTextAreaTitle = new System.Windows.Forms.Label();
            this.ServicesPage = new System.Windows.Forms.TabPage();
            this.splitterListToDetails = new System.Windows.Forms.Splitter();
            this.ServicesServicePanel = new System.Windows.Forms.Panel();
            this.ServicesButtonsPanel = new System.Windows.Forms.Panel();
            this.buttonMoveServiceDown = new System.Windows.Forms.Button();
            this.buttonMoveServiceUp = new System.Windows.Forms.Button();
            this.panelSepRemoveAndMove = new System.Windows.Forms.Panel();
            this.RemoveServiceButton = new System.Windows.Forms.Button();
            this.AddServiceButton = new System.Windows.Forms.Button();
            this.ServicesNavigationPanel = new System.Windows.Forms.Panel();
            this.ServicesListPanel = new System.Windows.Forms.Panel();
            this.ServiceList = new System.Windows.Forms.ListBox();
            this.ServicesEditPanel = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ServicePictureDisplay = new System.Windows.Forms.PictureBox();
            this.splitterServiceImageToDescription = new System.Windows.Forms.Splitter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxServicePrice = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxServiceName = new System.Windows.Forms.TextBox();
            this.ServicesTextAreaPanel = new System.Windows.Forms.Panel();
            this.ServiceTextArea = new System.Windows.Forms.RichTextBox();
            this.ServicesTextAreaLabel = new System.Windows.Forms.Label();
            this.ContactPage = new System.Windows.Forms.TabPage();
            this.ContactPagePanelArea = new System.Windows.Forms.Panel();
            this.ContactTextAreaPanel = new System.Windows.Forms.Panel();
            this.ContactTextArea = new System.Windows.Forms.RichTextBox();
            this.ContactTextLabel = new System.Windows.Forms.Label();
            this.ServiceListIcons = new System.Windows.Forms.ImageList(this.components);
            this.HomePreviewButton = new System.Windows.Forms.Button();
            this.ErrorPanel = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.PreviewButton = new System.Windows.Forms.Button();
            this.BasePanel = new System.Windows.Forms.Panel();
            this.FadeTimer = new System.Windows.Forms.Timer(this.components);
            this.FontChooser = new System.Windows.Forms.FontDialog();
            this.FileOpener = new System.Windows.Forms.OpenFileDialog();
            this.ErrorAlert = new GalaxyGroupsWebsiteEditor.NewLabel();
            this.TabControl.SuspendLayout();
            this.HomePage.SuspendLayout();
            this.RightClickTextArea.SuspendLayout();
            this.ServicesPage.SuspendLayout();
            this.ServicesServicePanel.SuspendLayout();
            this.ServicesButtonsPanel.SuspendLayout();
            this.ServicesNavigationPanel.SuspendLayout();
            this.ServicesListPanel.SuspendLayout();
            this.ServicesEditPanel.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServicePictureDisplay)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ServicesTextAreaPanel.SuspendLayout();
            this.ContactPage.SuspendLayout();
            this.ContactPagePanelArea.SuspendLayout();
            this.ContactTextAreaPanel.SuspendLayout();
            this.ErrorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.HomePage);
            this.TabControl.Controls.Add(this.ServicesPage);
            this.TabControl.Controls.Add(this.ContactPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(650, 459);
            this.TabControl.TabIndex = 0;
            this.TabControl.TabStop = false;
            this.TabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl_Selected);
            // 
            // HomePage
            // 
            this.HomePage.Controls.Add(this.HomeTextArea);
            this.HomePage.Controls.Add(this.HomeTextAreaTitle);
            this.HomePage.Location = new System.Drawing.Point(4, 22);
            this.HomePage.Name = "HomePage";
            this.HomePage.Padding = new System.Windows.Forms.Padding(10);
            this.HomePage.Size = new System.Drawing.Size(642, 433);
            this.HomePage.TabIndex = 0;
            this.HomePage.Text = "Home";
            this.HomePage.UseVisualStyleBackColor = true;
            // 
            // HomeTextArea
            // 
            this.HomeTextArea.AcceptsTab = true;
            this.HomeTextArea.AutoWordSelection = true;
            this.HomeTextArea.BackColor = System.Drawing.Color.White;
            this.HomeTextArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HomeTextArea.ContextMenuStrip = this.RightClickTextArea;
            this.HomeTextArea.DetectUrls = false;
            this.HomeTextArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeTextArea.Location = new System.Drawing.Point(10, 23);
            this.HomeTextArea.MaxLength = 0;
            this.HomeTextArea.Name = "HomeTextArea";
            this.HomeTextArea.Size = new System.Drawing.Size(622, 400);
            this.HomeTextArea.TabIndex = 4;
            this.HomeTextArea.Text = "";
            // 
            // RightClickTextArea
            // 
            this.RightClickTextArea.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.fontColourToolStripMenuItem});
            this.RightClickTextArea.Name = "RightClickTextArea";
            this.RightClickTextArea.Size = new System.Drawing.Size(134, 136);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bulletPointToolStripMenuItem,
            this.imageToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // bulletPointToolStripMenuItem
            // 
            this.bulletPointToolStripMenuItem.Name = "bulletPointToolStripMenuItem";
            this.bulletPointToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.bulletPointToolStripMenuItem.Text = "Bullet point";
            this.bulletPointToolStripMenuItem.Click += new System.EventHandler(this.bulletPointToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // fontColourToolStripMenuItem
            // 
            this.fontColourToolStripMenuItem.Name = "fontColourToolStripMenuItem";
            this.fontColourToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.fontColourToolStripMenuItem.Text = "Text colour";
            this.fontColourToolStripMenuItem.Click += new System.EventHandler(this.fontColourToolStripMenuItem_Click);
            // 
            // HomeTextAreaTitle
            // 
            this.HomeTextAreaTitle.AutoSize = true;
            this.HomeTextAreaTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeTextAreaTitle.Location = new System.Drawing.Point(10, 10);
            this.HomeTextAreaTitle.Name = "HomeTextAreaTitle";
            this.HomeTextAreaTitle.Size = new System.Drawing.Size(28, 13);
            this.HomeTextAreaTitle.TabIndex = 3;
            this.HomeTextAreaTitle.Text = "Text";
            // 
            // ServicesPage
            // 
            this.ServicesPage.Controls.Add(this.splitterListToDetails);
            this.ServicesPage.Controls.Add(this.ServicesServicePanel);
            this.ServicesPage.Controls.Add(this.ServicesEditPanel);
            this.ServicesPage.Controls.Add(this.ServicesTextAreaPanel);
            this.ServicesPage.Location = new System.Drawing.Point(4, 22);
            this.ServicesPage.Name = "ServicesPage";
            this.ServicesPage.Padding = new System.Windows.Forms.Padding(3);
            this.ServicesPage.Size = new System.Drawing.Size(642, 433);
            this.ServicesPage.TabIndex = 1;
            this.ServicesPage.Text = "Services";
            this.ServicesPage.UseVisualStyleBackColor = true;
            // 
            // splitterListToDetails
            // 
            this.splitterListToDetails.BackColor = System.Drawing.SystemColors.Window;
            this.splitterListToDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterListToDetails.Location = new System.Drawing.Point(510, 103);
            this.splitterListToDetails.MinExtra = 283;
            this.splitterListToDetails.MinSize = 100;
            this.splitterListToDetails.Name = "splitterListToDetails";
            this.splitterListToDetails.Size = new System.Drawing.Size(10, 327);
            this.splitterListToDetails.TabIndex = 4;
            this.splitterListToDetails.TabStop = false;
            this.splitterListToDetails.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitterListToDetails_SplitterMoved);
            // 
            // ServicesServicePanel
            // 
            this.ServicesServicePanel.Controls.Add(this.ServicesNavigationPanel);
            this.ServicesServicePanel.Controls.Add(this.ServicesButtonsPanel);
            this.ServicesServicePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServicesServicePanel.Location = new System.Drawing.Point(3, 103);
            this.ServicesServicePanel.Name = "ServicesServicePanel";
            this.ServicesServicePanel.Padding = new System.Windows.Forms.Padding(8);
            this.ServicesServicePanel.Size = new System.Drawing.Size(517, 327);
            this.ServicesServicePanel.TabIndex = 2;
            // 
            // ServicesButtonsPanel
            // 
            this.ServicesButtonsPanel.BackColor = System.Drawing.Color.Transparent;
            this.ServicesButtonsPanel.Controls.Add(this.buttonMoveServiceDown);
            this.ServicesButtonsPanel.Controls.Add(this.buttonMoveServiceUp);
            this.ServicesButtonsPanel.Controls.Add(this.panelSepRemoveAndMove);
            this.ServicesButtonsPanel.Controls.Add(this.RemoveServiceButton);
            this.ServicesButtonsPanel.Controls.Add(this.AddServiceButton);
            this.ServicesButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ServicesButtonsPanel.Location = new System.Drawing.Point(8, 297);
            this.ServicesButtonsPanel.Name = "ServicesButtonsPanel";
            this.ServicesButtonsPanel.Padding = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.ServicesButtonsPanel.Size = new System.Drawing.Size(501, 22);
            this.ServicesButtonsPanel.TabIndex = 4;
            // 
            // buttonMoveServiceDown
            // 
            this.buttonMoveServiceDown.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonMoveServiceDown.Location = new System.Drawing.Point(220, 0);
            this.buttonMoveServiceDown.MinimumSize = new System.Drawing.Size(0, 23);
            this.buttonMoveServiceDown.Name = "buttonMoveServiceDown";
            this.buttonMoveServiceDown.Size = new System.Drawing.Size(50, 23);
            this.buttonMoveServiceDown.TabIndex = 4;
            this.buttonMoveServiceDown.Text = "Down";
            this.buttonMoveServiceDown.UseVisualStyleBackColor = true;
            this.buttonMoveServiceDown.Click += new System.EventHandler(this.buttonMoveServiceDown_Click);
            // 
            // buttonMoveServiceUp
            // 
            this.buttonMoveServiceUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonMoveServiceUp.Location = new System.Drawing.Point(170, 0);
            this.buttonMoveServiceUp.MinimumSize = new System.Drawing.Size(0, 23);
            this.buttonMoveServiceUp.Name = "buttonMoveServiceUp";
            this.buttonMoveServiceUp.Size = new System.Drawing.Size(50, 23);
            this.buttonMoveServiceUp.TabIndex = 3;
            this.buttonMoveServiceUp.Text = "Up";
            this.buttonMoveServiceUp.UseVisualStyleBackColor = true;
            this.buttonMoveServiceUp.Click += new System.EventHandler(this.buttonMoveServiceUp_Click);
            // 
            // panelSepRemoveAndMove
            // 
            this.panelSepRemoveAndMove.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSepRemoveAndMove.Location = new System.Drawing.Point(150, 0);
            this.panelSepRemoveAndMove.Name = "panelSepRemoveAndMove";
            this.panelSepRemoveAndMove.Size = new System.Drawing.Size(20, 14);
            this.panelSepRemoveAndMove.TabIndex = 2;
            // 
            // RemoveServiceButton
            // 
            this.RemoveServiceButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.RemoveServiceButton.Location = new System.Drawing.Point(75, 0);
            this.RemoveServiceButton.MinimumSize = new System.Drawing.Size(0, 23);
            this.RemoveServiceButton.Name = "RemoveServiceButton";
            this.RemoveServiceButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveServiceButton.TabIndex = 1;
            this.RemoveServiceButton.Text = "Remove";
            this.RemoveServiceButton.UseVisualStyleBackColor = true;
            this.RemoveServiceButton.Click += new System.EventHandler(this.RemoveServiceButton_Click);
            // 
            // AddServiceButton
            // 
            this.AddServiceButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddServiceButton.Location = new System.Drawing.Point(0, 0);
            this.AddServiceButton.MinimumSize = new System.Drawing.Size(0, 23);
            this.AddServiceButton.Name = "AddServiceButton";
            this.AddServiceButton.Size = new System.Drawing.Size(75, 23);
            this.AddServiceButton.TabIndex = 0;
            this.AddServiceButton.Text = "Add";
            this.AddServiceButton.UseVisualStyleBackColor = true;
            this.AddServiceButton.Click += new System.EventHandler(this.AddServiceButton_Click);
            // 
            // ServicesNavigationPanel
            // 
            this.ServicesNavigationPanel.Controls.Add(this.ServicesListPanel);
            this.ServicesNavigationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServicesNavigationPanel.Location = new System.Drawing.Point(8, 8);
            this.ServicesNavigationPanel.Name = "ServicesNavigationPanel";
            this.ServicesNavigationPanel.Size = new System.Drawing.Size(501, 289);
            this.ServicesNavigationPanel.TabIndex = 1;
            // 
            // ServicesListPanel
            // 
            this.ServicesListPanel.BackColor = System.Drawing.Color.Transparent;
            this.ServicesListPanel.Controls.Add(this.ServiceList);
            this.ServicesListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServicesListPanel.Location = new System.Drawing.Point(0, 0);
            this.ServicesListPanel.Name = "ServicesListPanel";
            this.ServicesListPanel.Size = new System.Drawing.Size(501, 289);
            this.ServicesListPanel.TabIndex = 1;
            // 
            // ServiceList
            // 
            this.ServiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServiceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceList.FormattingEnabled = true;
            this.ServiceList.ItemHeight = 18;
            this.ServiceList.Location = new System.Drawing.Point(0, 0);
            this.ServiceList.Name = "ServiceList";
            this.ServiceList.ScrollAlwaysVisible = true;
            this.ServiceList.Size = new System.Drawing.Size(501, 289);
            this.ServiceList.TabIndex = 0;
            this.ServiceList.SelectedIndexChanged += new System.EventHandler(this.ServiceList_SelectedIndexChanged);
            // 
            // ServicesEditPanel
            // 
            this.ServicesEditPanel.BackColor = System.Drawing.Color.Transparent;
            this.ServicesEditPanel.Controls.Add(this.groupBox4);
            this.ServicesEditPanel.Controls.Add(this.splitterServiceImageToDescription);
            this.ServicesEditPanel.Controls.Add(this.groupBox3);
            this.ServicesEditPanel.Controls.Add(this.groupBox2);
            this.ServicesEditPanel.Controls.Add(this.groupBox1);
            this.ServicesEditPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ServicesEditPanel.Location = new System.Drawing.Point(520, 103);
            this.ServicesEditPanel.MinimumSize = new System.Drawing.Size(60, 0);
            this.ServicesEditPanel.Name = "ServicesEditPanel";
            this.ServicesEditPanel.Padding = new System.Windows.Forms.Padding(5);
            this.ServicesEditPanel.Size = new System.Drawing.Size(119, 327);
            this.ServicesEditPanel.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ServicePictureDisplay);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(5, 191);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(109, 131);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Image";
            // 
            // ServicePictureDisplay
            // 
            this.ServicePictureDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ServicePictureDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServicePictureDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServicePictureDisplay.Location = new System.Drawing.Point(3, 16);
            this.ServicePictureDisplay.Name = "ServicePictureDisplay";
            this.ServicePictureDisplay.Size = new System.Drawing.Size(103, 112);
            this.ServicePictureDisplay.TabIndex = 0;
            this.ServicePictureDisplay.TabStop = false;
            this.ServicePictureDisplay.Click += new System.EventHandler(this.ServicePictureDisplay_Click);
            // 
            // splitterServiceImageToDescription
            // 
            this.splitterServiceImageToDescription.BackColor = System.Drawing.SystemColors.Window;
            this.splitterServiceImageToDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterServiceImageToDescription.Location = new System.Drawing.Point(5, 181);
            this.splitterServiceImageToDescription.MinExtra = 50;
            this.splitterServiceImageToDescription.MinSize = 50;
            this.splitterServiceImageToDescription.Name = "splitterServiceImageToDescription";
            this.splitterServiceImageToDescription.Size = new System.Drawing.Size(109, 10);
            this.splitterServiceImageToDescription.TabIndex = 9;
            this.splitterServiceImageToDescription.TabStop = false;
            this.splitterServiceImageToDescription.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitterServiceImageToDescription_SplitterMoved);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxDescription);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(5, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(109, 87);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(3, 16);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(103, 68);
            this.textBoxDescription.TabIndex = 1;
            this.textBoxDescription.Leave += new System.EventHandler(this.textBoxDescription_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxServicePrice);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(5, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(109, 46);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Price";
            // 
            // textBoxServicePrice
            // 
            this.textBoxServicePrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxServicePrice.Location = new System.Drawing.Point(3, 16);
            this.textBoxServicePrice.Name = "textBoxServicePrice";
            this.textBoxServicePrice.Size = new System.Drawing.Size(103, 20);
            this.textBoxServicePrice.TabIndex = 3;
            this.textBoxServicePrice.Leave += new System.EventHandler(this.textBoxServicePrice_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxServiceName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 43);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
            // 
            // textBoxServiceName
            // 
            this.textBoxServiceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxServiceName.Location = new System.Drawing.Point(3, 16);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(103, 20);
            this.textBoxServiceName.TabIndex = 1;
            this.textBoxServiceName.Leave += new System.EventHandler(this.textBoxServiceName_Leave);
            // 
            // ServicesTextAreaPanel
            // 
            this.ServicesTextAreaPanel.Controls.Add(this.ServiceTextArea);
            this.ServicesTextAreaPanel.Controls.Add(this.ServicesTextAreaLabel);
            this.ServicesTextAreaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServicesTextAreaPanel.Location = new System.Drawing.Point(3, 3);
            this.ServicesTextAreaPanel.Name = "ServicesTextAreaPanel";
            this.ServicesTextAreaPanel.Padding = new System.Windows.Forms.Padding(8);
            this.ServicesTextAreaPanel.Size = new System.Drawing.Size(636, 100);
            this.ServicesTextAreaPanel.TabIndex = 1;
            // 
            // ServiceTextArea
            // 
            this.ServiceTextArea.AutoWordSelection = true;
            this.ServiceTextArea.ContextMenuStrip = this.RightClickTextArea;
            this.ServiceTextArea.DetectUrls = false;
            this.ServiceTextArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServiceTextArea.EnableAutoDragDrop = true;
            this.ServiceTextArea.Location = new System.Drawing.Point(8, 21);
            this.ServiceTextArea.MaxLength = 0;
            this.ServiceTextArea.Name = "ServiceTextArea";
            this.ServiceTextArea.Size = new System.Drawing.Size(620, 71);
            this.ServiceTextArea.TabIndex = 0;
            this.ServiceTextArea.Text = "";
            this.ServiceTextArea.TextChanged += new System.EventHandler(this.ServiceTextArea_TextChanged);
            this.ServiceTextArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextArea_KeyDown);
            // 
            // ServicesTextAreaLabel
            // 
            this.ServicesTextAreaLabel.AutoSize = true;
            this.ServicesTextAreaLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServicesTextAreaLabel.Location = new System.Drawing.Point(8, 8);
            this.ServicesTextAreaLabel.Name = "ServicesTextAreaLabel";
            this.ServicesTextAreaLabel.Size = new System.Drawing.Size(28, 13);
            this.ServicesTextAreaLabel.TabIndex = 1;
            this.ServicesTextAreaLabel.Text = "Text";
            // 
            // ContactPage
            // 
            this.ContactPage.Controls.Add(this.ContactPagePanelArea);
            this.ContactPage.Location = new System.Drawing.Point(4, 22);
            this.ContactPage.Name = "ContactPage";
            this.ContactPage.Size = new System.Drawing.Size(642, 433);
            this.ContactPage.TabIndex = 2;
            this.ContactPage.Text = "Contact";
            this.ContactPage.UseVisualStyleBackColor = true;
            // 
            // ContactPagePanelArea
            // 
            this.ContactPagePanelArea.Controls.Add(this.ContactTextAreaPanel);
            this.ContactPagePanelArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactPagePanelArea.Location = new System.Drawing.Point(0, 0);
            this.ContactPagePanelArea.Name = "ContactPagePanelArea";
            this.ContactPagePanelArea.Size = new System.Drawing.Size(642, 433);
            this.ContactPagePanelArea.TabIndex = 4;
            // 
            // ContactTextAreaPanel
            // 
            this.ContactTextAreaPanel.Controls.Add(this.ContactTextArea);
            this.ContactTextAreaPanel.Controls.Add(this.ContactTextLabel);
            this.ContactTextAreaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactTextAreaPanel.Location = new System.Drawing.Point(0, 0);
            this.ContactTextAreaPanel.Name = "ContactTextAreaPanel";
            this.ContactTextAreaPanel.Padding = new System.Windows.Forms.Padding(10);
            this.ContactTextAreaPanel.Size = new System.Drawing.Size(642, 433);
            this.ContactTextAreaPanel.TabIndex = 2;
            // 
            // ContactTextArea
            // 
            this.ContactTextArea.AutoWordSelection = true;
            this.ContactTextArea.BackColor = System.Drawing.Color.White;
            this.ContactTextArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactTextArea.ContextMenuStrip = this.RightClickTextArea;
            this.ContactTextArea.DetectUrls = false;
            this.ContactTextArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactTextArea.EnableAutoDragDrop = true;
            this.ContactTextArea.Location = new System.Drawing.Point(10, 23);
            this.ContactTextArea.MaxLength = 0;
            this.ContactTextArea.Name = "ContactTextArea";
            this.ContactTextArea.Size = new System.Drawing.Size(622, 400);
            this.ContactTextArea.TabIndex = 2;
            this.ContactTextArea.Text = "";
            this.ContactTextArea.TextChanged += new System.EventHandler(this.ContactTextArea_TextChanged);
            this.ContactTextArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextArea_KeyDown);
            // 
            // ContactTextLabel
            // 
            this.ContactTextLabel.AutoSize = true;
            this.ContactTextLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContactTextLabel.Location = new System.Drawing.Point(10, 10);
            this.ContactTextLabel.Name = "ContactTextLabel";
            this.ContactTextLabel.Size = new System.Drawing.Size(28, 13);
            this.ContactTextLabel.TabIndex = 1;
            this.ContactTextLabel.Text = "Text";
            // 
            // ServiceListIcons
            // 
            this.ServiceListIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ServiceListIcons.ImageSize = new System.Drawing.Size(32, 32);
            this.ServiceListIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // HomePreviewButton
            // 
            this.HomePreviewButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.HomePreviewButton.Location = new System.Drawing.Point(863, 2);
            this.HomePreviewButton.MaximumSize = new System.Drawing.Size(63, 20);
            this.HomePreviewButton.MinimumSize = new System.Drawing.Size(63, 20);
            this.HomePreviewButton.Name = "HomePreviewButton";
            this.HomePreviewButton.Size = new System.Drawing.Size(63, 20);
            this.HomePreviewButton.TabIndex = 1;
            this.HomePreviewButton.Text = "Preview";
            this.HomePreviewButton.UseVisualStyleBackColor = true;
            this.HomePreviewButton.Click += new System.EventHandler(this.PreviewButton_Click);
            // 
            // ErrorPanel
            // 
            this.ErrorPanel.Controls.Add(this.ErrorAlert);
            this.ErrorPanel.Controls.Add(this.buttonSave);
            this.ErrorPanel.Controls.Add(this.buttonDisplay);
            this.ErrorPanel.Controls.Add(this.buttonSettings);
            this.ErrorPanel.Controls.Add(this.PreviewButton);
            this.ErrorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ErrorPanel.Location = new System.Drawing.Point(0, 459);
            this.ErrorPanel.Name = "ErrorPanel";
            this.ErrorPanel.Padding = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.ErrorPanel.Size = new System.Drawing.Size(650, 22);
            this.ErrorPanel.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSave.Location = new System.Drawing.Point(5, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(51, 20);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.AutoSize = true;
            this.buttonDisplay.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDisplay.Location = new System.Drawing.Point(489, 2);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(51, 20);
            this.buttonDisplay.TabIndex = 6;
            this.buttonDisplay.Text = "Display";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.AutoSize = true;
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSettings.Location = new System.Drawing.Point(540, 2);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(55, 20);
            this.buttonSettings.TabIndex = 5;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // PreviewButton
            // 
            this.PreviewButton.AutoSize = true;
            this.PreviewButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.PreviewButton.Location = new System.Drawing.Point(595, 2);
            this.PreviewButton.Name = "PreviewButton";
            this.PreviewButton.Size = new System.Drawing.Size(55, 20);
            this.PreviewButton.TabIndex = 3;
            this.PreviewButton.Text = "Preview";
            this.PreviewButton.UseVisualStyleBackColor = true;
            this.PreviewButton.Click += new System.EventHandler(this.PreviewButton_Click);
            // 
            // BasePanel
            // 
            this.BasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BasePanel.Location = new System.Drawing.Point(0, 0);
            this.BasePanel.Name = "BasePanel";
            this.BasePanel.Size = new System.Drawing.Size(650, 481);
            this.BasePanel.TabIndex = 2;
            // 
            // FadeTimer
            // 
            this.FadeTimer.Enabled = true;
            this.FadeTimer.Interval = 50;
            this.FadeTimer.Tick += new System.EventHandler(this.fadeTick);
            // 
            // FontChooser
            // 
            this.FontChooser.AllowVerticalFonts = false;
            this.FontChooser.FontMustExist = true;
            // 
            // ErrorAlert
            // 
            this.ErrorAlert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorAlert.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrorAlert.Location = new System.Drawing.Point(56, 2);
            this.ErrorAlert.Name = "ErrorAlert";
            this.ErrorAlert.Size = new System.Drawing.Size(433, 20);
            this.ErrorAlert.TabIndex = 2;
            // 
            // MainApp
            // 
            this.AllowDrop = true;
            this.ClientSize = new System.Drawing.Size(650, 481);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.ErrorPanel);
            this.Controls.Add(this.BasePanel);
            this.Name = "MainApp";
            this.Text = "Website Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainApp_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.MainApp_ResizeEnd);
            this.TabControl.ResumeLayout(false);
            this.HomePage.ResumeLayout(false);
            this.HomePage.PerformLayout();
            this.RightClickTextArea.ResumeLayout(false);
            this.ServicesPage.ResumeLayout(false);
            this.ServicesServicePanel.ResumeLayout(false);
            this.ServicesButtonsPanel.ResumeLayout(false);
            this.ServicesNavigationPanel.ResumeLayout(false);
            this.ServicesListPanel.ResumeLayout(false);
            this.ServicesEditPanel.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServicePictureDisplay)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ServicesTextAreaPanel.ResumeLayout(false);
            this.ServicesTextAreaPanel.PerformLayout();
            this.ContactPage.ResumeLayout(false);
            this.ContactPagePanelArea.ResumeLayout(false);
            this.ContactTextAreaPanel.ResumeLayout(false);
            this.ContactTextAreaPanel.PerformLayout();
            this.ErrorPanel.ResumeLayout(false);
            this.ErrorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage HomePage;
        private System.Windows.Forms.TabPage ServicesPage;
        private System.Windows.Forms.Panel ErrorPanel;
        private System.Windows.Forms.Panel BasePanel;
        private System.Windows.Forms.Timer FadeTimer;
        private System.Windows.Forms.TabPage ContactPage;
        private System.Windows.Forms.ContextMenuStrip RightClickTextArea;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulletPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.Button HomePreviewButton;
        private System.Windows.Forms.Panel ServicesEditPanel;
        private System.Windows.Forms.Panel ServicesNavigationPanel;
        private System.Windows.Forms.Panel ServicesListPanel;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.Panel ContactTextAreaPanel;
        private System.Windows.Forms.RichTextBox ContactTextArea;
        private System.Windows.Forms.Label ContactTextLabel;
        private System.Windows.Forms.Panel ServicesServicePanel;
        private System.Windows.Forms.Panel ServicesTextAreaPanel;
        private System.Windows.Forms.RichTextBox ServiceTextArea;
        private System.Windows.Forms.Label ServicesTextAreaLabel;
        private System.Windows.Forms.FontDialog FontChooser;
        private System.Windows.Forms.ToolStripMenuItem fontColourToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog FileOpener;
        private System.Windows.Forms.Panel ContactPagePanelArea;
        private System.Windows.Forms.ImageList ServiceListIcons;
        private NewLabel ErrorAlert;
        private System.Windows.Forms.Button PreviewButton;
        private System.Windows.Forms.ListBox ServiceList;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox ServicePictureDisplay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxServicePrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxServiceName;
        private System.Windows.Forms.Splitter splitterListToDetails;
        private System.Windows.Forms.Splitter splitterServiceImageToDescription;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.RichTextBox HomeTextArea;
        private System.Windows.Forms.Label HomeTextAreaTitle;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Panel ServicesButtonsPanel;
        private System.Windows.Forms.Button buttonMoveServiceDown;
        private System.Windows.Forms.Button buttonMoveServiceUp;
        private System.Windows.Forms.Panel panelSepRemoveAndMove;
        private System.Windows.Forms.Button RemoveServiceButton;
        private System.Windows.Forms.Button AddServiceButton;
        private System.Windows.Forms.Button buttonSave;
    }
}