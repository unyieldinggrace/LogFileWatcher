using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LogFileWatcher
{
    class PollingFileWatcher : BaseFileWatcher
    {
        private Timer timer;
        private static int pollingInterval = 1000;
        private IDictionary<string, long> fileSizes;

        public PollingFileWatcher(INotificationSender notificationSender) : base(notificationSender)
        {
            fileSizes = new Dictionary<string, long>();

            this.timer = new Timer();
            this.timer.Interval = PollingFileWatcher.pollingInterval;
            this.timer.Tick += checkForFileChanges;
            this.timer.Start();
        }

        protected override void CreateFileWatcher(string path)
        {
            fileSizes.Add(path, this.getFileSize(path));
        }

        protected override void DestroyFileWatcher(string path)
        {
            fileSizes.Remove(path);
        }

        private long getFileSize(string path)
        {
            var fileInfo = new FileInfo(path);
            return fileInfo.Length;
        }

        private void checkForFileChanges(object sender, EventArgs e)
        {
            foreach (string path in this.paths)
            {
                var oldSize = this.fileSizes[path];
                var newSize = this.getFileSize(path);

                if (oldSize != newSize)
                {
                    this.notificationSender.ShowNotification("File change detected", path);
                    this.fileSizes[path] = newSize;
                }
            }
        }
    }
}
