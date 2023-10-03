using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Launcher.Options;

namespace Launcher
{
    public partial class ServersForm : Form
    {
        OptionDirectory directoryLocation;
        public ServersForm(OptionDirectory directoryLocation)
        {
            this.directoryLocation = directoryLocation;
            InitializeComponent();
        }

        private void serverListCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void server1PlayPB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo { WorkingDirectory = directoryLocation.getDirectory(), FileName = "BF1942.exe", UseShellExecute = true, Arguments = "+game FHSW +restart 1 +joinServer 176.9.19.239:14567" });
            System.Diagnostics.Process.Start(new ProcessStartInfo { WorkingDirectory = Path.Combine(directoryLocation.getDirectory(), "mumble-pr1942"), FileName = "mumble.exe", UseShellExecute = true, Arguments = "+xdg-open mumble://" + directoryLocation.getUsername().Replace(" ", "") + ":@176.9.19.239/" });
        }

        private void server2PlayPB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo { WorkingDirectory = directoryLocation.getDirectory(), FileName = "BF1942.exe", UseShellExecute = true, Arguments = "+game BF1918 +restart 1 +joinServer 176.9.19.239:14568" });
            System.Diagnostics.Process.Start(new ProcessStartInfo { WorkingDirectory = Path.Combine(directoryLocation.getDirectory(), "mumble-pr1942"), FileName = "mumble.exe", UseShellExecute = true, Arguments = "+xdg-open mumble://" + directoryLocation.getUsername().Replace(" ", "") + ":@176.9.19.239/" });

        }
    }
}
