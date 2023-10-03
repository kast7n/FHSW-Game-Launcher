namespace Launcher
{
    partial class OptionsForm
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
            browseDirectoryBtn = new Button();
            applyOptionsBtn = new Button();
            gameDirectoryTxtBox = new TextBox();
            directoryLabel = new Label();
            BF1942DirectoryBrowser = new FolderBrowserDialog();
            mumbleNameLabel = new Label();
            mumbleNameTxtBox = new TextBox();
            SuspendLayout();
            // 
            // browseDirectoryBtn
            // 
            browseDirectoryBtn.Location = new Point(714, 30);
            browseDirectoryBtn.Name = "browseDirectoryBtn";
            browseDirectoryBtn.Size = new Size(75, 23);
            browseDirectoryBtn.TabIndex = 0;
            browseDirectoryBtn.Text = "Browse Directory";
            browseDirectoryBtn.UseVisualStyleBackColor = true;
            browseDirectoryBtn.Click += BrowseDirectoryBtn_Click;
            // 
            // applyOptionsBtn
            // 
            applyOptionsBtn.Location = new Point(714, 417);
            applyOptionsBtn.Name = "applyOptionsBtn";
            applyOptionsBtn.Size = new Size(75, 23);
            applyOptionsBtn.TabIndex = 1;
            applyOptionsBtn.Text = "Apply Changes";
            applyOptionsBtn.UseVisualStyleBackColor = true;
            applyOptionsBtn.Click += ApplyOptionsBtn_Click;
            // 
            // gameDirectoryTxtBox
            // 
            gameDirectoryTxtBox.Location = new Point(117, 32);
            gameDirectoryTxtBox.Name = "gameDirectoryTxtBox";
            gameDirectoryTxtBox.Size = new Size(592, 23);
            gameDirectoryTxtBox.TabIndex = 2;
            gameDirectoryTxtBox.Text = "Choose the folder of the game";
            // 
            // directoryLabel
            // 
            directoryLabel.AutoSize = true;
            directoryLabel.Location = new Point(10, 34);
            directoryLabel.Name = "directoryLabel";
            directoryLabel.Size = new Size(92, 15);
            directoryLabel.TabIndex = 3;
            directoryLabel.Text = "Game Directory:";
            // 
            // BF1942DirectoryBrowser
            // 
            BF1942DirectoryBrowser.Description = "Browser used to search for the game folder";
            // 
            // mumbleNameLabel
            // 
            mumbleNameLabel.AutoSize = true;
            mumbleNameLabel.Location = new Point(10, 72);
            mumbleNameLabel.Name = "mumbleNameLabel";
            mumbleNameLabel.Size = new Size(63, 15);
            mumbleNameLabel.TabIndex = 4;
            mumbleNameLabel.Text = "Username:";
            // 
            // mumbleNameTxtBox
            // 
            mumbleNameTxtBox.Location = new Point(117, 64);
            mumbleNameTxtBox.Name = "mumbleNameTxtBox";
            mumbleNameTxtBox.Size = new Size(592, 23);
            mumbleNameTxtBox.TabIndex = 5;
            // 
            // OptionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mumbleNameTxtBox);
            Controls.Add(mumbleNameLabel);
            Controls.Add(directoryLabel);
            Controls.Add(gameDirectoryTxtBox);
            Controls.Add(applyOptionsBtn);
            Controls.Add(browseDirectoryBtn);
            Name = "OptionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Options";
            WindowState = FormWindowState.Minimized;
            Load += OptionsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button browseDirectoryBtn;
        private Button applyOptionsBtn;
        private TextBox gameDirectoryTxtBox;
        private Label directoryLabel;
        private FolderBrowserDialog BF1942DirectoryBrowser;
        private Label mumbleNameLabel;
        private TextBox mumbleNameTxtBox;
    }
}