using System;
using System.Drawing;
using System.Windows.Forms;

namespace GalaxyGroupsWebsiteEditor
{
    public partial class ColourChooser : Form
    {
        // Stores the data clicked on by the colour wheel
        private byte red = 0;
        private byte green = 0;
        private byte blue = 0;

        // Loads the current colour
        public ColourChooser()
        {
            InitializeComponent();

            red = Vars.ColourToEdit.R;
            green = Vars.ColourToEdit.G;
            blue = Vars.ColourToEdit.B;

            RedBar.Value = red;
            GreenBar.Value = green;
            BlueBar.Value = blue;

            UpdatePanelColour();
        }

        // Sets a variable and returns
        private void Ok_Click(object sender, EventArgs e)
        {
            Vars.ColourToEdit = Color.FromArgb(red, green, blue);
            this.Close();
        }

        // Just returns without setting the variable
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Updates the colour preview
        private void UpdatePanelColour()
        {
            ColourPreviewPanel.BackColor = Color.FromArgb(red, green, blue);
        }

        // Bars that control RGB value
        #region "Bars"
        private void RedBar_Scroll(object sender, EventArgs e)
        {
            Byte.TryParse(RedBar.Value + "", out red);
            UpdatePanelColour();
        }

        private void GreenBar_Scroll(object sender, EventArgs e)
        {
            Byte.TryParse(GreenBar.Value + "", out green);
            UpdatePanelColour();
        }

        private void BlueBar_Scroll(object sender, EventArgs e)
        {
            Byte.TryParse(BlueBar.Value + "", out blue);
            UpdatePanelColour();
        }
        #endregion
    }
}
