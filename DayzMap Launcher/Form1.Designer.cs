namespace DayzMap_Launcher
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Collapse = new System.Windows.Forms.NotifyIcon(this.components);
            this.CollapseMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DnInfo = new System.Windows.Forms.Label();
            this.AddonsDownload = new System.Windows.Forms.Timer(this.components);
            this.deliteZIP = new System.Windows.Forms.Timer(this.components);
            this.ProfileMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.профильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьАватарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThreeNews = new System.Windows.Forms.PictureBox();
            this.TwoNews = new System.Windows.Forms.PictureBox();
            this.OneNews = new System.Windows.Forms.PictureBox();
            this.ProfileAvatar = new System.Windows.Forms.PictureBox();
            this.BtnHelp = new System.Windows.Forms.Panel();
            this.UpdateNews = new System.Windows.Forms.Timer(this.components);
            this.BtnNews = new System.Windows.Forms.Panel();
            this.BtnShop = new System.Windows.Forms.Panel();
            this.SearchUpdates = new System.Windows.Forms.Timer(this.components);
            this.LnHelp = new System.Windows.Forms.Panel();
            this.LnNews = new System.Windows.Forms.Panel();
            this.LnShop = new System.Windows.Forms.Panel();
            this.SettingMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьНикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.установитьАвтарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnStart = new BtnNEw.DayzMapButtonVersion2();
            this.fsProgressBar1 = new DayzMap_Launcher.FsProgressBar();
            this.профильToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CollapseMenu.SuspendLayout();
            this.ProfileMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThreeNews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwoNews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OneNews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileAvatar)).BeginInit();
            this.SettingMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(897, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(18, 19);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(931, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 19);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(966, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(17, 19);
            this.panel3.TabIndex = 2;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // Collapse
            // 
            this.Collapse.ContextMenuStrip = this.CollapseMenu;
            this.Collapse.Icon = ((System.Drawing.Icon)(resources.GetObject("Collapse.Icon")));
            this.Collapse.Text = "notifyIcon1";
            this.Collapse.Visible = true;
            this.Collapse.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Collapse_MouseDoubleClick);
            // 
            // CollapseMenu
            // 
            this.CollapseMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.CollapseMenu.Name = "CollapseMenu";
            this.CollapseMenu.Size = new System.Drawing.Size(122, 48);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // DnInfo
            // 
            this.DnInfo.AutoSize = true;
            this.DnInfo.BackColor = System.Drawing.Color.Transparent;
            this.DnInfo.Font = new System.Drawing.Font("Gotham Pro Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DnInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DnInfo.Location = new System.Drawing.Point(217, 480);
            this.DnInfo.Name = "DnInfo";
            this.DnInfo.Size = new System.Drawing.Size(16, 14);
            this.DnInfo.TabIndex = 5;
            this.DnInfo.Text = "0";
            this.DnInfo.Visible = false;
            // 
            // AddonsDownload
            // 
            this.AddonsDownload.Interval = 2000;
            this.AddonsDownload.Tick += new System.EventHandler(this.AddonsDownload_Tick);
            // 
            // deliteZIP
            // 
            this.deliteZIP.Interval = 1000;
            this.deliteZIP.Tick += new System.EventHandler(this.deliteZIP_Tick);
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
            this.профильToolStripMenuItem.Text = "Профиль";
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
            // ThreeNews
            // 
            this.ThreeNews.BackColor = System.Drawing.Color.Transparent;
            this.ThreeNews.ImageLocation = "https://game-programmer.ru/BlockNews/ThreeNewsBlock.png";
            this.ThreeNews.Location = new System.Drawing.Point(752, 181);
            this.ThreeNews.Name = "ThreeNews";
            this.ThreeNews.Size = new System.Drawing.Size(239, 217);
            this.ThreeNews.TabIndex = 9;
            this.ThreeNews.TabStop = false;
            this.ThreeNews.Click += new System.EventHandler(this.ThreeNews_Click);
            // 
            // TwoNews
            // 
            this.TwoNews.BackColor = System.Drawing.Color.Transparent;
            this.TwoNews.ImageLocation = "https://game-programmer.ru/BlockNews/TwoNewsBlock.png";
            this.TwoNews.Location = new System.Drawing.Point(498, 181);
            this.TwoNews.Name = "TwoNews";
            this.TwoNews.Size = new System.Drawing.Size(239, 217);
            this.TwoNews.TabIndex = 8;
            this.TwoNews.TabStop = false;
            this.TwoNews.Click += new System.EventHandler(this.TwoNews_Click);
            // 
            // OneNews
            // 
            this.OneNews.BackColor = System.Drawing.Color.Transparent;
            this.OneNews.ImageLocation = "https://game-programmer.ru/BlockNews/OneNewsBlock.png";
            this.OneNews.Location = new System.Drawing.Point(103, 181);
            this.OneNews.Name = "OneNews";
            this.OneNews.Size = new System.Drawing.Size(382, 217);
            this.OneNews.TabIndex = 7;
            this.OneNews.TabStop = false;
            this.OneNews.Click += new System.EventHandler(this.OneNews_Click);
            // 
            // ProfileAvatar
            // 
            this.ProfileAvatar.BackColor = System.Drawing.Color.Transparent;
            this.ProfileAvatar.ContextMenuStrip = this.ProfileMenu;
            this.ProfileAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfileAvatar.ImageLocation = "";
            this.ProfileAvatar.Location = new System.Drawing.Point(850, 6);
            this.ProfileAvatar.Name = "ProfileAvatar";
            this.ProfileAvatar.Size = new System.Drawing.Size(32, 32);
            this.ProfileAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfileAvatar.TabIndex = 6;
            this.ProfileAvatar.TabStop = false;
            this.ProfileAvatar.Click += new System.EventHandler(this.ProfileAvatar_Click);
            // 
            // BtnHelp
            // 
            this.BtnHelp.BackColor = System.Drawing.Color.Transparent;
            this.BtnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHelp.Location = new System.Drawing.Point(310, 13);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(66, 19);
            this.BtnHelp.TabIndex = 10;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            this.BtnHelp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnHelp_MouseMove);
            // 
            // UpdateNews
            // 
            this.UpdateNews.Enabled = true;
            this.UpdateNews.Interval = 30000;
            this.UpdateNews.Tick += new System.EventHandler(this.UpdateNews_Tick);
            // 
            // BtnNews
            // 
            this.BtnNews.BackColor = System.Drawing.Color.Transparent;
            this.BtnNews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNews.Location = new System.Drawing.Point(232, 13);
            this.BtnNews.Name = "BtnNews";
            this.BtnNews.Size = new System.Drawing.Size(66, 19);
            this.BtnNews.TabIndex = 11;
            this.BtnNews.Click += new System.EventHandler(this.BtnNews_Click);
            this.BtnNews.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnNews_MouseMove);
            // 
            // BtnShop
            // 
            this.BtnShop.BackColor = System.Drawing.Color.Transparent;
            this.BtnShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShop.Location = new System.Drawing.Point(147, 13);
            this.BtnShop.Name = "BtnShop";
            this.BtnShop.Size = new System.Drawing.Size(66, 19);
            this.BtnShop.TabIndex = 12;
            this.BtnShop.Click += new System.EventHandler(this.BtnShop_Click);
            this.BtnShop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnShop_MouseMove);
            // 
            // SearchUpdates
            // 
            this.SearchUpdates.Interval = 10000;
            this.SearchUpdates.Tick += new System.EventHandler(this.SearchUpdates_Tick);
            // 
            // LnHelp
            // 
            this.LnHelp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LnHelp.Location = new System.Drawing.Point(310, 35);
            this.LnHelp.Name = "LnHelp";
            this.LnHelp.Size = new System.Drawing.Size(66, 3);
            this.LnHelp.TabIndex = 13;
            // 
            // LnNews
            // 
            this.LnNews.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LnNews.Location = new System.Drawing.Point(232, 35);
            this.LnNews.Name = "LnNews";
            this.LnNews.Size = new System.Drawing.Size(66, 3);
            this.LnNews.TabIndex = 14;
            // 
            // LnShop
            // 
            this.LnShop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LnShop.Location = new System.Drawing.Point(147, 35);
            this.LnShop.Name = "LnShop";
            this.LnShop.Size = new System.Drawing.Size(66, 3);
            this.LnShop.TabIndex = 15;
            // 
            // SettingMenu
            // 
            this.SettingMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.профильToolStripMenuItem1,
            this.сменитьНикToolStripMenuItem,
            this.установитьАвтарToolStripMenuItem,
            this.параметрыToolStripMenuItem});
            this.SettingMenu.Name = "test";
            this.SettingMenu.Size = new System.Drawing.Size(227, 114);
            this.SettingMenu.MouseLeave += new System.EventHandler(this.SettingMenu_MouseLeave);
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
            // BtnStart
            // 
            this.BtnStart.AnimationInterval = 1;
            this.BtnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(211)))));
            this.BtnStart.BackgroundSpeed = 40;
            this.BtnStart.BackHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(241)))));
            this.BtnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStart.CustomButtonText = "Установить";
            this.BtnStart.FlatAppearance.BorderSize = 0;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.Font = new System.Drawing.Font("Gotham Pro Light", 15.75F);
            this.BtnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnStart.Location = new System.Drawing.Point(44, 488);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(164, 51);
            this.BtnStart.SmoothCorrectionFactor = 1.5D;
            this.BtnStart.TabIndex = 16;
            this.BtnStart.TextHoverColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnStart.UseSmoothSpeedIncrement = true;
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // fsProgressBar1
            // 
            this.fsProgressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.fsProgressBar1.BorderColor = System.Drawing.Color.Black;
            this.fsProgressBar1.BorderWidth = 0;
            this.fsProgressBar1.ForeColor = System.Drawing.Color.Black;
            this.fsProgressBar1.Location = new System.Drawing.Point(214, 497);
            this.fsProgressBar1.MaxValue = 100;
            this.fsProgressBar1.MinValue = 0;
            this.fsProgressBar1.Name = "fsProgressBar1";
            this.fsProgressBar1.ProgressColor = System.Drawing.SystemColors.Highlight;
            this.fsProgressBar1.ProgressTextType = DayzMap_Launcher.FsProgressBar.FsProgressTextType.AsIs;
            this.fsProgressBar1.ShowProgressText = true;
            this.fsProgressBar1.Size = new System.Drawing.Size(777, 32);
            this.fsProgressBar1.TabIndex = 4;
            this.fsProgressBar1.Text = "fsProgressBar1";
            this.fsProgressBar1.Value = 0;
            this.fsProgressBar1.Visible = false;
            // 
            // профильToolStripMenuItem1
            // 
            this.профильToolStripMenuItem1.Font = new System.Drawing.Font("Gotham Pro Light", 11.25F);
            this.профильToolStripMenuItem1.Name = "профильToolStripMenuItem1";
            this.профильToolStripMenuItem1.Size = new System.Drawing.Size(226, 22);
            this.профильToolStripMenuItem1.Text = "Профиль";
            this.профильToolStripMenuItem1.Click += new System.EventHandler(this.профильToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DayzMap_Launcher.Properties.Resources.dayzmap2;
            this.ClientSize = new System.Drawing.Size(1001, 561);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LnShop);
            this.Controls.Add(this.LnNews);
            this.Controls.Add(this.LnHelp);
            this.Controls.Add(this.BtnShop);
            this.Controls.Add(this.BtnNews);
            this.Controls.Add(this.BtnHelp);
            this.Controls.Add(this.ThreeNews);
            this.Controls.Add(this.TwoNews);
            this.Controls.Add(this.OneNews);
            this.Controls.Add(this.ProfileAvatar);
            this.Controls.Add(this.DnInfo);
            this.Controls.Add(this.fsProgressBar1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DayzMap Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.CollapseMenu.ResumeLayout(false);
            this.ProfileMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ThreeNews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwoNews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OneNews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileAvatar)).EndInit();
            this.SettingMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NotifyIcon Collapse;
        private System.Windows.Forms.ContextMenuStrip CollapseMenu;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        public FsProgressBar fsProgressBar1;
        public System.Windows.Forms.Label DnInfo;
        private System.Windows.Forms.Timer AddonsDownload;
        private System.Windows.Forms.Timer deliteZIP;
        private System.Windows.Forms.PictureBox ProfileAvatar;
        private System.Windows.Forms.ContextMenuStrip ProfileMenu;
        private System.Windows.Forms.ToolStripMenuItem профильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьАватарToolStripMenuItem;
        private System.Windows.Forms.PictureBox OneNews;
        private System.Windows.Forms.PictureBox TwoNews;
        private System.Windows.Forms.PictureBox ThreeNews;
        private System.Windows.Forms.Panel BtnHelp;
        private System.Windows.Forms.Timer UpdateNews;
        private System.Windows.Forms.Panel BtnNews;
        private System.Windows.Forms.Panel BtnShop;
        private System.Windows.Forms.Timer SearchUpdates;
        private System.Windows.Forms.Panel LnHelp;
        private System.Windows.Forms.Panel LnNews;
        private System.Windows.Forms.Panel LnShop;
        private BtnNEw.DayzMapButtonVersion2 BtnStart;
        private System.Windows.Forms.ContextMenuStrip SettingMenu;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьНикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem установитьАвтарToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem профильToolStripMenuItem1;
    }
}

