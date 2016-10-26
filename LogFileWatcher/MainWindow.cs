using System;
using System.Reflection;
using System.Windows.Forms;

namespace LogFileWatcher
{
    public partial class MainWindow : Form
    {
        private IFileWatcher fileWatcher;

        public MainWindow(IFileWatcher fileWatcher)
        {
            InitializeComponent();
            this.fileWatcher = fileWatcher;
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            var fileChooserDialog = new OpenFileDialog();
            var result = fileChooserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (!FilePathList.Items.Contains(fileChooserDialog.FileName))
                {
                    FilePathList.Items.Add(fileChooserDialog.FileName);
                    fileWatcher.StartWatchingFile(fileChooserDialog.FileName);
                }
            }
        }

        private void RemoveSelectedButton_Click(object sender, EventArgs e)
        {
            if (this.FilePathList.SelectedIndex >= 0)
            {
                var path = this.FilePathList.SelectedItem.ToString();
                fileWatcher.StopWatchingFile(path);
                FilePathList.Items.RemoveAt(this.FilePathList.SelectedIndex);
            }
        }
    }
}
