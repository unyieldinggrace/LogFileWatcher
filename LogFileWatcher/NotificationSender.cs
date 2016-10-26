using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace LogFileWatcher
{
    class NotificationSender : INotificationSender
    {
        private const int DefaultTimeout = 10000;
        private NotifyIcon notifyIcon;

        public NotificationSender()
        {
            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
            //notifyIcon.Icon = new Icon(@"C:\Users\Nick\Projects\notify-send\notify-send.ico");
            notifyIcon.Text = "Log File Watcher";

            notifyIcon.BalloonTipIcon = ToolTipIcon.Warning;
            notifyIcon.Visible = true;
        }

        public void ShowNotification(string Title, string Message)
        {
            notifyIcon.BalloonTipTitle = Title;
            notifyIcon.BalloonTipText = Message;
            notifyIcon.ShowBalloonTip(DefaultTimeout);
        }
    }
}
