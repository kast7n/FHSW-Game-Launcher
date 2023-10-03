using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Security.Policy;
using Launcher.Updater;
using Launcher.Options;
using System.Diagnostics;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Reflection;
using Launcher.Properties;

namespace Launcher
{
    public partial class Form1 : Form
    {
        private Color _borderColor = Color.DarkGray;
        private int _borderSize = 2;
        private int _borderRadius = 5;
        OptionDirectory directoryLocation;
        public static Boolean optionStatus;
        string gameExe;

        public Form1()
        {
            InitializeComponent();  // Need to keep this here so it initializes user interface
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(_borderSize);
            directoryLocation = new OptionDirectory();
            optionStatus = false;
            imageRandomiser();


        }

        public void imageRandomiser()
        {
            //string imageDirectory = Resources.background;
            int randNum = RandomNumberGenerator.GetInt32(11);

            switch (randNum)
            {
                //case 0: base.BackgroundImage = System.Drawing.Bitmap.FromFile(Path.Combine(imageDirectory, "background.jpg")); break;
                case 0: base.BackgroundImage = Resources.BackgroundAppenines; base.BackgroundImageLayout = ImageLayout.Center; break;
                //case 1: base.BackgroundImage = System.Drawing.Bitmap.FromFile(Path.Combine(imageDirectory, "background2.png")); break;
                case 1: base.BackgroundImage = Resources.BackgroundArtillery; base.BackgroundImageLayout = ImageLayout.Center; break;
                case 2: base.BackgroundImage = Resources.BackgroundAsianBridge; base.BackgroundImageLayout = ImageLayout.Center; break;
                case 3: base.BackgroundImage = Resources.BackgroundBerlin; base.BackgroundImageLayout = ImageLayout.Center; break;
                case 4: base.BackgroundImage = Resources.BackgroundCrete; base.BackgroundImageLayout = ImageLayout.Center; break;
                case 5: base.BackgroundImage = Resources.BackgroundDeutschesHeli; base.BackgroundImageLayout = ImageLayout.Center; break;
                case 6: base.BackgroundImage = Resources.BackgroundWarship; base.BackgroundImageLayout = ImageLayout.Center; break;
                case 7: base.BackgroundImage = Resources.BackgroundKatyusha; base.BackgroundImageLayout = ImageLayout.Center; break;
                case 8: base.BackgroundImage = Resources.BackgroundReichstag; base.BackgroundImageLayout = ImageLayout.Center; break;
                case 9: base.BackgroundImage = Resources.BackgroundSoviet; base.BackgroundImageLayout = ImageLayout.Center; break;
                //default: base.BackgroundImage = System.Drawing.Bitmap.FromFile(Path.Combine(imageDirectory, "background.jpg")); break;
                default: base.BackgroundImage = Resources.BackgroundElAlamein; break;
            }

        }

