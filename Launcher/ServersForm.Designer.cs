namespace Launcher
{
    partial class ServersForm
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
            server1Panel = new FlowLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            server1PlayPB = new PictureBox();
            serverHeaderPanel = new FlowLayoutPanel();
            serverNameLabel = new Label();
            serverIpLabel = new Label();
            serverModLabel = new Label();
            regionLabel = new Label();
            joinLabel = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            server2PlayPB = new PictureBox();
            serverListCloseBtn = new Button();
            server1Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)server1PlayPB).BeginInit();
            serverHeaderPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)server2PlayPB).BeginInit();
            SuspendLayout();
            // 
            // server1Panel
            // 
            server1Panel.BackColor = Color.FromArgb(22, 22, 22);
            server1Panel.BorderStyle = BorderStyle.FixedSingle;
            server1Panel.Controls.Add(label2);
            server1Panel.Controls.Add(label3);
            server1Panel.Controls.Add(label4);
            server1Panel.Controls.Add(label5);
            server1Panel.Controls.Add(server1PlayPB);
            server1Panel.Location = new Point(12, 37);
            server1Panel.Name = "server1Panel";
            server1Panel.Size = new Size(660, 30);
            server1Panel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Sitka Small", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 5);
            label2.Margin = new Padding(3, 5, 53, 0);
            label2.Name = "label2";
            label2.Size = new Size(176, 16);
            label2.TabIndex = 3;
            label2.Text = "FHSW0.621 fhsw-europe.com";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(235, 5);
            label3.Margin = new Padding(3, 5, 20, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 16);
            label3.TabIndex = 4;
            label3.Text = "176.9.19.239:14567";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(376, 5);
            label4.Margin = new Padding(3, 5, 40, 0);
            label4.Name = "label4";
            label4.Size = new Size(42, 16);
            label4.TabIndex = 5;
            label4.Text = "FHSW";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(461, 5);
            label5.Margin = new Padding(3, 5, 65, 0);
            label5.Name = "label5";
            label5.Size = new Size(56, 16);
            label5.TabIndex = 6;
            label5.Text = "Germany";
            // 
            // server1PlayPB
            // 
            server1PlayPB.BackColor = Color.Transparent;
            server1PlayPB.BackgroundImage = Properties.Resources.serverPlayBtn;
            server1PlayPB.BackgroundImageLayout = ImageLayout.Stretch;
            server1PlayPB.Cursor = Cursors.Hand;
            server1PlayPB.Location = new Point(585, 3);
            server1PlayPB.Name = "server1PlayPB";
            server1PlayPB.Size = new Size(50, 26);
            server1PlayPB.TabIndex = 7;
            server1PlayPB.TabStop = false;
            server1PlayPB.Click += server1PlayPB_Click;
            // 
            // serverHeaderPanel
            // 
            serverHeaderPanel.BackColor = Color.FromArgb(22, 22, 22);
            serverHeaderPanel.BorderStyle = BorderStyle.FixedSingle;
            serverHeaderPanel.Controls.Add(serverNameLabel);
            serverHeaderPanel.Controls.Add(serverIpLabel);
            serverHeaderPanel.Controls.Add(serverModLabel);
            serverHeaderPanel.Controls.Add(regionLabel);
            serverHeaderPanel.Controls.Add(joinLabel);
            serverHeaderPanel.Controls.Add(label1);
            serverHeaderPanel.Cursor = Cursors.Hand;
            serverHeaderPanel.Location = new Point(12, 12);
            serverHeaderPanel.Name = "serverHeaderPanel";
            serverHeaderPanel.Size = new Size(660, 19);
            serverHeaderPanel.TabIndex = 3;
            // 
            // serverNameLabel
            // 
            serverNameLabel.AutoSize = true;
            serverNameLabel.Font = new Font("Sitka Small", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            serverNameLabel.ForeColor = Color.FromArgb(255, 255, 128);
            serverNameLabel.Location = new Point(3, 0);
            serverNameLabel.Margin = new Padding(3, 0, 150, 0);
            serverNameLabel.Name = "serverNameLabel";
            serverNameLabel.Size = new Size(81, 16);
            serverNameLabel.TabIndex = 0;
            serverNameLabel.Text = "Server Name";
            // 
            // serverIpLabel
            // 
            serverIpLabel.AutoSize = true;
            serverIpLabel.Font = new Font("Sitka Small", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            serverIpLabel.ForeColor = Color.FromArgb(255, 255, 128);
            serverIpLabel.Location = new Point(237, 0);
            serverIpLabel.Margin = new Padding(3, 0, 80, 0);
            serverIpLabel.Name = "serverIpLabel";
            serverIpLabel.Size = new Size(55, 16);
            serverIpLabel.TabIndex = 1;
            serverIpLabel.Text = "IP:PORT";
            // 
            // serverModLabel
            // 
            serverModLabel.AutoSize = true;
            serverModLabel.Font = new Font("Sitka Small", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            serverModLabel.ForeColor = Color.FromArgb(255, 255, 128);
            serverModLabel.Location = new Point(375, 0);
            serverModLabel.Margin = new Padding(3, 0, 40, 0);
            serverModLabel.Name = "serverModLabel";
            serverModLabel.Size = new Size(35, 16);
            serverModLabel.TabIndex = 2;
            serverModLabel.Text = "MOD";
            // 
            // regionLabel
            // 
            regionLabel.AutoSize = true;
            regionLabel.Font = new Font("Sitka Small", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            regionLabel.ForeColor = Color.FromArgb(255, 255, 128);
            regionLabel.Location = new Point(453, 0);
            regionLabel.Margin = new Padding(3, 0, 60, 0);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new Size(67, 16);
            regionLabel.TabIndex = 2;
            regionLabel.Text = "LOCATION";
            // 
            // joinLabel
            // 
            joinLabel.AutoSize = true;
            joinLabel.Font = new Font("Sitka Small", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            joinLabel.ForeColor = Color.FromArgb(255, 255, 128);
            joinLabel.Location = new Point(583, 0);
            joinLabel.Name = "joinLabel";
            joinLabel.Size = new Size(34, 16);
            joinLabel.TabIndex = 2;
            joinLabel.Text = "JOIN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 255, 128);
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(60, 16);
            label1.TabIndex = 2;
            label1.Text = "Server IP";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(22, 22, 22);
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(label8);
            flowLayoutPanel1.Controls.Add(label9);
            flowLayoutPanel1.Controls.Add(server2PlayPB);
            flowLayoutPanel1.Location = new Point(12, 73);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(660, 30);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Sitka Small", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 5);
            label6.Margin = new Padding(3, 5, 25, 0);
            label6.Name = "label6";
            label6.Size = new Size(204, 16);
            label6.TabIndex = 3;
            label6.Text = " BF1918+EOD 3.3 fhsw-europe.com";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Small", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(235, 5);
            label7.Margin = new Padding(3, 5, 20, 0);
            label7.Name = "label7";
            label7.Size = new Size(118, 16);
            label7.TabIndex = 4;
            label7.Text = "176.9.19.239:14568";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Small", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(376, 5);
            label8.Margin = new Padding(3, 5, 35, 0);
            label8.Name = "label8";
            label8.Size = new Size(47, 16);
            label8.TabIndex = 5;
            label8.Text = "BF1918";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Small", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(461, 5);
            label9.Margin = new Padding(3, 5, 65, 0);
            label9.Name = "label9";
            label9.Size = new Size(56, 16);
            label9.TabIndex = 6;
            label9.Text = "Germany";
            // 
            // server2PlayPB
            // 
            server2PlayPB.BackColor = Color.Transparent;
            server2PlayPB.BackgroundImage = Properties.Resources.serverPlayBtn;
            server2PlayPB.BackgroundImageLayout = ImageLayout.Stretch;
            server2PlayPB.Cursor = Cursors.Hand;
            server2PlayPB.Location = new Point(585, 3);
            server2PlayPB.Name = "server2PlayPB";
            server2PlayPB.Size = new Size(50, 26);
            server2PlayPB.TabIndex = 7;
            server2PlayPB.TabStop = false;
            server2PlayPB.Click += server2PlayPB_Click;
            // 
            // serverListCloseBtn
            // 
            serverListCloseBtn.BackColor = Color.FromArgb(64, 64, 64);
            serverListCloseBtn.FlatAppearance.BorderColor = Color.Gray;
            serverListCloseBtn.FlatStyle = FlatStyle.Flat;
            serverListCloseBtn.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            serverListCloseBtn.ForeColor = Color.FromArgb(255, 255, 128);
            serverListCloseBtn.Location = new Point(596, 265);
            serverListCloseBtn.Name = "serverListCloseBtn";
            serverListCloseBtn.Size = new Size(75, 30);
            serverListCloseBtn.TabIndex = 5;
            serverListCloseBtn.Text = "Close";
            serverListCloseBtn.UseVisualStyleBackColor = false;
            serverListCloseBtn.Click += serverListCloseBtn_Click;
            // 
            // ServersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(66, 66, 66);
            ClientSize = new Size(684, 300);
            Controls.Add(serverListCloseBtn);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(server1Panel);
            Controls.Add(serverHeaderPanel);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ServersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Servers";
            server1Panel.ResumeLayout(false);
            server1Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)server1PlayPB).EndInit();
            serverHeaderPanel.ResumeLayout(false);
            serverHeaderPanel.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)server2PlayPB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel server1Panel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private FlowLayoutPanel serverHeaderPanel;
        private Label serverNameLabel;
        private Label serverIpLabel;
        private Label serverModLabel;
        private Label regionLabel;
        private Label joinLabel;
        private Label label1;
        private PictureBox server1PlayPB;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private PictureBox server2PlayPB;
        private Button serverListCloseBtn;
    }
}