using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace GalaxyGroupsWebsiteEditor
{
    public static class Vars
    {


        // Application pointers
        public static MainApp Window;
        public static ColourChooser ColourPick;
        public static PreviewApplication Preview;





        public static string finalText = "";




        // Form data
        public static Size HomePageSize = new System.Drawing.Size(500, 300);
        public static Size HomePageMinSize = new System.Drawing.Size(275, 200);

        public static Size ServicePageSize = new System.Drawing.Size(500, 550);
        public static Size ServicePageMinSize = new System.Drawing.Size(437, 450);

        public static Size ContactPageSize = new System.Drawing.Size(500, 300);
        public static Size ContactPageMinSize = new System.Drawing.Size(275, 200);





        // Counters
        public static int NumberOfFadeTicks = 0;
        public readonly static int FadeTicksBeforeFade = 10;
        public readonly static int ErrorTextFadeTick = 5;




        // Colours
        public static Color HomeTextColour;
        public static Color ColourToEdit;




        // Path strings
        public static string PreviewURL = "D:\\Crap I Need But LooCrappy\\website\\Services.html";
    }






    // Logical storage of the services
    public class Service
    {
        private string title = "";
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        private string text = "";
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
            }
        }

        private string image = "";
        public string Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
            }
        }

        private string price = "";
        public string Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public Service() { }

        public Service(string _title, string _text, string _image, string _price)
        {
            Title = _title;
            Text = _text;
            Image = _image;
            Price = _price;
        }

        public override string ToString()
        {
            return Title;
        }
    }




    public class MyListBox : ListBox
    {
        public MyListBox() { }
        public readonly int iconWidth = 20;
        public readonly int iconHeight = 20;
        public readonly int paddingBetweenIconAndText = 5;

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index >= Items.Count || e.Index < 0)
            {
                return;
            }

            Service item = (Service)Items[e.Index];
            
            if (item == null)
            {
                return;
            }

            e.Graphics.DrawImage(new Bitmap(item.Image), new Rectangle(0, 0, iconWidth, iconHeight));
            e.Graphics.DrawString(item.ToString(), Font, new SolidBrush(Color.Black), new PointF(iconWidth + paddingBetweenIconAndText, 0));
        }
    }
}