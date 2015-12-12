using System;
using System.IO;
using System.Windows.Forms;

namespace GalaxyGroupsWebsiteEditor
{
    public partial class PreviewApplication : Form
    {
        // Make the size a % of the screen and navigate to the given url
        public PreviewApplication()
        {
            InitializeComponent();

            this.Width = (int)(Screen.FromControl(this).Bounds.Width * 0.75);
            this.Height = (int)(Screen.FromControl(this).Bounds.Height * 0.75);

            if (File.Exists(Vars.PreviewURL))
            {
                PreviewWebsite.Navigate(Vars.PreviewURL);
            }
            else
            {
                throw new IOException("Page was not found, aborting preview.");
            }
        }
    }
}
