using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace DayzMap_Launcher
{

    public partial class MainProfile : Form
    {

        public string Avatarimage;
        string[] Gangs = { "Altis Police Department", "Altis Medical Department", "СУД", "СЕНАТ", "Altis Police Department 2", "SDT", "TAXI", "GOLD Empire", "Deadlly Squad", "Miner", "FOX", "FENIX", "DHL", "Berkut", "Bichara", "X5MonolitGrandLogistick", "NagareBoshi" };
        public int Theme;
        private int x_MainProfile = 0; private int y_MainProfile = 0;
        string PlayerID;
        DB db = new DB();
        public String sMacAddress = string.Empty;

        const string SharedSecret = "He continually hurt Princess Mary's feelings and tormented her, but it cost her no effort to forgive him. Could he be to blame toward her, or could her father, whom she knew loved her in spite of it all, be unjust? And what is justice? The princess never thought of that proud word 'justice.' )3dV8g*EiK(%sc92xU0*99(Dt22j%IW#Wodfiz&(%72s3j4#";
        public int LauncherTheme
        {
            get { return Theme; }
            set { Theme = value; }
        }
        public string NickName
        {
            get { return Nick.Text; }
            set { Nick.Text = value; }
        }
        public MainProfile()
        {
            InitializeComponent();
            AppedNick.Visible = false;
            LnHelp.Visible = false;
            LnNews.Visible = false;
            LnShop.Visible = false;
            TexBoxVipDate.Visible = false;
            Bounty.Visible = false;
            labelWanted.Visible = false;
            labelBounty.Visible = false;

            SettingMenu.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void MainProfile_Load(object sender, EventArgs e)
        {
            this.Focus();

            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }

            if (System.IO.File.Exists(@"Profile/avatarka.png"))
            {
                Avatarimage = @"Profile/avatarka.png";
            }

            if (Avatarimage != null)
            {
                ProfileAvatarSmall.Image = new Bitmap(Avatarimage);
                ProfileAvatarBig.Image = new Bitmap(Avatarimage);
            }

            if (Theme == 0)
            {
                this.BackgroundImage = DayzMap_Launcher.Properties.Resources.ProfileBlue;
                Nick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
                UID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
                Nick.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                UID.ForeColor = System.Drawing.SystemColors.ControlLightLight;

                TexBoxCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                TexBoxBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                TexBoxFraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                TexBoxGroub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                TexBoxVip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                TexBoxVipDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));

                TexBoxCash.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                TexBoxBank.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                TexBoxFraction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                TexBoxGroub.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                TexBoxVip.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                TexBoxVipDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;

            }
            if (Theme == 1)
            {
                this.BackgroundImage = DayzMap_Launcher.Properties.Resources.ProfileDark;
                Nick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
                UID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
                Nick.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                UID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

                TexBoxCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                TexBoxBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                TexBoxFraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                TexBoxGroub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                TexBoxVip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                TexBoxVipDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));

                TexBoxCash.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                TexBoxBank.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                TexBoxFraction.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                TexBoxGroub.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                TexBoxVip.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                TexBoxVipDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            }

            ChekBD();

        }

        private void arma3_Click(object sender, EventArgs e)
        {
            Form form1 = Application.OpenForms[0];
            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = Location;
            this.Hide();
            form1.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainProfile_MouseDown(object sender, MouseEventArgs e)
        {
            x_MainProfile = e.X; y_MainProfile = e.Y;
        }

        private void MainProfile_MouseMove(object sender, MouseEventArgs e)
        {
            LnHelp.Visible = false;
            LnNews.Visible = false;
            LnShop.Visible = false;

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - x_MainProfile), this.Location.Y + (e.Y - y_MainProfile));
            }
        }

        private void профильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nick.Focus();
            Nick.ReadOnly = false;
            AppedNick.Visible = true;
        }

        private void Nick_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void AppedNick_Click(object sender, EventArgs e)
        {
            if (Nick.Text != "")
            {
                string NickEnter = Nick.Text;


                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `players` WHERE `name` = @uL", db.getConnection());
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = NickEnter;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {

                    ChekDID(NickEnter);

                }
                else
                {
                    var encryptedStringAES = Crypto.EncryptStringAES(NickEnter, SharedSecret);
                    using (StreamWriter stream = new StreamWriter(@"NickName.Arma3Profile"))
                    {
                        stream.WriteLine(encryptedStringAES);
                        stream.Close();
                    }
                    Nick.ReadOnly = true;
                    AppedNick.Visible = false;
                    MessageBox.Show("Ник успешно установлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChekBD();
                }


            }


        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            HelpForm helpform = new HelpForm();
            helpform.GetTheme = this.LauncherTheme;
            helpform.StartPosition = FormStartPosition.Manual;
            helpform.Location = Location;

            if (LauncherTheme == 0)
            {
                helpform.BackgroundImage = DayzMap_Launcher.Properties.Resources.dayzmapHelpB;

                helpform.BtnBack.BackColor = System.Drawing.Color.Black;
                helpform.BtnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                helpform.BtnBack.BackHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(241)))));
                helpform.BtnBack.TextHoverColor = System.Drawing.SystemColors.ControlLightLight;
                // helpform.BtnBack.BackColor2 = System.Drawing.Color.Black;
                //helpform.BtnBack.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(211)))));
                //helpform.BtnBack.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(241)))));
                //helpform.BtnBack.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(241)))));
                //helpform.BtnBack.ButtonHighlightForeColor = System.Drawing.SystemColors.ControlLightLight;
                //helpform.BtnBack.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(157)))));
                //helpform.BtnBack.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(157)))));
                //helpform.BtnBack.ButtonPressedForeColor = System.Drawing.Color.White;
            }
            if (LauncherTheme == 1)
            {
                helpform.BackgroundImage = DayzMap_Launcher.Properties.Resources.dayzmapHelpW;

                helpform.BtnBack.BackColor = System.Drawing.Color.Black;
                helpform.BtnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                helpform.BtnBack.BackHoverColor = System.Drawing.SystemColors.ControlLightLight;
                helpform.BtnBack.TextHoverColor = System.Drawing.Color.Black;
                //helpform.BtnBack.BackColor2 = System.Drawing.Color.Black;
                //helpform.BtnBack.ButtonBorderColor = System.Drawing.Color.White;
                //helpform.BtnBack.ButtonHighlightColor = System.Drawing.SystemColors.Desktop;
                //helpform.BtnBack.ButtonHighlightColor2 = System.Drawing.SystemColors.Desktop;
                //helpform.BtnBack.ButtonHighlightForeColor = System.Drawing.SystemColors.ControlLightLight;
                //helpform.BtnBack.ButtonPressedColor = System.Drawing.SystemColors.Highlight;
                //helpform.BtnBack.ButtonPressedColor2 = System.Drawing.SystemColors.HotTrack;
                //helpform.BtnBack.ButtonPressedForeColor = System.Drawing.Color.White;
            }
            this.Close();
            helpform.Show();
        }

        private void BtnNews_Click(object sender, EventArgs e)
        {
            Process.Start("https://dayzmap.ru/forums/novosti-servera-arma3-altis-lajf-elysium.28/");
        }

        private void BtnShop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Временно не доступно!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnHelp_MouseMove(object sender, MouseEventArgs e)
        {
            LnHelp.Visible = true;
        }

        private void BtnNews_MouseMove(object sender, MouseEventArgs e)
        {
            LnNews.Visible = true;
        }

        private void BtnShop_MouseMove(object sender, MouseEventArgs e)
        {
            LnShop.Visible = true;
        }

        private void загрузитьАватарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog avatar = new OpenFileDialog();
            avatar.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

            if (avatar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ProfileAvatarBig.Image = new Bitmap(avatar.FileName);
                    ProfileAvatarSmall.Image = new Bitmap(avatar.FileName);
                    File.Copy(avatar.FileName, @"Profile/avatarka.png", true);

                    using (StreamWriter ProfileConfig = new StreamWriter(@"Profile/ConfigProfile.DayzMap"))
                    {
                        ProfileConfig.WriteLine("1");
                        ProfileConfig.Close();
                    }
                    MessageBox.Show("Настройки применены! Лаунчер будет перезагружен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void ChekBD()
        {
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `players` WHERE `name` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Nick.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                GetUID(Nick.Text);
                GetCash(PlayerID);
                GetBank(PlayerID);
                GetFraction(PlayerID);
                GetVip(PlayerID);
                ThereIsWanted(PlayerID);
                try
                {
                    GetGroupings(PlayerID);
                }
                catch { }
                
            }
            else
            {
                TexBoxBank.Text = "Информация отсутствует";
                TexBoxCash.Text = "Информация отсутствует";
                TexBoxFraction.Text = "Информация отсутствует";
                TexBoxGroub.Text = "Информация отсутствует";
                TexBoxVip.Text = "Информация отсутствует";
                TexBoxVipDate.Text = "";
                UID.Text = "Информация отсутствует";

                if (Theme == 0)
                {
                    this.BackgroundImage = DayzMap_Launcher.Properties.Resources.ProfileBlue;
                    labelBounty.Visible = false;
                    labelWanted.Visible = false;
                    Bounty.Visible = false;
                }
                if (Theme == 1)
                {
                    this.BackgroundImage = DayzMap_Launcher.Properties.Resources.ProfileDark;
                    labelBounty.Visible = false;
                    labelWanted.Visible = false;
                    Bounty.Visible = false;
                }
            }
        }
        void GetUID(string Nick)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `players` WHERE `name` = @ul", db.getConnection());
            command.Parameters.AddWithValue("@ul", Nick);
            db.OpenConnection();

            string Uid = null;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read()) // reader.Read() возвращает true и переходит к следующему ряду.
                {
                    Uid = reader.GetString("playerid");
                }
            }

            db.CloseConnection();
            PlayerID = Uid;
            UID.Text = Uid;
        }
        void GetCash(string UID)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `players` WHERE `playerid` = @ul", db.getConnection());
            command.Parameters.AddWithValue("@ul", UID);
            db.OpenConnection();

            string Cash = null;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read()) // reader.Read() возвращает true и переходит к следующему ряду.
                {
                    Cash = reader.GetString("cash");
                }
            }

            db.CloseConnection();
            TexBoxCash.Text = Cash;
        }
        void GetBank(string UID)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `players` WHERE `playerid` = @ul", db.getConnection());
            command.Parameters.AddWithValue("@ul", UID);
            db.OpenConnection();

            string Bank = null;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read()) // reader.Read() возвращает true и переходит к следующему ряду.
                {
                    Bank = reader.GetString("bankacc");
                }
            }

            db.CloseConnection();
            TexBoxBank.Text = Bank;
        }

        void GetFraction(string UID)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `players` WHERE `playerid` = @ul", db.getConnection());
            command.Parameters.AddWithValue("@ul", UID);
            db.OpenConnection();

            string MedicLvL = null;
            string CopLvL = null;
            string CivLvL = null;
            string RebLVL = null;
            string AdminLVL = null;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read()) // reader.Read() возвращает true и переходит к следующему ряду.
                {
                    MedicLvL = reader.GetString("mediclevel");
                    CopLvL = reader.GetString("coplevel");
                    CivLvL = reader.GetString("civlevel");
                    RebLVL = reader.GetString("reblevel");
                    AdminLVL = reader.GetString("adminlevel");
                }
            }

            db.CloseConnection();

            if (Convert.ToInt32(MedicLvL) > 0)
            {
                TexBoxFraction.Text = "МЧС  " + MedicLvL + " LVL";
            }
            if (Convert.ToInt32(CopLvL) > 0)
            {
                TexBoxFraction.Text = "Полицеский  " + CopLvL + " LVL";
            }
            if (Convert.ToInt32(CivLvL) > 0)
            {
                TexBoxFraction.Text = "Гражданский  " + CivLvL + " LVL";
            }
            if (Convert.ToInt32(RebLVL) > 0)
            {
                TexBoxFraction.Text = "Повстанец  " + RebLVL + " LVL";
            }
            if (Convert.ToInt32(AdminLVL) > 0)
            {
                TexBoxFraction.Text = "Админ  " + AdminLVL + " LVL";
            }
        }

        void GetVip(string UID)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `players` WHERE `playerid` = @ul", db.getConnection());
            command.Parameters.AddWithValue("@ul", UID);
            db.OpenConnection();

            string Donat = null;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read()) // reader.Read() возвращает true и переходит к следующему ряду.
                {
                    Donat = reader.GetString("donorlevel");
                }
            }

            db.CloseConnection();
            if (Convert.ToInt32(Donat) > 0)
            {
                TexBoxVip.Text = Donat + " LVL";
                TexBoxVipDate.Visible = true;
                GetVipDate(UID);
            }
            else
            {
                TexBoxVip.Text = "Отсутствует";
            }

        }
        void GetVipDate(string UID)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `players` WHERE `playerid` = @ul", db.getConnection());
            command.Parameters.AddWithValue("@ul", UID);
            db.OpenConnection();

            string Date = null;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read()) // reader.Read() возвращает true и переходит к следующему ряду.
                {
                    Date = reader.GetString("donat_time");
                }
            }
            TexBoxVipDate.Text = "До " + Date;
            db.CloseConnection();
        }
        void ThereIsWanted(string UID)
        {
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `wanted` WHERE `wantedID` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = UID;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                GetWanted(UID);
            }
        }
        void GetWanted(string UID)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `wanted` WHERE `wantedID` = @ul", db.getConnection());
            command.Parameters.AddWithValue("@ul", UID);
            db.OpenConnection();

            string Active = null;
            string WantedBounty = null;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read()) // reader.Read() возвращает true и переходит к следующему ряду.
                {
                    Active = reader.GetString("active");
                    WantedBounty = reader.GetString("wantedBounty");
                }
            }
            db.CloseConnection();

            if (Convert.ToBoolean(Active) == true)
            {
                if (Theme == 0)
                {
                    this.BackgroundImage = DayzMap_Launcher.Properties.Resources.ProfileWantedBlue;
                    labelBounty.Visible = true;
                    labelWanted.Visible = true;
                    Bounty.Visible = true;
                    Bounty.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                    labelBounty.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                    labelWanted.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                    Bounty.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                    Bounty.Text = WantedBounty;
                }
                if (Theme == 1)
                {
                    this.BackgroundImage = DayzMap_Launcher.Properties.Resources.ProfileWantedDark;
                    labelBounty.Visible = true;
                    labelWanted.Visible = true;
                    Bounty.Visible = true;
                    Bounty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                    labelBounty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                    labelWanted.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                    Bounty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                    Bounty.Text = WantedBounty;
                }
            }
            else
            {
                if (Theme == 0)
                {
                    this.BackgroundImage = DayzMap_Launcher.Properties.Resources.ProfileBlue;
                    labelBounty.Visible = false;
                    labelWanted.Visible = false;
                    Bounty.Visible = false;
                }
                if (Theme == 1)
                {
                    this.BackgroundImage = DayzMap_Launcher.Properties.Resources.ProfileDark;
                    labelBounty.Visible = false;
                    labelWanted.Visible = false;
                    Bounty.Visible = false;
                }
            }
        }
        void GetGroupings(string UID)
        {
            for (int i = 0; i < Gangs.Length; i++)
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `gangs` WHERE `name` = @ul", db.getConnection());
                command.Parameters.AddWithValue("@ul", Gangs[i]);
                db.OpenConnection();

                string Members = null;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read()) // reader.Read() возвращает true и переходит к следующему ряду.
                    {
                        Members = reader.GetString("members");
                    }
                }
                db.CloseConnection();
                if (Members.Contains(UID))
                {
                    TexBoxGroub.Text = Gangs[i];
                    return;
                }
                else
                {
                    TexBoxGroub.Text = "Информация отсутствует";
                }
            }
        }




        void ChekDID(string NickName)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `players` WHERE `name` = @ul", db.getConnection());
            command.Parameters.AddWithValue("@ul", NickName);
            db.OpenConnection();

            string DID = null;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read()) // reader.Read() возвращает true и переходит к следующему ряду.
                {
                    DID = reader.GetString("Did");
                }
            }
            db.CloseConnection();
            if (DID != "0")
            {
                if (DID == sMacAddress)
                {
                    var encryptedStringAES = Crypto.EncryptStringAES(NickName, SharedSecret);
                    using (StreamWriter stream = new StreamWriter(@"NickName.Arma3Profile"))
                    {
                        stream.WriteLine(encryptedStringAES);
                        stream.Close();
                    }
                    Nick.ReadOnly = true;
                    AppedNick.Visible = false;
                    ChekBD();
                    MessageBox.Show("Ник успешно установлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Никнейм " + NickName + " занят", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                AddDid(NickName, sMacAddress);
            }
        }
        void AddDid(string NickName, string DID)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `players` SET `Did` = @did WHERE `players`.`name` = @Name;", db.getConnection());

            command.Parameters.Add("@did", MySqlDbType.VarChar).Value = DID;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NickName;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                Console.WriteLine("Отправлено!");

                var encryptedStringAES = Crypto.EncryptStringAES(NickName, SharedSecret);
                using (StreamWriter stream = new StreamWriter(@"NickName.Arma3Profile"))
                {
                    stream.WriteLine(encryptedStringAES);
                    stream.Close();
                }
                Nick.ReadOnly = true;
                AppedNick.Visible = false;
                ChekBD();
                MessageBox.Show("Ник успешно установлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Console.WriteLine("Ошибка!");
            }

            db.CloseConnection();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            //Form3 form3 = new Form3();
            //form3.Show();
        }

        private void BtnRez_Click(object sender, EventArgs e)
        {
            Form form1 = Application.OpenForms[0];
            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = Location;
            form1.Show();
            form1.WindowState = FormWindowState.Minimized;
            this.Close();
        }

        private void SettingMenu_MouseLeave(object sender, EventArgs e)
        {
            SettingMenu.Hide();
        }

        private void сменитьНикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterNick enterNick = new EnterNick();
            enterNick.Show();
            enterNick.TopMost = true;
        }

        private void установитьАвтарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog avatar = new OpenFileDialog();
            avatar.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

            if (avatar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ProfileAvatarBig.Image = new Bitmap(avatar.FileName);
                    ProfileAvatarSmall.Image = new Bitmap(avatar.FileName);
                    File.Copy(avatar.FileName, @"Profile/avatarka.png", true);

                    using (StreamWriter ProfileConfig = new StreamWriter(@"Profile/ConfigProfile.DayzMap"))
                    {
                        ProfileConfig.WriteLine("1");
                        ProfileConfig.Close();
                    }
                    MessageBox.Show("Настройки применены! Лаунчер будет перезагружен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void параметрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void BtnSettings_MouseMove(object sender, MouseEventArgs e)
        {
            SettingMenu.Show(MousePosition);
        }
    }


}
