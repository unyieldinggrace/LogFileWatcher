using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogFileWatcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var fileWatcher = new PollingFileWatcher(new NotificationSender());
            var mainWindow = new MainWindow(fileWatcher);
            mainWindow.Show();

            Application.Run(mainWindow);
        }
    }
}
