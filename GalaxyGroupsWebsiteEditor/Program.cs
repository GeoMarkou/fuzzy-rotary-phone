using System;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace GalaxyGroupsWebsiteEditor
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (PriorProcess() != null)
            {
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // The main app instance
            Application.Run(new MainApp());
        }


        /// <summary>
        /// Checks if there is an already existing process
        /// </summary>
        /// <returns>A matching process, null if no matches</returns>
        public static Process PriorProcess()
        {
            using (Mutex mutex = new Mutex(true, "Website Editor"))
            {
                Process current = Process.GetCurrentProcess();
                foreach (Process process in Process.GetProcessesByName(current.ProcessName))
                {
                    if (process.Id != current.Id)
                    {
                        return process;
                    }
                }
                return null;
            }
        }
    }
}