using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogFileWatcher
{
    abstract class BaseFileWatcher : IFileWatcher
    {
        protected IList<string> paths;

        protected INotificationSender notificationSender;

        public BaseFileWatcher(INotificationSender notificationSender)
        {
            this.notificationSender = notificationSender;
            this.paths = new List<string>();
        }

        public void StartWatchingFile(string path)
        {
            if (this.paths.Contains(path))
            {
                return;
            }

            this.paths.Add(path);
            this.CreateFileWatcher(path);
        }

        public void StopWatchingFile(string path)
        {
            this.paths.Remove(path);
            this.DestroyFileWatcher(path);
        }

        protected abstract void CreateFileWatcher(string path);

        protected abstract void DestroyFileWatcher(string path);
    }
}
