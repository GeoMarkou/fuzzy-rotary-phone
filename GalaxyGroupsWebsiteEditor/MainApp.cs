using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace GalaxyGroupsWebsiteEditor
{
    public partial class MainApp : System.Windows.Forms.Form
    {
        Service currentService;
        bool hasChanged = false;

        // Constructor
        public MainApp()
        {
            try
            {
                // Designer
                InitializeComponent();

                // Settings
                Size = Vars.HomePageSize;
                MinimumSize = Vars.HomePageMinSize;
                serviceDetailsEnable(false);

                Vars.Window = this;
                Vars.ColourPick = new ColourChooser();

                // Init
                loadData();
            }
            catch (Exception ex) { PostError(ex); }
        }


        private void TextArea_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
            }
            catch (Exception ex) { PostError(ex); }
        }



        #region "home page"
        #endregion


        #region "Service page"

        // Adds a new service to the list by copying, remaking to size + 1, copying back and appending to end
        private void addService(string Title = "NOT SET", string Text = "NOT SET", string Image = "D:\\Crap I Need But Looks Crappy\\website\\images\\banana.jpg", string Price = "$0.00")
        {
            try
            {
                ServiceList.Items.Add(new Service(Title, Text, Image, Price));
            }
            catch (Exception ex) { PostError(ex); }
        }

        // Clicking the 'add' button
        private void AddServiceButton_Click(object sender, EventArgs e)
        {
            increaseChanged();
            try
            {
                addService();
            }
            catch (Exception ex) { PostError(ex); }
        }

        // Selecing a service in the list box
        private void ServiceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int loc = ServiceList.SelectedIndex;
                if (loc < 0)
                {
                    return;
                }

                currentService = (Service)ServiceList.Items[loc];
                updateServiceListFields();
                serviceDetailsEnable(true);
            }
            catch (Exception ex) { PostError(ex); }
        }

        // Updates the details of the service for editing - name, description, image, price
        private void updateServiceListFields()
        {
            try
            {
                textBoxServiceName.Text = currentService.Title;
                textBoxDescription.Text = currentService.Text;
                textBoxServicePrice.Text = currentService.Price;
                updateImage();
            }
            catch (Exception ex) { PostError(ex); }
        }

        // Clicking the picture
        private void ServicePictureDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                {
                    return;
                }

                currentService.Image = ofd.FileName;
                updateImage();
                increaseChanged();
                updateListBoxEntry();
            }
            catch (Exception ex) { PostError(ex); }
        }

        // Update the picture
        private void updateImage()
        {
            try
            {
                if (currentService == null)
                {
                    return;
                }

                Bitmap originalPic = new Bitmap(currentService.Image);
                ServicePictureDisplay.Image = resizePic(originalPic, ServicePictureDisplay.Size);
            }
            catch (Exception ex) { PostError(ex); }
        }

        // Resizes a picture
        private Bitmap resizePic(Bitmap img, Size bounds)
        {
            Size size = new Size(0,0);
            try
            {
                size = img.Size;

                // Resize vertically, then if it still doesn't fit, resize horizontally
                size.Height = bounds.Height;
                size.Width = (size.Height * img.Width + img.Height - 1) / img.Height;

                if (size.Width > bounds.Width)
                {
                    size.Width = bounds.Width;
                    size.Height = (size.Width * img.Height + img.Width - 1) / img.Width;
                }
            }
            catch (Exception ex) { PostError(ex); }

            return new Bitmap(img, size);
        }

        // Finished editing the name
        private void textBoxServiceName_Leave(object sender, EventArgs e)
        {
            try
            {
                if (textBoxServiceName.Text.Equals(currentService.Title))
                {
                    return;
                }
                currentService.Title = textBoxServiceName.Text;

                increaseChanged();
                updateListBoxEntry();
            }
            catch (Exception ex) { PostError(ex); }
        }

        // Finished editing the price
        private void textBoxServicePrice_Leave(object sender, EventArgs e)
        {
            try
            {
                if (textBoxServicePrice.Text.Equals(currentService.Price))
                {
                    return;
                }
                currentService.Price = textBoxServicePrice.Text;

                increaseChanged();
                updateListBoxEntry();
            }
            catch (Exception ex) { PostError(ex); }
        }

        // Finished editing the description
        private void textBoxDescription_Leave(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDescription.Text.Equals(currentService.Text))
                {
                    return;
                }
                currentService.Text = textBoxDescription.Text;

                increaseChanged();
                updateListBoxEntry();
            }
            catch (Exception ex) { PostError(ex); }
        }

        // Refreshes the list of services
        private void updateListBoxEntry()
        {
            try
            {
                int loc = ServiceList.Items.IndexOf(currentService);
                ServiceList.Items[loc] = new Service(currentService.Title, currentService.Text, currentService.Image, currentService.Price);
                currentService = (Service)ServiceList.Items[loc];
            }
            catch (Exception ex) { PostError(ex); }
        }

        // Changing the text above the list of services
        private void ServiceTextArea_TextChanged(object sender, EventArgs e)
        {
            increaseChanged();
        }

        // Removing a service
        private void RemoveServiceButton_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                return;
            }

            ServiceList.Items.Remove(currentService);
            currentService = null;

            serviceDetailsEnable(false);
            increaseChanged();
        }

        // Splitters
        private void splitterServiceImageToDescription_SplitterMoved(object sender, SplitterEventArgs e)
        {
            updateImage();
        }

        private void splitterListToDetails_SplitterMoved(object sender, SplitterEventArgs e)
        {
            updateImage();
        }

        // Enables or disables the buttons
        private void serviceDetailsEnable(bool enable)
        {
            if (!enable)
            {
                textBoxServiceName.Enabled = false;
                textBoxServiceName.Text = "";

                textBoxDescription.Enabled = false;
                textBoxDescription.Text = "";

                textBoxServicePrice.Enabled = false;
                textBoxServicePrice.Text = "";

                ServicePictureDisplay.Enabled = false;
                ServicePictureDisplay.Image = null;
                ServicePictureDisplay.BackColor = SystemColors.Control;
            }

            else
            {
                ServiceTextArea.Enabled = true;
                textBoxServiceName.Enabled = true;
                textBoxDescription.Enabled = true;
                textBoxServicePrice.Enabled = true;
                ServicePictureDisplay.Enabled = true;
                ServicePictureDisplay.BackColor = SystemColors.Window;
            }
        }

        private bool isEmpty()
        {
            int no = ServiceList.Items.Count;
            if (no <= 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region "persistence"
        // Load data
        private void loadData()
        {
            try
            {
                FileManagement.load();
            }
            catch (Exception ex) { PostError(ex); }
        }



        // Save data
        private void saveData()
        {
            try
            {
                //FileManagement.saveData(FileManagement.getHomePageHTML(new List<));
            }
            catch (Exception ex) { PostError(ex); }
        }
        #endregion


        #region "Right click text area"
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                getTextBox().Cut();
            }
            catch (Exception ex) { PostError(ex); }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                getTextBox().Copy();
            }
            catch (Exception ex) { PostError(ex); }
        }



        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                getTextBox().Paste();
            }
            catch (Exception ex) { PostError(ex); }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FontChooser.ShowDialog();
                getTextBox().SelectionFont = FontChooser.Font;
            }
            catch (Exception ex) { PostError(ex); }
        }

        private void fontColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ColourChooser();
                getTextBox().SelectionColor = Vars.ColourToEdit;
            }
            catch (Exception ex) { PostError(ex); }
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FileOpener.ShowDialog();
                //getTextBox().SelectedText
            }
            catch (Exception ex) { PostError(ex); }
        }

        private void bulletPointToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region "misc methods"
        // Informs the user something went wrong
        public void PostError(Exception error)
        {
            try
            {
                ErrorAlert.ForeColor = Color.FromArgb(255, ErrorAlert.ForeColor.R, ErrorAlert.ForeColor.G, ErrorAlert.ForeColor.B);
                ErrorAlert.Text = "Error: " + error.Message;

                Console.WriteLine("ERROR\r\nType=" + error.GetType() + "\r\nMessage=" + error.Message + "\r\nStack trace:\r\n" + error.StackTrace + "\r\n\r\n");
                FileManagement.AppendOrCreate("ERROR\r\nType=" + error.GetType() + "\r\nMessage=" + error.Message + "\r\nStack trace:\r\n" + error.StackTrace + "\r\n\r\n");

                // Fades it over time
                FadeTimer.Enabled = true;
                Vars.NumberOfFadeTicks = 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.StackTrace); }
        }



        // Fades the error over time
        private void fadeTick(object sender, EventArgs e)
        {
            try
            {
                // Only fades after a delay
                if (Vars.NumberOfFadeTicks < Vars.FadeTicksBeforeFade)
                {
                    Vars.NumberOfFadeTicks += 1;
                    return;
                }
                // If over the limit set to maximum transparancy and disable timer
                if (ErrorAlert.ForeColor.A - Vars.ErrorTextFadeTick < 0)
                {
                    ErrorAlert.ForeColor = Color.FromArgb(0, ErrorAlert.ForeColor.R, ErrorAlert.ForeColor.G, ErrorAlert.ForeColor.B);
                    FadeTimer.Enabled = false;
                    return;
                }
                // Otherwise just increment the transparancy
                ErrorAlert.ForeColor = Color.FromArgb(ErrorAlert.ForeColor.A - Vars.ErrorTextFadeTick, ErrorAlert.ForeColor.R, ErrorAlert.ForeColor.G, ErrorAlert.ForeColor.B);
            }
            catch (Exception ex) { PostError(ex); }
        }



        // Opens the colour choosing dialog
        private void ColourChooser()
        {
            try
            {
                Vars.ColourPick.ShowDialog();
            }
            catch (Exception ex) { PostError(ex); }
        }



        // Tries to preview the page
        private void previewPage()
        {
            try
            {
                new PreviewApplication().ShowDialog();
            }
            catch (Exception ex) { PostError(ex); }
        }




        private void PreviewButton_Click(object sender, EventArgs e)
        {
            try
            {
                previewPage();
            }
            catch (Exception ex) { PostError(ex); }
        }



        // Changes window size depending on the page
        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                if (TabControl.SelectedIndex == 0)
                {
                    this.MinimumSize = Vars.HomePageMinSize;
                    this.Size = Vars.HomePageSize;
                }
                else if (TabControl.SelectedIndex == 1)
                {
                    this.MinimumSize = Vars.ServicePageMinSize;
                    this.Size = Vars.ServicePageSize;
                }
                else if (TabControl.SelectedIndex == 2)
                {
                    this.MinimumSize = Vars.ContactPageMinSize;
                    this.Size = Vars.ContactPageSize;
                }
            }
            catch (Exception ex) { PostError(ex); }
        }



        // Sets the window size for that page to remember for next time
        private void MainApp_ResizeEnd(object sender, EventArgs e)
        {
            try
            {
                if (TabControl.SelectedIndex == 0)
                {
                    Vars.HomePageSize.Width = this.Width;
                    Vars.HomePageSize.Height = this.Height;
                }
                else if (TabControl.SelectedIndex == 1)
                {
                    Vars.ServicePageSize.Width = this.Width;
                    Vars.ServicePageSize.Height = this.Height;

                    // Just update image, is less effort
                    updateImage();
                    /*
                    // Make sure the things don't go outside the window
                    while (ServicePictureDisplay.Size.Width < 20)
                    {
                        this.Width += 25;
                    }

                    while (ServicePictureDisplay.Size.Height < 20)
                    {
                        this.Height += 25;
                    }

                    while (ServicesButtonsPanel.Size.Width < 283)
                    {
                        this.Width += 25;
                    }
                    */
                }
                else if (TabControl.SelectedIndex == 2)
                {
                    Vars.ContactPageSize.Width = this.Width;
                    Vars.ContactPageSize.Height = this.Height;
                }
            }
            catch (Exception ex) { PostError(ex); }
        }
        // Returns the currently active text box
        private RichTextBox getTextBox()
        {
            try
            {
                if (HomeTextArea.ContainsFocus)
                {
                    return HomeTextArea;
                }

                else if (ServiceTextArea.ContainsFocus)
                {
                    return ServiceTextArea;
                }

                else if (ContactTextArea.ContainsFocus)
                {
                    return ContactTextArea;
                }

                throw new Exception("Couldn't find the selected text area");
            }
            catch (Exception ex) { PostError(ex); }
            return null;
        }


        // Ask to save before closing
        private void MainApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hasChanged)
            {
                DialogResult said = MessageBox.Show("There are unsaved changes. Would you like to save?", "Warning", MessageBoxButtons.YesNoCancel);

                if (said == DialogResult.Yes)
                {
                    saveData();
                }

                else if (said == DialogResult.No)
                {
                    // close
                }

                else if (said == DialogResult.Cancel)
                {
                    return;
                }
            }
        }

        private void HomeTextArea_TextChanged(object sender, EventArgs e)
        {
            increaseChanged();
        }


        private void increaseChanged()
        {
            hasChanged = true;
        }

        private void ContactTextArea_TextChanged(object sender, EventArgs e)
        {
            increaseChanged();
        }




        /// <summary>
        /// Settings button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            try
            {
                if (TabControl.SelectedIndex == 0)
                {
                    //changeHomePageSettings();
                }
                else if (TabControl.SelectedIndex == 1)
                {
                }
                else if (TabControl.SelectedIndex == 2)
                {
                }
            }
            catch (Exception ex) { PostError(ex); }
        }




        /// <summary>
        /// Display options button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            //changeDisplaySettings();
        }
        #endregion




        /// <summary>
        /// Removes the current service and re inserts it at index-1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMoveServiceUp_Click(object sender, EventArgs e)
        {
            hasChanged = true;
            int index = ServiceList.Items.IndexOf(currentService);

            if (index <= 0 || index >= ServiceList.Items.Count)
            {
                return;
            }

            ServiceList.Items.RemoveAt(index);
            ServiceList.Items.Insert(index - 1, currentService);
            ServiceList.SelectedIndex = index - 1;
        }




        /// <summary>
        /// Removes the current services and re inserts it at index+1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMoveServiceDown_Click(object sender, EventArgs e)
        {
            hasChanged = true;
            int index = ServiceList.Items.IndexOf(currentService);

            if (index < 0 || index + 1 >= ServiceList.Items.Count)
            {
                return;
            }

            ServiceList.Items.RemoveAt(index);
            ServiceList.Items.Insert(index + 1, currentService);
            ServiceList.SelectedIndex = index + 1;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            FileManagement.save(copyDataIntoStorage());
        }



        /// <summary>
        /// Copies all data from the form into the storage class
        /// </summary>
        private Storage copyDataIntoStorage()
        {
            Storage store = new Storage();
            store.HomePageText = copied.convertRTFToHTML(HomeTextArea.Rtf);
            return store;
        }

















    }
}
