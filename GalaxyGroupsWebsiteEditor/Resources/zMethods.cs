using System;
using System.IO;
using System.Collections.Generic;
using System.Windows;


namespace GalaxyGroupsWebsiteEditor
{
    public static class FileManagement
    {
        /// <summary>
        /// Loads the data from the HTML files
        /// </summary>
        public static void load()
        {
            try
            {
                // Contact page
                if (File.Exists("Contact.html"))
                {
                    getHTML("Contact.html");
                }
                else
                {
                    // do the file chooser thing
                }
            }
            catch (Exception ex) { Vars.Window.PostError(ex); }
            finally
            {
            }
        }




        /// <summary>
        /// Public interface for saving using the list of services
        /// </summary>
        /// <param name="services"></param>
        public static void save(Storage store)
        {
            try
            {
                //File.Create("Home.html");
                // Home page
                string homeFile = "Home.html";
                if (!File.Exists(homeFile))
                {

                }
                string origHome = getHTML(homeFile);
                
                // Services page
                //string servicesFile = "Services.html";
                if (!File.Exists(homeFile))
                {

                }
                //string origServices = getHTML(servicesFile);
                
                // Contact page
                string contactFile = "Contact.html";
                if (!File.Exists(contactFile))
                {

                }
                //string origContact = getHTML(contactFile);

                // Replace the tags with the stuff from the form
                string homeReplace = getBetweenTags("<div id=\"text\">", "</div>", origHome);
                string resultHome = origHome.Replace(homeReplace, store.HomePageText);

                File.WriteAllText("Home.html", resultHome);
                Console.WriteLine("Wrote: " + resultHome);

                //string resultServices = "";
                //File.WriteAllLines("Services.html", serviceText);

                //string resultContact = "";
            }
            catch (Exception ex) { Vars.Window.PostError(ex); }
            finally
            {
            }
        }








        /// <summary>
        /// Returns the text contained in a file
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static string getHTML(string file)
        {
            List<string> result = new List<string>();
            result.AddRange(File.ReadAllLines(file));

            string returning = "";
            foreach (string line in result)
            {
                returning += line + "\r\n";
            }
            return returning;
        }










        /// <summary>
        /// Returns a HTML equivalent of the data stored in a service
        /// </summary>
        /// <param name="temp"></param>
        /// <returns></returns>
        private static string convertServiceToHTML(Service temp)
        {
            return "" + "\r\n" +
                    "                    <div class=\"service\">" + "\r\n" +
                    "                        <div class=\"serviceHeadContainer\">" + "\r\n" +
                    "                            <p class=\"serviceHead\">" + temp.Title + "</p>" + "\r\n" +
                    "                            <p class=\"serviceCost\">" + temp.Price + "</p>" + "\r\n" +
                    "                        </div>" + "\r\n" +
                    "                        <p class=\"serviceText\">" + temp.Text + "</p>" + "\r\n" +
                    "                        <img class=\"serviceImg\" alt=\"cctvimg\" src=\"" + temp.Image + "\" width=\"200px\" />" + "\r\n" +
                    "                    </div>" + "\r\n" +
                    "                    <div class=\"sep\" />" + "\r\n" + "\r\n";
        }






        /// <summary>
        /// Copies each service's data to a string
        /// </summary>
        /// <param name="html"></param>
        /// <param name="services"></param>
        /// <returns></returns>
        private static string implementServicesToHTML(string html, List<Service> services)
        {
            int start = html.IndexOf("<!--START HERE-->");
            int stop = html.IndexOf("<!--STOP HERE-->");

            string before = html.Substring(0, start);
            string after = html.Substring(stop, html.Length - stop);
            string middle = html.Substring(start, stop - start);

            // Get the HTML equivalent of each service and append it to the middle.
            for (int loop = 0; loop < services.Count; loop++)
            {
                middle += convertServiceToHTML(services[loop]);
            }

            return before + middle + after;
        }




















        /// <summary>
        /// Returns the lines between 2 tags
        /// </summary>
        /// <param name="tag1"></param>
        /// <param name="tag2"></param>
        /// <param name="html"></param>
        /// <returns></returns>
        public static string getBetweenTags(string tag1, string tag2, string html)
        {
            int index1 = html.IndexOf(tag1);
            int index2 = html.IndexOf(tag2, index1);  // Only search starting from the 1st tag

            // Return the range between them
            if (index1 < 0 || index2 < 0)
            {
                return null;
            }

            return html.Substring(index1, index2 - index1);
        }










        /// <summary>
        /// Writes error log information
        /// </summary>
        /// <param name="text">Error message</param>
        public static void AppendOrCreate(string text)
        {
            try
            {
                if (File.Exists("log.txt"))
                {
                    File.AppendAllText("log.txt", text);
                }
                else
                {
                    File.WriteAllText("log.txt", text);
                }
            }
            catch (Exception ex) { Vars.Window.PostError(ex); }
            finally
            {
            }
        }
    }
}
