using System;
using System.Collections.Generic;
using System.IO;

/**
 * This FileSystemWatcher based implementation is kept in the code of this demo app only for reference.
 * It was found to be unreliable, giving both false negatives and false positives.  The polling 
 * implementation should be used instead.
 */
namespace LogFileWatcher
{
    class SystemFileWatcher : BaseFileWatcher, IFileWatcher
    {
        private IList<FileSystemWatcher> watchers;

        public SystemFileWatcher(INotificationSender notificationSender) : base(notificationSender)
        {
            this.watchers = new List<FileSystemWatcher>();
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
            this.notificationSender.ShowNotification("File Output Detected", e.FullPath);
        }

        protected override void CreateFileWatcher(string path)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = Path.GetDirectoryName(path);
            watcher.Filter = Path.GetFileName(path);
            watcher.NotifyFilter = NotifyFilters.Size;
            watcher.Changed += new FileSystemEventHandler(this.OnChanged);
            watcher.EnableRaisingEvents = true;

            this.watchers.Add(watcher);
        }

        protected override void DestroyFileWatcher(string path)
        {
            foreach (var watcher in this.watchers)
            {
                if (watcher.Path == Path.GetDirectoryName(path) && watcher.Filter == Path.GetFileName(path))
                {
                    this.watchers.Remove(watcher);
                    break;
                }
            }
        }
    }
}
