﻿namespace Frågesport
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.exitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.statsPicture = new System.Windows.Forms.PictureBox();
            this.statsButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.highscorePicture = new System.Windows.Forms.PictureBox();
            this.highscoresButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.settingsPicture = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.playPicture = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panelOptions.SuspendLayout();
            this.buttonLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsPicture)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highscorePicture)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPicture)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 42);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(8, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 36);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frågesport";
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.ImageActive = null;
            this.minimizeButton.Location = new System.Drawing.Point(876, 6);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(28, 28);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Zoom = 10;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageActive = null;
            this.exitButton.Location = new System.Drawing.Point(910, 6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(28, 28);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 0;
            this.exitButton.TabStop = false;
            this.exitButton.Zoom = 10;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.menuButton);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(234, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(53, 561);
            this.panel2.TabIndex = 1;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.ImageActive = null;
            this.menuButton.Location = new System.Drawing.Point(8, 15);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(39, 33);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Zoom = 10;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panelOptions
            // 
            this.panelOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.panelOptions.Controls.Add(this.buttonLayoutPanel1);
            this.panelOptions.Controls.Add(this.pictureBox2);
            this.panelOptions.Controls.Add(this.flowLayoutPanel3);
            this.panelOptions.Controls.Add(this.flowLayoutPanel2);
            this.panelOptions.Controls.Add(this.flowLayoutPanel1);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOptions.Location = new System.Drawing.Point(0, 42);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(234, 561);
            this.panelOptions.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonLayoutPanel1
            // 
            this.buttonLayoutPanel1.Controls.Add(this.statsPicture);
            this.buttonLayoutPanel1.Controls.Add(this.statsButton);
            this.buttonLayoutPanel1.ForeColor = System.Drawing.Color.Silver;
            this.buttonLayoutPanel1.Location = new System.Drawing.Point(3, 163);
            this.buttonLayoutPanel1.Name = "buttonLayoutPanel1";
            this.buttonLayoutPanel1.Size = new System.Drawing.Size(231, 39);
            this.buttonLayoutPanel1.TabIndex = 3;
            this.buttonLayoutPanel1.MouseEnter += new System.EventHandler(this.buttonLayoutPanel1_MouseEnter);
            this.buttonLayoutPanel1.MouseLeave += new System.EventHandler(this.buttonLayoutPanel1_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(20, -9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 166);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // statsPicture
            // 
            this.statsPicture.BackColor = System.Drawing.Color.Transparent;
            this.statsPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.statsPicture.Image = ((System.Drawing.Image)(resources.GetObject("statsPicture.Image")));
            this.statsPicture.Location = new System.Drawing.Point(3, 3);
            this.statsPicture.Name = "statsPicture";
            this.statsPicture.Size = new System.Drawing.Size(39, 33);
            this.statsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statsPicture.TabIndex = 0;
            this.statsPicture.TabStop = false;
            // 
            // statsButton
            // 
            this.statsButton.BackColor = System.Drawing.Color.Transparent;
            this.statsButton.FlatAppearance.BorderSize = 0;
            this.statsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.statsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.statsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statsButton.Location = new System.Drawing.Point(48, 3);
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(168, 33);
            this.statsButton.TabIndex = 1;
            this.statsButton.Text = "STATS";
            this.statsButton.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.highscorePicture);
            this.flowLayoutPanel1.Controls.Add(this.highscoresButton);
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 208);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(231, 39);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // highscorePicture
            // 
            this.highscorePicture.BackColor = System.Drawing.Color.Transparent;
            this.highscorePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.highscorePicture.Image = ((System.Drawing.Image)(resources.GetObject("highscorePicture.Image")));
            this.highscorePicture.Location = new System.Drawing.Point(3, 3);
            this.highscorePicture.Name = "highscorePicture";
            this.highscorePicture.Size = new System.Drawing.Size(39, 33);
            this.highscorePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.highscorePicture.TabIndex = 0;
            this.highscorePicture.TabStop = false;
            // 
            // highscoresButton
            // 
            this.highscoresButton.BackColor = System.Drawing.Color.Transparent;
            this.highscoresButton.FlatAppearance.BorderSize = 0;
            this.highscoresButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.highscoresButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.highscoresButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.highscoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highscoresButton.Location = new System.Drawing.Point(48, 3);
            this.highscoresButton.Name = "highscoresButton";
            this.highscoresButton.Size = new System.Drawing.Size(168, 33);
            this.highscoresButton.TabIndex = 1;
            this.highscoresButton.Text = "HIGHSCORES";
            this.highscoresButton.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.settingsPicture);
            this.flowLayoutPanel2.Controls.Add(this.settingsButton);
            this.flowLayoutPanel2.ForeColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 253);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(231, 39);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // settingsPicture
            // 
            this.settingsPicture.BackColor = System.Drawing.Color.Transparent;
            this.settingsPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsPicture.Image = ((System.Drawing.Image)(resources.GetObject("settingsPicture.Image")));
            this.settingsPicture.Location = new System.Drawing.Point(3, 3);
            this.settingsPicture.Name = "settingsPicture";
            this.settingsPicture.Size = new System.Drawing.Size(39, 33);
            this.settingsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingsPicture.TabIndex = 0;
            this.settingsPicture.TabStop = false;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.settingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.settingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Location = new System.Drawing.Point(48, 3);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(168, 33);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.Text = "SETTINGS";
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.playPicture);
            this.flowLayoutPanel3.Controls.Add(this.playButton);
            this.flowLayoutPanel3.ForeColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 510);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(231, 39);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // playPicture
            // 
            this.playPicture.BackColor = System.Drawing.Color.Transparent;
            this.playPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playPicture.Image = ((System.Drawing.Image)(resources.GetObject("playPicture.Image")));
            this.playPicture.Location = new System.Drawing.Point(3, 3);
            this.playPicture.Name = "playPicture";
            this.playPicture.Size = new System.Drawing.Size(39, 33);
            this.playPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playPicture.TabIndex = 0;
            this.playPicture.TabStop = false;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Location = new System.Drawing.Point(48, 3);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(168, 33);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(8, 166);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(8, 211);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(8, 256);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(8, 513);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(39, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(941, 603);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelOptions);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Frågesport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panelOptions.ResumeLayout(false);
            this.buttonLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsPicture)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.highscorePicture)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPicture)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelOptions;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
        private Bunifu.Framework.UI.BunifuImageButton exitButton;
        private Bunifu.Framework.UI.BunifuImageButton menuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel buttonLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox statsPicture;
        private System.Windows.Forms.Button statsButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.PictureBox playPicture;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox settingsPicture;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox highscorePicture;
        private System.Windows.Forms.Button highscoresButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

