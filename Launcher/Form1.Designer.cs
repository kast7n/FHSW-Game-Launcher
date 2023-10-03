/*
 * In C#, we can define classes in more than 1 file. Using the partial keyword, compiler will find the same classes that have the same name
 * and have the same namespace. This will merge them together.
 * Use: concept/code sacross multiple for easier maintenance, e.g. split accounting and warehouse management functions 
 * So when someone wants to edit accounting functionality - they are in file 1, warehouse management - file 2.
 * 
 * This file will be edited by the designer for GUI, my code and logic is in Form1.cs
 * We manage this file but dont own it, it could be changed back by manager.
 */

namespace Launcher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            statusStrip1 = new StatusStrip();
            statusLabel1 = new ToolStripStatusLabel();
            statusLabel2 = new ToolStripStatusLabel();
            pBoxLogo = new PictureBox();
            buttonSocialDiscord = new PictureBox();
            buttonSocialFacebook = new PictureBox();
            buttonSocialTwitter = new PictureBox();
            pBoxExit = new PictureBox();
            buttonSocialModdb = new PictureBox();
            pBoxServers = new PictureBox();
            pBoxOptions = new PictureBox();
            pBoxUpdate = new PictureBox();
            pBoxPlay = new PictureBox();
            pBoxDonate = new PictureBox();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonSocialDiscord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonSocialFacebook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonSocialTwitter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonSocialModdb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxServers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxOptions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxPlay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxDonate).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Transparent;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel1, statusLabel2 });
            resources.ApplyResources(statusStrip1, "statusStrip1");
            statusStrip1.Name = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // statusLabel1
            // 
            statusLabel1.ForeColor = Color.Gainsboro;
            statusLabel1.Name = "statusLabel1";
            resources.ApplyResources(statusLabel1, "statusLabel1");
            // 
            // statusLabel2
            // 
            statusLabel2.ForeColor = Color.Gainsboro;
            statusLabel2.Name = "statusLabel2";
            resources.ApplyResources(statusLabel2, "statusLabel2");
            // 
            // pBoxLogo
            // 
            pBoxLogo.BackColor = Color.Transparent;
            pBoxLogo.Image = Properties.Resources.FHSW_EUROPE_LOGO;
            resources.ApplyResources(pBoxLogo, "pBoxLogo");
            pBoxLogo.Name = "pBoxLogo";
            pBoxLogo.TabStop = false;
            pBoxLogo.Click += pBoxLogo_Click;
            // 
            // buttonSocialDiscord
            // 
            buttonSocialDiscord.BackColor = Color.Transparent;
            resources.ApplyResources(buttonSocialDiscord, "buttonSocialDiscord");
            buttonSocialDiscord.Name = "buttonSocialDiscord";
            buttonSocialDiscord.TabStop = false;
            buttonSocialDiscord.Click += buttonSocial_Click;
            buttonSocialDiscord.MouseLeave += button_MouseLeave;
            buttonSocialDiscord.MouseHover += button_MouseHover;
            // 
            // buttonSocialFacebook
            // 
            buttonSocialFacebook.BackColor = Color.Transparent;
            resources.ApplyResources(buttonSocialFacebook, "buttonSocialFacebook");
            buttonSocialFacebook.Name = "buttonSocialFacebook";
            buttonSocialFacebook.TabStop = false;
            buttonSocialFacebook.Click += buttonSocial_Click;
            buttonSocialFacebook.MouseLeave += button_MouseLeave;
            buttonSocialFacebook.MouseHover += button_MouseHover;
            // 
            // buttonSocialTwitter
            // 
            buttonSocialTwitter.BackColor = Color.Transparent;
            resources.ApplyResources(buttonSocialTwitter, "buttonSocialTwitter");
            buttonSocialTwitter.Name = "buttonSocialTwitter";
            buttonSocialTwitter.TabStop = false;
            buttonSocialTwitter.Click += buttonSocial_Click;
            buttonSocialTwitter.MouseLeave += button_MouseLeave;
            buttonSocialTwitter.MouseHover += button_MouseHover;
            // 
            // pBoxExit
            // 
            resources.ApplyResources(pBoxExit, "pBoxExit");
            pBoxExit.BackColor = Color.Transparent;
            pBoxExit.BackgroundImage = Properties.Resources.b_exit;
            pBoxExit.Cursor = Cursors.Hand;
            pBoxExit.Name = "pBoxExit";
            pBoxExit.TabStop = false;
            pBoxExit.Click += pictureBox2_Click;
            pBoxExit.MouseLeave += button_MouseLeave;
            pBoxExit.MouseHover += button_MouseHover;
            // 
            // buttonSocialModdb
            // 
            buttonSocialModdb.BackColor = Color.Transparent;
            resources.ApplyResources(buttonSocialModdb, "buttonSocialModdb");
            buttonSocialModdb.Name = "buttonSocialModdb";
            buttonSocialModdb.TabStop = false;
            buttonSocialModdb.Click += buttonSocial_Click;
            buttonSocialModdb.MouseLeave += button_MouseLeave;
            buttonSocialModdb.MouseHover += button_MouseHover;
            // 
            // pBoxServers
            // 
            pBoxServers.BackColor = Color.Transparent;
            pBoxServers.BackgroundImage = Properties.Resources.b_servers;
            resources.ApplyResources(pBoxServers, "pBoxServers");
            pBoxServers.Cursor = Cursors.Hand;
            pBoxServers.Name = "pBoxServers";
            pBoxServers.TabStop = false;
            pBoxServers.Click += pBoxServers_Click;
            pBoxServers.MouseLeave += button_MouseLeave;
            pBoxServers.MouseHover += button_MouseHover;
            // 
            // pBoxOptions
            // 
            pBoxOptions.BackColor = Color.Transparent;
            pBoxOptions.BackgroundImage = Properties.Resources.b_options;
            resources.ApplyResources(pBoxOptions, "pBoxOptions");
            pBoxOptions.Cursor = Cursors.Hand;
            pBoxOptions.Name = "pBoxOptions";
            pBoxOptions.TabStop = false;
            pBoxOptions.Click += pBoxOptions_Click;
            pBoxOptions.MouseLeave += button_MouseLeave;
            pBoxOptions.MouseHover += button_MouseHover;
            // 
            // pBoxUpdate
            // 
            pBoxUpdate.BackColor = Color.Transparent;
            pBoxUpdate.BackgroundImage = Properties.Resources.b_update;
            resources.ApplyResources(pBoxUpdate, "pBoxUpdate");
            pBoxUpdate.Cursor = Cursors.Hand;
            pBoxUpdate.Name = "pBoxUpdate";
            pBoxUpdate.TabStop = false;
            pBoxUpdate.Click += pBoxUpdate_Click;
            pBoxUpdate.MouseLeave += button_MouseLeave;
            pBoxUpdate.MouseHover += button_MouseHover;
            // 
            // pBoxPlay
            // 
            pBoxPlay.BackColor = Color.Transparent;
            pBoxPlay.BackgroundImage = Properties.Resources.b_play;
            resources.ApplyResources(pBoxPlay, "pBoxPlay");
            pBoxPlay.Cursor = Cursors.Hand;
            pBoxPlay.ErrorImage = Properties.Resources.b_play_shine;
            pBoxPlay.Name = "pBoxPlay";
            pBoxPlay.TabStop = false;
            pBoxPlay.Click += pBoxPlay_Click;
            pBoxPlay.MouseLeave += button_MouseLeave;
            pBoxPlay.MouseHover += button_MouseHover;
            // 
            // pBoxDonate
            // 
            pBoxDonate.BackColor = Color.Transparent;
            pBoxDonate.BackgroundImage = Properties.Resources.b_donate;
            resources.ApplyResources(pBoxDonate, "pBoxDonate");
            pBoxDonate.Cursor = Cursors.Hand;
            pBoxDonate.Name = "pBoxDonate";
            pBoxDonate.TabStop = false;
            pBoxDonate.Click += pBoxDonate_Click;
            pBoxDonate.MouseLeave += button_MouseLeave;
            pBoxDonate.MouseHover += button_MouseHover;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.BackgroundKatyusha;
            resources.ApplyResources(this, "$this");
            ControlBox = false;
            Controls.Add(pBoxDonate);
            Controls.Add(pBoxPlay);
            Controls.Add(pBoxUpdate);
            Controls.Add(pBoxOptions);
            Controls.Add(pBoxServers);
            Controls.Add(buttonSocialModdb);
            Controls.Add(pBoxExit);
            Controls.Add(buttonSocialTwitter);
            Controls.Add(buttonSocialFacebook);
            Controls.Add(buttonSocialDiscord);
            Controls.Add(pBoxLogo);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Opacity = 0.95D;
            SizeGripStyle = SizeGripStyle.Hide;
            Load += Form1_Load;
            Paint += Form1_Paint;
            MouseDown += Form1_MouseDown;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonSocialDiscord).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonSocialFacebook).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonSocialTwitter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonSocialModdb).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxServers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxOptions).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxPlay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxDonate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel1;
        private ToolStripStatusLabel statusLabel2;
        private PictureBox pBoxLogo;
        private PictureBox buttonSocialDiscord;
        private PictureBox buttonSocialFacebook;
        private PictureBox buttonSocialTwitter;
        private PictureBox pBoxExit;
        private PictureBox buttonSocialModdb;
        private PictureBox pBoxServers;
        private PictureBox pBoxOptions;
        private PictureBox pBoxUpdate;
        private PictureBox pBoxPlay;
        private PictureBox pBoxDonate;
    }
}