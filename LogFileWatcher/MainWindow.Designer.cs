namespace LogFileWatcher
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FilePathList = new System.Windows.Forms.ListBox();
            this.RemoveSelectedButton = new System.Windows.Forms.Button();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FilePathList
            // 
            this.FilePathList.FormattingEnabled = true;
            this.FilePathList.Location = new System.Drawing.Point(1, 45);
            this.FilePathList.Name = "FilePathList";
            this.FilePathList.Size = new System.Drawing.Size(508, 303);
            this.FilePathList.TabIndex = 0;
            // 
            // RemoveSelectedButton
            // 
            this.RemoveSelectedButton.Location = new System.Drawing.Point(423, 12);
            this.RemoveSelectedButton.Name = "RemoveSelectedButton";
            this.RemoveSelectedButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveSelectedButton.TabIndex = 1;
            this.RemoveSelectedButton.Text = "Remove Selected";
            this.RemoveSelectedButton.UseVisualStyleBackColor = true;
            this.RemoveSelectedButton.Click += new System.EventHandler(this.RemoveSelectedButton_Click);
            // 
            // AddFileButton
            // 
            this.AddFileButton.Location = new System.Drawing.Point(12, 12);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(75, 23);
            this.AddFileButton.TabIndex = 2;
            this.AddFileButton.Text = "Add File...";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 346);
            this.Controls.Add(this.AddFileButton);
            this.Controls.Add(this.RemoveSelectedButton);
            this.Controls.Add(this.FilePathList);
            this.MaximumSize = new System.Drawing.Size(526, 384);
            this.MinimumSize = new System.Drawing.Size(526, 384);
            this.Name = "MainWindow";
            this.Text = "Log File Watcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FilePathList;
        private System.Windows.Forms.Button RemoveSelectedButton;
        private System.Windows.Forms.Button AddFileButton;
    }
}

