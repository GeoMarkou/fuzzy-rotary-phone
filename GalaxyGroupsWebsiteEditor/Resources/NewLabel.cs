using System;
using System.Drawing;
using System.Windows.Forms;

// Taken from stackoverflow.com/questions/2636065/alpha-in-forecolor
namespace GalaxyGroupsWebsiteEditor
{
    class NewLabel : Label
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), this.ClientRectangle, new StringFormat(StringFormat.GenericTypographic));
        }
    }
}