namespace DayzMap_Launcher
{
    partial class MainProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProfile));
            this.Nick = new System.Windows.Forms.TextBox();
            this.UID = new System.Windows.Forms.TextBox();
            this.ProfileAvatarBig = new System.Windows.Forms.PictureBox();
            this.ProfileMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.профильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьАватарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfileAvatarSmall = new System.Windows.Forms.PictureBox();
            this.BtnExit = new System.Windows.Forms.Panel();
            this.arma3 = new System.Windows.Forms.Panel();
            this.AppedNick = new System.Windows.Forms.PictureBox();
            this.LnShop = new System.Windows.Forms.Panel();
            this.LnNews = new System.Windows.Forms.Panel();
            this.LnHelp = new System.Windows.Forms.Panel();
            this.BtnShop = new System.Windows.Forms.Panel();
            this.BtnNews = new System.Windows.Forms.Panel();
            this.BtnHelp = new System.Windows.Forms.Panel();
            this.TexBoxCash = new System.Windows.Forms.TextBox();
            this.TexBoxBank = new System.Windows.Forms.TextBox();
            this.TexBoxFraction = new System.Windows.Forms.TextBox();
            this.TexBoxGroub = new System.Windows.Forms.TextBox();
            this.TexBoxVip = new System.Windows.Forms.TextBox();
            this.TexBoxVipDate = new System.Windows.Forms.TextBox();
            this.labelWanted = new System.Windows.Forms.Label();
            this.labelBounty = new System.Windows.Forms.Label();
            this.Bounty = new System.Windows.Forms.Label();
            this.BtnSettings = new System.Windows.Forms.Panel();
            this.BtnRez = new System.Windows.Forms.Panel();
            this.SettingMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.профильToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьНикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.установитьАвтарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileAvatarBig)).BeginInit();
            this.ProfileMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileAvatarSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppedNick)).BeginInit();
            this.SettingMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nick
            // 
            this.Nick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Nick.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nick.Font = new System.Drawing.Font("Gotham Pro Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nick.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Nick.Location = new System.Drawing.Point(482, 126);
            this.Nick.Name = "Nick";
            this.Nick.ReadOnly = true;
            this.Nick.Size = new System.Drawing.Size(177, 30);
            this.Nick.TabIndex = 14;
            this.Nick.Text = "danrom";
            this.Nick.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nick_KeyPress);
            // 
            // UID
            // 
            this.UID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.UID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UID.Font = new System.Drawing.Font("Gotham Pro Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UID.Location = new System.Drawing.Point(507, 160);
            this.UID.Name = "UID";
            this.UID.ReadOnly = true;
            this.UID.Size = new System.Drawing.Size(173, 14);
            this.UID.TabIndex = 13;
            this.UID.Text = "Информация отсутствует";
            // 
            // ProfileAvatarBig
            // 
            this.ProfileAvatarBig.BackColor = System.Drawing.Color.Transparent;
            this.ProfileAvatarBig.ContextMenuStrip = this.ProfileMenu;
            this.ProfileAvatarBig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfileAvatarBig.ImageLocation = "";
            this.ProfileAvatarBig.Location = new System.Drawing.Point(374, 126);
            this.ProfileAvatarBig.Name = "ProfileAvatarBig";
            this.ProfileAvatarBig.Size = new System.Drawing.Size(90, 90);
            this.ProfileAvatarBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfileAvatarBig.TabIndex = 12;
            this.ProfileAvatarBig.TabStop = false;
            // 
            // ProfileMenu
            // 
            this.ProfileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.профильToolStripMenuItem,
            this.загрузитьАватарToolStripMenuItem});
            this.ProfileMenu.Name = "ProfileMenu";
            this.ProfileMenu.Size = new System.Drawing.Size(227, 48);
            // 
            // профильToolStripMenuItem
            // 
            this.профильToolStripMenuItem.Font = new System.Drawing.Font("Gotham Pro Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.профильToolStripMenuItem.Name = "профильToolStripMenuItem";
            this.профильToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.профильToolStripMenuItem.Text = "Сменить ник";
            this.профильToolStripMenuItem.Click += new System.EventHandler(this.профильToolStripMenuItem_Click);
            // 
            // загрузитьАватарToolStripMenuItem
            // 
            this.загрузитьАватарToolStripMenuItem.Font = new System.Drawing.Font("Gotham Pro Light", 11.25F);
            this.загрузитьАватарToolStripMenuItem.Name = "загрузитьАватарToolStripMenuItem";
            this.загрузитьАватарToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.загрузитьАватарToolStripMenuItem.Text = "Загрузить аватарку";
            this.загрузитьАватарToolStripMenuItem.Click += new System.EventHandler(this.загрузитьАватарToolStripMenuItem_Click);
            // 
            // ProfileAvatarSmall
            // 
            this.ProfileAvatarSmall.BackColor = System.Drawing.Color.Transparent;
            this.ProfileAvatarSmall.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ProfileAvatarSmall.ImageLocation = "";
            this.ProfileAvatarSmall.Location = new System.Drawing.Point(850, 6);
            this.ProfileAvatarSmall.Name = "ProfileAvatarSmall";
            this.ProfileAvatarSmall.Size = new System.Drawing.Size(32, 32);
            this.ProfileAvatarSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfileAvatarSmall.TabIndex = 11;
            this.ProfileAvatarSmall.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.Location = new System.Drawing.Point(966, 13);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(17, 19);
            this.BtnExit.TabIndex = 16;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // arma3
            // 
            this.arma3.BackColor = System.Drawing.Color.Transparent;
            this.arma3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arma3.Location = new System.Drawing.Point(11, 80);
            this.arma3.Name = "arma3";
            this.arma3.Size = new System.Drawing.Size(41, 28);
            this.arma3.TabIndex = 15;
            this.arma3.Click += new System.EventHandler(this.arma3_Click);
            // 
            // AppedNick
            // 
            this.AppedNick.BackColor = System.Drawing.Color.Transparent;
            this.AppedNick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppedNick.Image = ((System.Drawing.Image)(resources.GetObject("AppedNick.Image")));
            this.AppedNick.Location = new System.Drawing.Point(665, 128);
            this.AppedNick.Name = "AppedNick";
            this.AppedNick.Size = new System.Drawing.Size(28, 28);
            this.AppedNick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AppedNick.TabIndex = 17;
            this.AppedNick.TabStop = false;
            this.AppedNick.Click += new System.EventHandler(this.AppedNick_Click);
            // 
            // LnShop
            // 
            this.LnShop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LnShop.Location = new System.Drawing.Point(147, 35);
            this.LnShop.Name = "LnShop";
            this.LnShop.Size = new System.Drawing.Size(66, 3);
            this.LnShop.TabIndex = 27;
            // 
            // LnNews
            // 
            this.LnNews.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LnNews.Location = new System.Drawing.Point(232, 35);
            this.LnNews.Name = "LnNews";
            this.LnNews.Size = new System.Drawing.Size(66, 3);
            this.LnNews.TabIndex = 26;
            // 
            // LnHelp
            // 
            this.LnHelp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LnHelp.Location = new System.Drawing.Point(310, 35);
            this.LnHelp.Name = "LnHelp";
            this.LnHelp.Size = new System.Drawing.Size(66, 3);
            this.LnHelp.TabIndex = 25;
            // 
            // BtnShop
            // 
            this.BtnShop.BackColor = System.Drawing.Color.Transparent;
            this.BtnShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShop.Location = new System.Drawing.Point(147, 13);
            this.BtnShop.Name = "BtnShop";
            this.BtnShop.Size = new System.Drawing.Size(66, 19);
            this.BtnShop.TabIndex = 24;
            this.BtnShop.Click += new System.EventHandler(this.BtnShop_Click);
            this.BtnShop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnShop_MouseMove);
            // 
            // BtnNews
            // 
            this.BtnNews.BackColor = System.Drawing.Color.Transparent;
            this.BtnNews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNews.Location = new System.Drawing.Point(232, 13);
            this.BtnNews.Name = "BtnNews";
            this.BtnNews.Size = new System.Drawing.Size(66, 19);
            this.BtnNews.TabIndex = 23;
            this.BtnNews.Click += new System.EventHandler(this.BtnNews_Click);
            this.BtnNews.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnNews_MouseMove);
            // 
            // BtnHelp
            // 
            this.BtnHelp.BackColor = System.Drawing.Color.Transparent;
            this.BtnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHelp.Location = new System.Drawing.Point(310, 13);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(66, 19);
            this.BtnHelp.TabIndex = 22;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            this.BtnHelp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnHelp_MouseMove);
            // 
            // TexBoxCash
            // 
            this.TexBoxCash.BackColor = System.Drawing.Color.Black;
            this.TexBoxCash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TexBoxCash.Font = new System.Drawing.Font("Gotham Pro Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBoxCash.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TexBoxCash.Location = new System.Drawing.Point(204, 336);
            this.TexBoxCash.Name = "TexBoxCash";
            this.TexBoxCash.ReadOnly = true;
            this.TexBoxCash.Size = new System.Drawing.Size(222, 14);
            this.TexBoxCash.TabIndex = 28;
            this.TexBoxCash.Text = "Информация отсутствует";
            // 
            // TexBoxBank
            // 
            this.TexBoxBank.BackColor = System.Drawing.Color.Black;
            this.TexBoxBank.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TexBoxBank.Font = new System.Drawing.Font("Gotham Pro Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBoxBank.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TexBoxBank.Location = new System.Drawing.Point(165, 359);
            this.TexBoxBank.Name = "TexBoxBank";
            this.TexBoxBank.ReadOnly = true;
            this.TexBoxBank.Size = new System.Drawing.Size(261, 14);
            this.TexBoxBank.TabIndex = 29;
            this.TexBoxBank.Text = "Информация отсутствует";
            // 
            // TexBoxFraction
            // 
            this.TexBoxFraction.BackColor = System.Drawing.Color.Black;
            this.TexBoxFraction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TexBoxFraction.Font = new System.Drawing.Font("Gotham Pro Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBoxFraction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TexBoxFraction.Location = new System.Drawing.Point(194, 381);
            this.TexBoxFraction.Name = "TexBoxFraction";
            this.TexBoxFraction.ReadOnly = true;
            this.TexBoxFraction.Size = new System.Drawing.Size(232, 14);
            this.TexBoxFraction.TabIndex = 30;
            this.TexBoxFraction.Text = "Информация отсутствует";
            // 
            // TexBoxGroub
            // 
            this.TexBoxGroub.BackColor = System.Drawing.Color.Black;
            this.TexBoxGroub.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TexBoxGroub.Font = new System.Drawing.Font("Gotham Pro Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBoxGroub.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TexBoxGroub.Location = new System.Drawing.Point(228, 405);
            this.TexBoxGroub.Name = "TexBoxGroub";
            this.TexBoxGroub.ReadOnly = true;
            this.TexBoxGroub.Size = new System.Drawing.Size(198, 14);
            this.TexBoxGroub.TabIndex = 31;
            this.TexBoxGroub.Text = "Информация отсутствует";
            // 
            // TexBoxVip
            // 
            this.TexBoxVip.BackColor = System.Drawing.Color.Black;
            this.TexBoxVip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TexBoxVip.Font = new System.Drawing.Font("Gotham Pro Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBoxVip.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TexBoxVip.Location = new System.Drawing.Point(151, 428);
            this.TexBoxVip.Name = "TexBoxVip";
            this.TexBoxVip.ReadOnly = true;
            this.TexBoxVip.Size = new System.Drawing.Size(158, 14);
            this.TexBoxVip.TabIndex = 32;
            this.TexBoxVip.Text = "Информация отсутствует";
            // 
            // TexBoxVipDate
            // 
            this.TexBoxVipDate.BackColor = System.Drawing.Color.Black;
            this.TexBoxVipDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TexBoxVipDate.Font = new System.Drawing.Font("Gotham Pro Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBoxVipDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TexBoxVipDate.Location = new System.Drawing.Point(194, 428);
            this.TexBoxVipDate.Name = "TexBoxVipDate";
            this.TexBoxVipDate.ReadOnly = true;
            this.TexBoxVipDate.Size = new System.Drawing.Size(232, 14);
            this.TexBoxVipDate.TabIndex = 33;
            this.TexBoxVipDate.Text = "Информация отсутствует";
            // 
            // labelWanted
            // 
            this.labelWanted.AutoSize = true;
            this.labelWanted.BackColor = System.Drawing.Color.Transparent;
            this.labelWanted.Font = new System.Drawing.Font("Gotham Pro Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWanted.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelWanted.Location = new System.Drawing.Point(505, 282);
            this.labelWanted.Name = "labelWanted";
            this.labelWanted.Size = new System.Drawing.Size(125, 23);
            this.labelWanted.TabIndex = 35;
            this.labelWanted.Text = "В розыске!";
            // 
            // labelBounty
            // 
            this.labelBounty.AutoSize = true;
            this.labelBounty.BackColor = System.Drawing.Color.Transparent;
            this.labelBounty.Font = new System.Drawing.Font("Gotham Pro Light", 8.999999F);
            this.labelBounty.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBounty.Location = new System.Drawing.Point(761, 298);
            this.labelBounty.Name = "labelBounty";
            this.labelBounty.Size = new System.Drawing.Size(111, 13);
            this.labelBounty.TabIndex = 36;
            this.labelBounty.Text = "Вознаграждение";
            // 
            // Bounty
            // 
            this.Bounty.AutoSize = true;
            this.Bounty.BackColor = System.Drawing.Color.Transparent;
            this.Bounty.Font = new System.Drawing.Font("Gotham Pro Light", 15.75F);
            this.Bounty.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Bounty.Location = new System.Drawing.Point(760, 274);
            this.Bounty.Name = "Bounty";
            this.Bounty.Size = new System.Drawing.Size(25, 23);
            this.Bounty.TabIndex = 37;
            this.Bounty.Text = "0";
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackColor = System.Drawing.Color.Transparent;
            this.BtnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSettings.Location = new System.Drawing.Point(897, 13);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(18, 19);
            this.BtnSettings.TabIndex = 38;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            this.BtnSettings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnSettings_MouseMove);
            // 
            // BtnRez
            // 
            this.BtnRez.BackColor = System.Drawing.Color.Transparent;
            this.BtnRez.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRez.Location = new System.Drawing.Point(931, 13);
            this.BtnRez.Name = "BtnRez";
            this.BtnRez.Size = new System.Drawing.Size(25, 19);
            this.BtnRez.TabIndex = 39;
            this.BtnRez.Click += new System.EventHandler(this.BtnRez_Click);
            // 
            // SettingMenu
            // 
            this.SettingMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.профильToolStripMenuItem1,
            this.сменитьНикToolStripMenuItem,
            this.установитьАвтарToolStripMenuItem,
            this.параметрыToolStripMenuItem});
            this.SettingMenu.Name = "test";
            this.SettingMenu.Size = new System.Drawing.Size(227, 92);
            this.SettingMenu.MouseLeave += new System.EventHandler(this.SettingMenu_MouseLeave);
            // 
            // профильToolStripMenuItem1
            // 
            this.профильToolStripMenuItem1.Font = new System.Drawing.Font("Gotham Pro Light", 11.25F);
            this.профильToolStripMenuItem1.Name = "профильToolStripMenuItem1";
            this.профильToolStripMenuItem1.Size = new System.Drawing.Size(226, 22);
            this.профильToolStripMenuItem1.Text = "Профиль";
            // 
            // сменитьНикToolStripMenuItem
            // 
            this.сменитьНикToolStripMenuItem.Font = new System.Drawing.Font("Gotham Pro Light", 11.25F);
            this.сменитьНикToolStripMenuItem.Name = "сменитьНикToolStripMenuItem";
            this.сменитьНикToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.сменитьНикToolStripMenuItem.Text = "Сменить ник";
            this.сменитьНикToolStripMenuItem.Click += new System.EventHandler(this.сменитьНикToolStripMenuItem_Click);
            // 
            // установитьАвтарToolStripMenuItem
            // 
            this.установитьАвтарToolStripMenuItem.Font = new System.Drawing.Font("Gotham Pro Light", 11.25F);
            this.установитьАвтарToolStripMenuItem.Name = "установитьАвтарToolStripMenuItem";
            this.установитьАвтарToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.установитьАвтарToolStripMenuItem.Text = "Загрузить аватарку";
            this.установитьАвтарToolStripMenuItem.Click += new System.EventHandler(this.установитьАвтарToolStripMenuItem_Click);
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.DoubleClickEnabled = true;
            this.параметрыToolStripMenuItem.Font = new System.Drawing.Font("Gotham Pro Light", 11.25F);
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.параметрыToolStripMenuItem.Text = "Параметры";
            this.параметрыToolStripMenuItem.Click += new System.EventHandler(this.параметрыToolStripMenuItem_Click);
            // 
            // MainProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DayzMap_Launcher.Properties.Resources.ProfileWantedBlue;
            this.ClientSize = new System.Drawing.Size(1001, 561);
            this.Controls.Add(this.BtnRez);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.Bounty);
            this.Controls.Add(this.labelBounty);
            this.Controls.Add(this.labelWanted);
            this.Controls.Add(this.TexBoxVipDate);
            this.Controls.Add(this.TexBoxVip);
            this.Controls.Add(this.TexBoxGroub);
            this.Controls.Add(this.TexBoxFraction);
            this.Controls.Add(this.TexBoxBank);
            this.Controls.Add(this.TexBoxCash);
            this.Controls.Add(this.LnShop);
            this.Controls.Add(this.LnNews);
            this.Controls.Add(this.LnHelp);
            this.Controls.Add(this.BtnShop);
            this.Controls.Add(this.BtnNews);
            this.Controls.Add(this.BtnHelp);
            this.Controls.Add(this.AppedNick);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.arma3);
            this.Controls.Add(this.Nick);
            this.Controls.Add(this.UID);
            this.Controls.Add(this.ProfileAvatarBig);
            this.Controls.Add(this.ProfileAvatarSmall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.MainProfile_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainProfile_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainProfile_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.ProfileAvatarBig)).EndInit();
            this.ProfileMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfileAvatarSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppedNick)).EndInit();
            this.SettingMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nick;
        private System.Windows.Forms.TextBox UID;
        private System.Windows.Forms.PictureBox ProfileAvatarBig;
        private System.Windows.Forms.PictureBox ProfileAvatarSmall;
        private System.Windows.Forms.Panel BtnExit;
        private System.Windows.Forms.Panel arma3;
        private System.Windows.Forms.ContextMenuStrip ProfileMenu;
        private System.Windows.Forms.ToolStripMenuItem профильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьАватарToolStripMenuItem;
        private System.Windows.Forms.PictureBox AppedNick;
        private System.Windows.Forms.Panel LnShop;
        private System.Windows.Forms.Panel LnNews;
        private System.Windows.Forms.Panel LnHelp;
        private System.Windows.Forms.Panel BtnShop;
        private System.Windows.Forms.Panel BtnNews;
        private System.Windows.Forms.Panel BtnHelp;
        private System.Windows.Forms.TextBox TexBoxCash;
        private System.Windows.Forms.TextBox TexBoxBank;
        private System.Windows.Forms.TextBox TexBoxFraction;
        private System.Windows.Forms.TextBox TexBoxGroub;
        private System.Windows.Forms.TextBox TexBoxVip;
        private System.Windows.Forms.TextBox TexBoxVipDate;
        private System.Windows.Forms.Label labelWanted;
        private System.Windows.Forms.Label labelBounty;
        private System.Windows.Forms.Label Bounty;
        private System.Windows.Forms.Panel BtnSettings;
        private System.Windows.Forms.Panel BtnRez;
        private System.Windows.Forms.ContextMenuStrip SettingMenu;
        private System.Windows.Forms.ToolStripMenuItem профильToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сменитьНикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem установитьАвтарToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
    }
}