        //Source: https://www.youtube.com/watch?v=oa_zpVv_Tqk - can finish this later to make the edges smooth, time 6:17/21:24
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Private methods to define border
        private GraphicsPath _GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void _FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = _GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);

                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);

                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        // Event methods
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Allow dragging the window on the screen
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Override paint event, must be before the Paint event below. 
            base.OnPaintBackground(e);

            // Smooth the borders
            Rectangle rectForm = this.ClientRectangle;
            //int mWidth = rectForm.Width / 2;
            //int mHeight = rectForm.Height / 2;
            // TBC

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Draw border with radius, colour, and size that we specified 
            _FormRegionAndBorder(this, _borderRadius, e.Graphics, _borderColor, _borderSize);
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroSetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Information whether the launcher is connected/disconnected from the download server
            // TBC
        }


        private void buttonSocial_Click(object sender, EventArgs e)
        {
            // Actions to take when user clicks the social buttons
            var pictureBox = sender as PictureBox;
            var pBoxName = pictureBox.Name;

            //if (pBoxName == "buttonSocialDiscord" || pBoxName == "buttonSocialFacebook" || pBoxName == "buttonSocialTwitter")
            //{
            switch (pBoxName)
            {
                case "buttonSocialDiscord":
                    string social_url_discord = "https://discord.gg/BdSp5h5NuS";
                    System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = social_url_discord, UseShellExecute = true });
                    break;
                case "buttonSocialFacebook":
                    string social_url_facebook = "https://www.facebook.com/profile.php?id=100042339888497";
                    System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = social_url_facebook, UseShellExecute = true });
                    break;
                case "buttonSocialTwitter":
                    string social_url_twitter = "https://twitter.com/EuropeFhsw";
                    System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = social_url_twitter, UseShellExecute = true });
                    break;
                case "buttonSocialHomepage":
                    string social_url_homepage = "http://www.fhsw-europe.com/";
                    System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = social_url_homepage, UseShellExecute = true });
                    break;
                case "buttonSocialModdb":
                    string social_url_moddb = "https://www.moddb.com/mods/fhsw-european-mappacks";
                    System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = @social_url_moddb, UseShellExecute = true });
                    break;
                default:
                    break;
            }
            //}
            //TBC - needs to redirect user to open browser and point them to the links
        }
        private void button_MouseHover(object sender, EventArgs e)
        {
            // Set colour of buttons to DatkGrey when mouse hovers over them
            var pictureBox = sender as PictureBox;
            var pBoxName = pictureBox.Name;
            switch (pBoxName)
            {
                case "pBoxExit": pBoxExit.BackgroundImage = Resources.b_exit_shine; break;
                case "pBoxDonate": pBoxDonate.BackgroundImage = Resources.b_donate_shine; break;
                case "pBoxOptions": pBoxOptions.BackgroundImage = Resources.b_options_shine; break;
                case "pBoxServers": pBoxServers.BackgroundImage = Resources.b_servers_shine; break;
                case "pBoxUpdate": pBoxUpdate.BackgroundImage = Resources.b_update_shine; break;
                case "pBoxPlay": pBoxPlay.BackgroundImage = Resources.b_play_shine; break;
            }
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            // Set colour of buttons back to transparent when mouse leaves them
            var pictureBox = sender as PictureBox;
            var pBoxName = pictureBox.Name;
            switch (pBoxName)
            {
                case "pBoxExit": pBoxExit.BackgroundImage = Resources.b_exit; break;
                case "pBoxDonate": pBoxDonate.BackgroundImage = Resources.b_donate; break;
                case "pBoxOptions": pBoxOptions.BackgroundImage = Resources.b_options; break;
                case "pBoxServers": pBoxServers.BackgroundImage = Resources.b_servers; break;
                case "pBoxUpdate": pBoxUpdate.BackgroundImage = Resources.b_update; break;
                case "pBoxPlay": pBoxPlay.BackgroundImage = Resources.b_play; break;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Close the launcher
            Close();
        }

        private void pBoxUpdate_Click(object sender, EventArgs e)
        {
            // Not ok - everytime they click update, new object is created in memory
            // click enough times and boom, overflow
            Update update = new Update();
            string status = update.StartUpdate();
            statusLabel2.Text = status;
        }

        private void pBoxDonate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = @"https://www.paypal.com/paypalme/fhsweurope", UseShellExecute = true });
        }

        private void pBoxPlay_Click(object sender, EventArgs e)
        {
            //quick join server is gonna be a seperate button  +joinServer 176.9.19.239:14567
            System.Diagnostics.Process.Start(new ProcessStartInfo { WorkingDirectory = directoryLocation.getDirectory(), FileName = "BF1942.exe", UseShellExecute = true, Arguments = "+game FHSW +restart 1" });
            System.Diagnostics.Process.Start(new ProcessStartInfo { WorkingDirectory = Path.Combine(directoryLocation.getDirectory(), "mumble-pr1942"), FileName = "mumble.exe", UseShellExecute = true, Arguments = "+xdg-open mumble://" + directoryLocation.getUsername().Replace(" ", "") + ":@176.9.19.239/" });
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pBoxOptions_Click(object sender, EventArgs e)
        {
            if (optionStatus == false)
            {
                OptionsForm options = new OptionsForm();
                options.WindowState = FormWindowState.Minimized;
                options.Show();
                options.WindowState = FormWindowState.Normal;
                options.setDirectoryTxtBox(directoryLocation.getDirectory());
                options.setUsernameTxtBox(directoryLocation.getUsername());
                Form1.optionStatus = true;
            }



        }

        private void pBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void pBoxServers_Click(object sender, EventArgs e)
        {
            ServersForm servers = new ServersForm(directoryLocation);
            servers.WindowState = FormWindowState.Minimized;
            servers.Show();
            servers.WindowState = FormWindowState.Normal;
            servers.StartPosition = FormStartPosition.CenterParent;

        }
    }
}