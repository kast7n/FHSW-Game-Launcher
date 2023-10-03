using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Launcher.Options;

namespace Launcher
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        public void setDirectoryTxtBox(string directory)
        {
            gameDirectoryTxtBox.Text = directory;
        }
        public void setUsernameTxtBox(string username)
        {
            mumbleNameTxtBox.Text = username;
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {

        }

        private void BrowseDirectoryBtn_Click(object sender, EventArgs e)
        {
            if (BF1942DirectoryBrowser.ShowDialog() == DialogResult.OK)
            {
                gameDirectoryTxtBox.Text = BF1942DirectoryBrowser.SelectedPath.ToString();

            }
        }

        private void ApplyOptionsBtn_Click(object sender, EventArgs e)
        {
            Options.OptionDirectory.setDirectory(gameDirectoryTxtBox.Text);
            Options.OptionDirectory.setUsername(mumbleNameTxtBox.Text);
            OptionDirectory.exportOptions();
            Form1.optionStatus = false;
            this.Close();

        }

    }
}
