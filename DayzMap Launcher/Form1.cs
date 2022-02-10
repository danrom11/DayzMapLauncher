using Ionic.Zip;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayzMap_Launcher
{
    public partial class Form1 : Form
    {
        ManagementEventWatcher startWatch = new ManagementEventWatcher(
                new WqlEventQuery("SELECT * FROM Win32_ProcessStartTrace WHERE ProcessName = \"arma3_x64.exe\""));
        ManagementEventWatcher stopWatch = new ManagementEventWatcher(
                new WqlEventQuery("SELECT * FROM Win32_ProcessStopTrace WHERE ProcessName = \"arma3_x64.exe\""));

        public string[] directory;
        public string[] dllFile;
        public string GameVersion;
        public string LauncherVersion = "0.3.6";
        public string LocalInstall;

        public string[] AddonsServer;
        public int Howmanyfiles = 0;
        public int Totalfilesdownloaded = 0;
        public int Needtodownloadfiles = 0;
        public string DownloadAddons;
        public int AddAddons;
        public string FileSizeArmaClent;

        public bool OnOffGame = false;
        public bool checkUpdate = true;
        public int LauncherTheme = 0;

        public bool Install = false;

        public string[] ProfileSettings;

        public string OneBlockURL;
        public string TwoBlockURL;
        public string ThreeBlockURL;

        public string[] Arma3Profile;
        public string NickName;

        const string SharedSecret = "He continually hurt Princess Mary's feelings and tormented her, but it cost her no effort to forgive him. Could he be to blame toward her, or could her father, whom she knew loved her in spite of it all, be unjust? And what is justice? The princess never thought of that proud word 'justice.' )3dV8g*EiK(%sc92xU0*99(Dt22j%IW#Wodfiz&(%72s3j4#";

        Form2 form2 = new Form2();
       // HelpForm helpform = new HelpForm();
       // MainProfile mainProfile = new MainProfile();
       // EnterNick enterNick = new EnterNick();
        DeletingInformation deletingInformation = new DeletingInformation();
        RebootAddons rebootAddons = new RebootAddons();
        GameStart gameStart = new GameStart();
        ProccesKill proccesKill = new ProccesKill();
        DB db = new DB();

        private int x_Form1 = 0; private int y_Form1 = 0;
        public String sMacAddress = string.Empty;
        public Form1()
        {
            InitializeComponent();
            webClient.Encoding = System.Text.Encoding.UTF8;
            LnHelp.Visible = false;
            LnNews.Visible = false;
            LnShop.Visible = false;

            Collapse.BalloonTipTitle = "DayzMap Launcher";
            Collapse.BalloonTipText = "Приложение свёрнуто";
            Collapse.Text = "DayzMap Launcher";
            form2.version.Text = LauncherVersion;

            SettingMenu.Cursor = System.Windows.Forms.Cursors.Hand;


            if (Process.GetProcessesByName("DayzMap Launcher").Length >= 2)
            {
                MessageBox.Show("Лаунчер уже запущен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

            

        }
        SynchronizationContext context;
        WebClient webClient = new WebClient();
        Stopwatch sw = new Stopwatch();
        private void panel2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                Collapse.Visible = true;
                Collapse.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                Collapse.Visible = false;
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            Collapse.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OnOffGame == false)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Нельзя закрыть лаунчер пока запущена игра!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x_Form1 = e.X; y_Form1 = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        { 
            LnShop.Visible = false;
            LnNews.Visible = false;
            LnHelp.Visible = false;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - x_Form1), this.Location.Y + (e.Y - y_Form1));
            }
        }

        private void Collapse_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            Collapse.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (OnOffGame == false)
            {  
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Нельзя закрыть лаунчер пока запущена игра!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            //form2.Show();
            //form2.InstallSetting = this.Install;
            //form2.TopMost = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            proccesKill.procKill();
            //установка и проверка параметров
            if (!System.IO.File.Exists(@"Parameters.log"))
            {
                System.IO.File.Delete(@"NickName.Arma3Profile");
                System.IO.File.Create(@"Parameters.log");
            }
            //Существует ли файл профиля
            if (!System.IO.File.Exists(@"NickName.Arma3Profile"))
            {
                System.IO.File.Create(@"NickName.Arma3Profile");
                MessageBox.Show("Файл профиля настроен! Лаунчер будет перезагружен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
            Arma3Profile = File.ReadAllLines(@"NickName.Arma3Profile", Encoding.UTF8);
            if(Arma3Profile.Length > 0)
            {
                NickName = Crypto.DecryptStringAES(Arma3Profile[0], SharedSecret);
                //NickName = Arma3Profile[0];
            }
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            try
            {
                if(System.IO.File.Exists(@"DayzMap Updater.exe"))
                {
                    var GlobalLauncherVersion = webClient.DownloadString("https://game-programmer.ru/UpdaterLauncher/GlobalVersion.config");
                    if (LauncherVersion != GlobalLauncherVersion)
                    {
                        var InfoUpdate = webClient.DownloadString("https://game-programmer.ru/UpdaterLauncher/InfoUpdate.config");
                        DialogResult UpdaterDialog = MessageBox.Show("Обнаружено обновление, установить? \n\n•••••••••••••••Об обновлении•••••••••••••••\n" + InfoUpdate, "Обновление " + GlobalLauncherVersion, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (UpdaterDialog == DialogResult.Yes)
                        {
                            Process.Start(@"DayzMap Updater.exe");
                            this.Close();
                        }
                        else
                        {
                            checkUpdate = false;
                        }
                    }
                }else if (System.IO.File.Exists(@"Updater.exe"))
                {
                    var GlobalLauncherVersion = webClient.DownloadString("https://game-programmer.ru/UpdaterLauncher/GlobalVersion.config");
                    if (LauncherVersion != GlobalLauncherVersion)
                    {
                        var InfoUpdate = webClient.DownloadString("https://game-programmer.ru/UpdaterLauncher/InfoUpdate.config");
                        DialogResult UpdaterDialog = MessageBox.Show("Обнаружено обновление, установить? \n\n•••••••••••••••Об обновлении•••••••••••••••\n" + InfoUpdate, "Обновление " + GlobalLauncherVersion, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (UpdaterDialog == DialogResult.Yes)
                        {
                            Process.Start(@"Updater.exe");
                            this.Close();
                        }
                        else
                        {
                            checkUpdate = false;
                        }
                    }
                }
                
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение с сервером", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }

            Thread.Sleep(1000);
            string link = @"https://game-programmer.ru/GameFiles/addons.ini";
            webClient.DownloadFileAsync(new Uri(link), "addons.ini");

            Thread.Sleep(1000);

            NewsClick();

            directory = File.ReadAllLines(@"DayzMap Launcher.config", Encoding.UTF8);

            ProfileSettings = File.ReadAllLines(@"Profile/ConfigProfile.DayzMap", Encoding.UTF8);


            if (System.IO.File.Exists(@"DayzMap Launcher.config"))
            {
                if (directory.Length >= 1)
                {

                    form2.DirArma3.Text = directory[0];

                    form2.CP.Text = directory[1];
                    form2.CpValue = Convert.ToInt32(directory[1]);

                    form2.ThCpValue = Convert.ToInt32(directory[2]);

                    form2.HtValue = Convert.ToBoolean(directory[3]);

                    form2.BlValue = Convert.ToBoolean(directory[4]);

                    form2.RAM.Text = directory[5];
                    form2.RamValue = Convert.ToInt32(directory[5]);

                    form2.VM.Text = directory[6];
                    form2.VmValue = Convert.ToInt32(directory[6]);

                    form2.LauncherTheme = Convert.ToInt32(directory[7]);


                    if (directory[7] == "0")
                    {
                        LauncherTheme = 0;
                        this.BackgroundImage = DayzMap_Launcher.Properties.Resources.dayzmap2;

                        BtnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(211)))));
                        BtnStart.BackHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(241)))));
                        //BtnStart.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(211)))));
                        //BtnStart.ButtonBorderColor = System.Drawing.Color.Black;
                        //BtnStart.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(241)))));
                        //BtnStart.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(241)))));
                        //BtnStart.ButtonHighlightForeColor = System.Drawing.SystemColors.ControlLightLight;
                        //BtnStart.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(157)))));
                        //BtnStart.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(157)))));
                        //BtnStart.ButtonPressedForeColor = System.Drawing.Color.White;
                        BtnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                    }
                    if (directory[7] == "1")
                    {
                        LauncherTheme = 1;
                        this.BackgroundImage = DayzMap_Launcher.Properties.Resources.dayzmap1;

                        BtnStart.BackColor = System.Drawing.SystemColors.ControlLightLight;
                        BtnStart.BackHoverColor = System.Drawing.SystemColors.Desktop;
                        //BtnStart.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
                        //BtnStart.ButtonBorderColor = System.Drawing.Color.Black;
                        //BtnStart.ButtonHighlightColor = System.Drawing.SystemColors.Desktop;
                        //BtnStart.ButtonHighlightColor2 = System.Drawing.SystemColors.Desktop;
                        //BtnStart.ButtonHighlightForeColor = System.Drawing.SystemColors.ControlLightLight;
                        //BtnStart.ButtonPressedColor = System.Drawing.SystemColors.Highlight;
                        //BtnStart.ButtonPressedColor2 = System.Drawing.SystemColors.HotTrack;
                        //BtnStart.ButtonPressedForeColor = System.Drawing.Color.White;
                        BtnStart.ForeColor = System.Drawing.Color.Black;
                    }


                    if (directory[0] != "")
                    {
                        if (System.IO.File.Exists(directory[0] + "/" + "Launcher directory.dll"))
                        {
                            rebootAddons.Reboot(directory[0]);
                            ChekUpdateDownloadAddons();


                        }
                        else
                        {
                            BtnStart.CustomButtonText = "Установить";
                        }
                    }

                }

            }
            else
            {
                using (StreamWriter stream = new StreamWriter(@"DayzMap Launcher.config"))
                {
                    stream.Close();
                }
            }

            if (ProfileSettings.Length > 0)
            {
                if (ProfileSettings[0] != "")
                {
                    ProfileAvatar.Image = new Bitmap(@"Profile/avatarka.png");
                }
            }
        }
        private async void BtnStart_Click(object sender, EventArgs e)
        {
            if (BtnStart.CustomButtonText == "Играть")
            {
                if (OnOffGame == false)
                {
                    Arma3Profile = File.ReadAllLines(@"NickName.Arma3Profile", Encoding.UTF8);
                    if (Arma3Profile.Length > 0) { NickName = Crypto.DecryptStringAES(Arma3Profile[0], SharedSecret); }
                    
                    if (NickName == null) 
                    {
                        EnterNick enterNick = new EnterNick();
                        enterNick.Show();
                        enterNick.TopMost = true;
                       return; 
                    }

                    NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

                    foreach (NetworkInterface adapter in nics)
                    {
                        if (sMacAddress == String.Empty)// only return MAC Address from first card  
                        {
                            IPInterfaceProperties properties = adapter.GetIPProperties();
                            sMacAddress = adapter.GetPhysicalAddress().ToString();
                        }
                    }

                    MySqlCommand command = new MySqlCommand("UPDATE `players` SET `Did` = @did WHERE `players`.`name` = @Name;", db.getConnection());

                    command.Parameters.Add("@did", MySqlDbType.VarChar).Value = sMacAddress;
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
                    }





                    System.IO.File.SetAttributes(directory[0] + "/" + "Arma3.exe", System.IO.FileAttributes.Normal);
                    System.IO.File.SetAttributes(directory[0] + "/" + "arma3_x64.exe", System.IO.FileAttributes.Normal);
                    System.IO.File.SetAttributes(directory[0] + "/" + "arma3battleye.exe", System.IO.FileAttributes.Normal);
                    System.IO.File.SetAttributes(directory[0] + "/" + "arma3launcher.exe", System.IO.FileAttributes.Normal);
                    System.IO.File.SetAttributes(directory[0] + "/" + "START_Elysium_64bit.bat", System.IO.FileAttributes.Normal);
                    startWatch.EventArrived += startWatch_EventArrived;
                    startWatch.Start();

                    WindowState = FormWindowState.Minimized;
                    gameStart.ChekNickGame(NickName);

                    gameStart.CheckGameAddonsFiles(directory);

                    gameStart.Arma3Start(directory, NickName);

                    Process.Start(directory[0] + "/" + "START_Elysium_64bit.bat");
                }
                else { MessageBox.Show("Игра уже запущена!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            if (BtnStart.CustomButtonText == "Установить")
            {
                if (directory.Length < 1)
                {
                    DialogResult InstallDialog = MessageBox.Show("Выберете каталог установки", "Установка", MessageBoxButtons.OKCancel);

                    if (InstallDialog == DialogResult.OK)
                    {
                        FolderBrowserDialog folder = new FolderBrowserDialog();
                        if (folder.ShowDialog() == DialogResult.OK)
                        {
                            LocalInstall = folder.SelectedPath;
                            BtnStart.CustomButtonText = "Играть";
                            BtnStart.Enabled = false;
                            if (LauncherTheme == 0)
                            {
                                BtnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(157)))));
                                //BtnStart.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(157)))));
                            }
                            if (LauncherTheme == 1)
                            {
                                BtnStart.BackColor = SystemColors.ControlDarkDark;
                                //BtnStart.BackColor2 = SystemColors.ControlDarkDark;
                            }
                            fsProgressBar1.Visible = true;
                            using (StreamWriter stream = new StreamWriter(@"DayzMap Launcher.config"))
                            {
                                stream.WriteLine(LocalInstall);
                                stream.WriteLine(form2.CpValue);
                                stream.WriteLine(form2.ThCpValue);
                                stream.WriteLine(form2.HtValue);
                                stream.WriteLine(form2.BlValue);
                                stream.WriteLine(form2.RamValue);
                                stream.WriteLine(form2.VmValue);
                                stream.WriteLine(form2.LauncherTheme);
                                stream.Close();
                            }
                            Install = true;
                            startDOWN();
                        }
                    }
                }
                else
                {
                    DialogResult InstallDialog2 = MessageBox.Show("Установить в каталог " + directory[0], "Установка", MessageBoxButtons.YesNo);

                    if (InstallDialog2 == DialogResult.Yes)
                    {
                        LocalInstall = directory[0];
                        BtnStart.CustomButtonText = "Играть";
                        BtnStart.Enabled = false;
                        if (LauncherTheme == 0)
                        {
                            BtnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(157)))));
                            //BtnStart.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(157)))));
                        }
                        if (LauncherTheme == 1)
                        {
                            BtnStart.BackColor = SystemColors.ControlDarkDark;
                            //BtnStart.BackColor2 = SystemColors.ControlDarkDark;
                        }
                        fsProgressBar1.Visible = true;
                        using (StreamWriter stream = new StreamWriter(@"DayzMap Launcher.config"))
                        {
                            stream.WriteLine(LocalInstall);
                            stream.WriteLine(form2.CpValue);
                            stream.WriteLine(form2.ThCpValue);
                            stream.WriteLine(form2.HtValue);
                            stream.WriteLine(form2.BlValue);
                            stream.WriteLine(form2.RamValue);
                            stream.WriteLine(form2.VmValue);
                            stream.WriteLine(form2.LauncherTheme);
                            stream.Close();
                        }
                        Install = true;
                        startDOWN();
                    }
                    else
                    {
                        DialogResult InstallDialog = MessageBox.Show("Выберете каталог установки", "Установка", MessageBoxButtons.OKCancel);

                        if (InstallDialog == DialogResult.OK)
                        {
                            FolderBrowserDialog folder = new FolderBrowserDialog();
                            if (folder.ShowDialog() == DialogResult.OK)
                            {
                                LocalInstall = folder.SelectedPath;
                                BtnStart.CustomButtonText = "Играть";
                                BtnStart.Enabled = false;
                                if (LauncherTheme == 0)
                                {
                                    BtnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(157)))));
                                    //BtnStart.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(157)))));
                                }
                                if (LauncherTheme == 1)
                                {
                                    BtnStart.BackColor = SystemColors.ControlDarkDark;
                                    //BtnStart.BackColor2 = SystemColors.ControlDarkDark;
                                }
                                fsProgressBar1.Visible = true;
                                using (StreamWriter stream = new StreamWriter(@"DayzMap Launcher.config"))
                                {
                                    stream.WriteLine(LocalInstall);
                                    stream.WriteLine(form2.CpValue);
                                    stream.WriteLine(form2.ThCpValue);
                                    stream.WriteLine(form2.HtValue);
                                    stream.WriteLine(form2.BlValue);
                                    stream.WriteLine(form2.RamValue);
                                    stream.WriteLine(form2.VmValue);
                                    stream.WriteLine(form2.LauncherTheme);
                                    stream.Close();
                                }
                                Install = true;
                                startDOWN();
                            }
                        }
                    }
                }

            }
            if (BtnStart.CustomButtonText == "Обновить")
            {
                if (OnOffGame == false)
                {
                    LocalInstall = directory[0];
                    BtnStart.CustomButtonText = "Играть";
                    BtnStart.Enabled = false;
                    if (LauncherTheme == 0)
                    {
                        BtnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(157)))));
                        //BtnStart.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(157)))));
                    }
                    if (LauncherTheme == 1)
                    {
                        BtnStart.BackColor = SystemColors.ControlDarkDark;
                        //BtnStart.BackColor2 = SystemColors.ControlDarkDark;
                    }
                    DnInfo.Visible = true;
                    fsProgressBar1.Visible = true;

                    Install = true;
                    DownloadReplace();
                }
                else { MessageBox.Show("Закройте игру перед началом установки обновления", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }




        }


        private void startWatch_EventArrived(object sender, EventArrivedEventArgs e)
        {
            startWatch.Stop();
            OnOffGame = true;
            stopWatch.EventArrived += stopWatch_EventArrived;
            stopWatch.Start();
        }

        private void stopWatch_EventArrived(object sender, EventArrivedEventArgs e)
        {
            ///Временно (проблема с повторым нажатием ИГРАТЬ)
          //  this.Show();
            OnOffGame = false;
           Collapse.Visible = false;
            WindowState = FormWindowState.Normal;
            System.IO.File.SetAttributes(directory[0] + "/" + "Arma3.exe", System.IO.FileAttributes.Hidden);
            System.IO.File.SetAttributes(directory[0] + "/" + "arma3_x64.exe", System.IO.FileAttributes.Hidden);
            System.IO.File.SetAttributes(directory[0] + "/" + "arma3battleye.exe", System.IO.FileAttributes.Hidden);
            System.IO.File.SetAttributes(directory[0] + "/" + "arma3launcher.exe", System.IO.FileAttributes.Hidden);
            System.IO.File.SetAttributes(directory[0] + "/" + "START_Elysium_64bit.bat", System.IO.FileAttributes.Hidden);
            stopWatch.Stop();

            ///Временно (проблема с повторым нажатием ИГРАТЬ)
            Application.Restart();
        }

        void ChekUpdateDownloadAddons()
        {

            AddonsServer = File.ReadAllLines(@"addons.ini", System.Text.Encoding.Default);

            string[] allfiles = Directory.GetFiles(directory[0] + "/" + "@Elysium" + "/" + "addons");
            string[] allfilesDel = Directory.GetFiles(directory[0] + "/" + "@Elysium" + "/" + "addons");


            for (int i = 0; i < allfiles.Length; i++)
            {
                allfilesDel[i] = allfilesDel[i].Substring(allfilesDel[i].IndexOf("addons") + 7);
            }
            for (int i = 0; i < allfilesDel.Length; i++)
            {
                for (int k = 0; k < AddonsServer.Length; k++)
                {
                    if (AddonsServer[k] == allfilesDel[i])
                    {
                        Console.WriteLine(allfilesDel[i]);
                        allfilesDel[i] = "0";

                    }

                }
            }
            for (int i = 0; i < allfilesDel.Length; i++)
            {
                if (allfilesDel[i] != "0")
                {
                    File.Delete(directory[0] + "/" + "@Elysium" + "/" + "addons" + "/" + allfilesDel[i]);
                }

            }


            for (int i = 0; i < allfiles.Length; i++)
            {
                for (int k = 0; k < AddonsServer.Length; k++)
                {
                    if (allfiles[i].Substring(allfiles[i].IndexOf("addons") + 7) == AddonsServer[k])
                    {
                        AddonsServer[k] = "0";
                    }
                }
            }
            for (int s = 0; s < AddonsServer.Length; s++)
            {
                if (AddonsServer[s] != "0")
                {
                    Console.WriteLine(AddonsServer[s]);
                    Console.WriteLine(Howmanyfiles);
                    Howmanyfiles++;
                    BtnStart.CustomButtonText = "Обновить";
                }
            }
            if (Howmanyfiles == 0)
            {
                BtnStart.CustomButtonText = "Играть";
                if (LauncherTheme == 0)
                {
                    BtnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(211)))));
                    //BtnStart.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(211)))));
                    //BtnStart.ButtonBorderColor = System.Drawing.Color.Black;
                    //BtnStart.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(241)))));
                    //BtnStart.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(241)))));
                    //BtnStart.ButtonHighlightForeColor = System.Drawing.SystemColors.ControlLightLight;
                    //BtnStart.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(157)))));
                    //BtnStart.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(157)))));
                    //BtnStart.ButtonPressedForeColor = System.Drawing.Color.White;
                    BtnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                    BtnStart.Enabled = true;
                }
                if (LauncherTheme == 1)
                {
                    BtnStart.BackColor = System.Drawing.SystemColors.ControlLightLight;
                    //BtnStart.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
                    //BtnStart.ButtonBorderColor = System.Drawing.Color.Black;
                    //BtnStart.ButtonHighlightColor = System.Drawing.SystemColors.Desktop;
                    //BtnStart.ButtonHighlightColor2 = System.Drawing.SystemColors.Desktop;
                    //BtnStart.ButtonHighlightForeColor = System.Drawing.SystemColors.ControlLightLight;
                    //BtnStart.ButtonPressedColor = System.Drawing.SystemColors.Highlight;
                    //BtnStart.ButtonPressedColor2 = System.Drawing.SystemColors.HotTrack;
                    //BtnStart.ButtonPressedForeColor = System.Drawing.Color.White;
                    BtnStart.ForeColor = System.Drawing.Color.Black;
                    BtnStart.Enabled = true;
                }
            }
            Needtodownloadfiles = Howmanyfiles;
        }

        void DownloadReplace()
        {
            for (int s = 0; s < AddonsServer.Length; s++)
            {
                Console.WriteLine("Down" + Howmanyfiles);
                if (AddonsServer[s] != "0" && (Howmanyfiles != 0))
                {
                    AddAddons = s;

                   //Howmanyfiles--;
                    DownloadAddons = AddonsServer[s];
                   // AddonsServer[s] = "0";
                    DownlaodStartAddons();
                    break;
                }
                else if (Howmanyfiles == 0)
                {
                    BtnStart.CustomButtonText = "Играть";
                    if (LauncherTheme == 0)
                    {
                        BtnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(211)))));
                        //BtnStart.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(211)))));
                        //BtnStart.ButtonBorderColor = System.Drawing.Color.Black;
                        //BtnStart.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(241)))));
                        //BtnStart.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(241)))));
                        //BtnStart.ButtonHighlightForeColor = System.Drawing.SystemColors.ControlLightLight;
                        //BtnStart.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(157)))));
                        //BtnStart.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(157)))));
                        //BtnStart.ButtonPressedForeColor = System.Drawing.Color.White;
                        BtnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                        BtnStart.Enabled = true;
                    }
                    if (LauncherTheme == 1)
                    {
                        BtnStart.BackColor = System.Drawing.SystemColors.ControlLightLight;
                        //BtnStart.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
                        //BtnStart.ButtonBorderColor = System.Drawing.Color.Black;
                        //BtnStart.ButtonHighlightColor = System.Drawing.SystemColors.Desktop;
                        //BtnStart.ButtonHighlightColor2 = System.Drawing.SystemColors.Desktop;
                        //BtnStart.ButtonHighlightForeColor = System.Drawing.SystemColors.ControlLightLight;
                        //BtnStart.ButtonPressedColor = System.Drawing.SystemColors.Highlight;
                        //BtnStart.ButtonPressedColor2 = System.Drawing.SystemColors.HotTrack;
                        //BtnStart.ButtonPressedForeColor = System.Drawing.Color.White;
                        BtnStart.ForeColor = System.Drawing.Color.Black;
                        BtnStart.Enabled = true;
                    }
                    DnInfo.Visible = false;
                    fsProgressBar1.Visible = false;
                }
            }
        }

        void DownlaodStartAddons()
        {
            Totalfilesdownloaded++;
            DnInfo.Visible = true;
            fsProgressBar1.Visible = true;
            Console.WriteLine(DownloadAddons);
            Uri uri = new Uri("https://game-programmer.ru/GameFiles/addons" + "/" + DownloadAddons);
            webClient.DownloadFileAsync(uri, directory[0] + "/" + "@Elysium" + "/" + "addons" + "/" + DownloadAddons);
            webClient.DownloadProgressChanged += new System.Net.DownloadProgressChangedEventHandler(webClient_AddonsDownloadProgressChanged);
            webClient.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(webClient_AddonsDownloadFileCompleted);
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            sw.Start();
        }

        private void webClient_AddonsDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            try
            {
                DnInfo.Text = Totalfilesdownloaded + "/" + Needtodownloadfiles;

                if (fsProgressBar1.Value != e.ProgressPercentage)
                    fsProgressBar1.Value = e.ProgressPercentage;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void webClient_AddonsDownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            fsProgressBar1.Value = 0;
            DnInfo.Text = "";

           

            webClient.Dispose();
            AddonsDownload.Enabled = true;
        }

        private void AddonsDownload_Tick(object sender, EventArgs e)
        {
            Howmanyfiles--;
            AddonsServer[AddAddons] = "0";
            Console.WriteLine("tick" + Howmanyfiles);
            DownloadAddons = null;

            DownloadReplace();
            AddonsDownload.Enabled = false;
        }

        async void startDOWN()
        {
            DnInfo.Visible = true;
            var webRequest = HttpWebRequest.Create("https://game-programmer.ru/GameFiles/Arma3.zip");
            webRequest.Method = "HEAD";

            using (var webResponse = webRequest.GetResponse())
            {
                FileSizeArmaClent = webResponse.Headers.Get("Content-Length");
            }
            if (_cts == null)
            {
                _cts = new CancellationTokenSource();
                try
                {
                    // укажите здесь нужный URL и путь к файлу
                    // обратите внимение на new Progress<int>(v => progressBar1.Value = v) - оно и меняет значение прогресс бара во время загрузки

                    await DownloadAndSaveFileAsync("https://game-programmer.ru/GameFiles/Arma3.zip", LocalInstall + "/" + "Arma3.zip", new Progress<int>(v => fsProgressBar1.Value = v), _cts.Token);

                }
                catch (OperationCanceledException) { }
                catch (HttpRequestException ex)
                {
                    if (ex.Message.Contains("416")) // 416 (Requested Range Not Satisfiable)
                    {
                        MessageBox.Show("Файл уже закачан");
                    }
                    else
                    {
                        MessageBox.Show(ex.Message + "\r\n\r\n" + ex.StackTrace, "HttpRequestException");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\n\r\n" + ex.StackTrace, "Exception");
                }
                finally
                {
                    _cts.Dispose();
                    _cts = null;
                    if (fsProgressBar1.Value == 100)
                    {
                        var zip = ZipFile.Read(LocalInstall + "/" + "Arma3.zip");
                        zip.ExtractProgress += zip_ExtractProgress;
                        fsProgressBar1.MaxValue = zip.Count;

                        context = SynchronizationContext.Current;
                        new Thread(
                            delegate ()
                            {
                                ExtractAsync(LocalInstall + "/.", zip);
                            }).Start();
                    }
                }

            }
        }

        // HttpClient создается один раз на всё время работы приложения
        private static readonly HttpClient _client = new HttpClient();

        // Токен отмены служит для прерывания работы загрузчика в любой момент
        private CancellationTokenSource _cts;

        // метод универсален, проверен в .NET Core и .NET Framework
        private async Task DownloadAndSaveFileAsync(string url, string path, IProgress<int> status, CancellationToken token)
        {
            const int bufferLength = 8192;
            long currentPosition = File.Exists(path) ? new FileInfo(path).Length : 0;

            using (HttpRequestMessage request = new HttpRequestMessage { RequestUri = new Uri(url) })
            {
                request.Headers.Range = new RangeHeaderValue(currentPosition, null);
                using (HttpResponseMessage response = await _client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, token))
                {
                    response.EnsureSuccessStatusCode();
                    using (Stream responseStream = await response.Content.ReadAsStreamAsync())
                    using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.None))
                    {
                        long contentLength = currentPosition + response.Content.Headers.ContentLength ?? 0;
                        int progress = -1;
                        int oldProgress;
                        byte[] buffer = new byte[bufferLength];
                        int bytesReceived;
                        while ((bytesReceived = await responseStream.ReadAsync(buffer, 0, bufferLength, token).ConfigureAwait(false)) > 0)
                        {
                            await fs.WriteAsync(buffer, 0, bytesReceived, token).ConfigureAwait(false);
                            currentPosition += bytesReceived;
                            DnInfo.Text = currentPosition / 1024 / 1024 + "МБ" + " / " + Convert.ToString(Convert.ToInt64(FileSizeArmaClent) / 1024 / 1024) + "МБ";
                            oldProgress = progress;
                            progress = (int)(currentPosition * 100 / contentLength);
                            // так как значение от 0 до 100, нет особого смысла повтороно обновлять интерфейс, если значение не изменилось.
                            if (oldProgress != progress)
                            {
                                status?.Report(progress);
                            }
                        }
                    }
                }
            }
        }

        void ExtractAsync(string to, ZipFile zip)
        {
            zip.ExtractAll(to, ExtractExistingFileAction.OverwriteSilently);
            zip.Dispose();
        }


        private void zip_ExtractProgress(object sender, ExtractProgressEventArgs e)
        {
            switch (e.EventType)
            {
                case ZipProgressEventType.Extracting_AfterExtractEntry:
                    if (context != null)
                        context.Send(
                            (o) =>
                            {
                                fsProgressBar1.Value = e.EntriesExtracted;
                                if (fsProgressBar1.Value == fsProgressBar1.MaxValue)
                                {

                                    deliteZIP.Enabled = true;



                                }
                            },
                            null
                            );

                    break;

            }
        }

        private void deliteZIP_Tick(object sender, EventArgs e)
        {
            File.Delete(LocalInstall + "/" + "Arma3.zip");
            Application.Restart();
            deliteZIP.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (NickName != null || NickName != "")
                {
                    deletingInformation.DeletingServerInformation(NickName);
                }
            }
            catch
            {

            }         
            try
            {
                if (directory.Length >= 1)
                {
                    try
                    {
                        System.IO.File.SetAttributes(directory[0] + "/" + "Arma3.exe", System.IO.FileAttributes.Hidden);
                        System.IO.File.SetAttributes(directory[0] + "/" + "arma3_x64.exe", System.IO.FileAttributes.Hidden);
                        System.IO.File.SetAttributes(directory[0] + "/" + "arma3battleye.exe", System.IO.FileAttributes.Hidden);
                        System.IO.File.SetAttributes(directory[0] + "/" + "arma3launcher.exe", System.IO.FileAttributes.Hidden);
                        System.IO.File.SetAttributes(directory[0] + "/" + "START_Elysium_64bit.bat", System.IO.FileAttributes.Hidden);
                    }
                    catch
                    {

                    }
                    try
                    {
                        Process[] proc = Process.GetProcessesByName("arma3_x64");
                        proc[0].Kill();
                    }
                    catch
                    {

                    }
                }
            }
            catch
            {

            }

            if (Install == true)
            {
                try
                {
                    webClient.Dispose();
                    webClient.CancelAsync();

                    Thread.Sleep(1000);

                    File.Delete(directory[0] + "/" + "@Elysium" + "/" + "addons" + "/" + DownloadAddons);
                    Console.WriteLine("Файл удалён: " + DownloadAddons);
                }
                catch
                {
                    Console.WriteLine("Файл не удалён! " + DownloadAddons);
                }

            }


        }

        private void загрузитьАватарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog avatar = new OpenFileDialog();
            avatar.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

            if (avatar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ProfileAvatar.Image = new Bitmap(avatar.FileName);
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

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            HelpForm helpform = new HelpForm();
            helpform.GetTheme = this.LauncherTheme;
            helpform.StartPosition = FormStartPosition.Manual;
            helpform.Location = Location;
            helpform.OnOffGameHelpForm = this.OnOffGame;
            this.Hide();

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
            helpform.Show();
        }

        private void UpdateNews_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Install == false)
                {
                    OneNews.ImageLocation = "https://game-programmer.ru/BlockNews/OneNewsBlock.png";
                    TwoNews.ImageLocation = "https://game-programmer.ru/BlockNews/TwoNewsBlock.png";
                    ThreeNews.ImageLocation = "https://game-programmer.ru/BlockNews/ThreeNewsBlock.png";
                    NewsClick();
                }
            }
            catch
            {

            }
        }

        private void SearchUpdates_Tick(object sender, EventArgs e)
        {
            if (Install == false)
            {
                if (checkUpdate == true)
                {
                    try
                    {
                        var GameVersionServer = webClient.DownloadString("https://game-programmer.ru/GameFiles/GlobalVersion.config");
                        var GlobalLauncherVersion = webClient.DownloadString("https://game-programmer.ru/UpdaterLauncher/GlobalVersion.config");
                        if (GameVersion != GameVersionServer || LauncherVersion != GlobalLauncherVersion)
                        {
                            checkUpdate = false;
                            DialogResult SearchUpdateDialog = MessageBox.Show("Внимание вышло обновление! Нажмите 'Да' что бы установить его, лаунчер будет перезагружен автоматически!", "Обновление!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (SearchUpdateDialog == DialogResult.Yes)
                            {
                                if (OnOffGame == false)
                                {
                                    Application.Restart();

                                }
                                else
                                {
                                    MessageBox.Show("Закройте игру что бы установить обновление!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }

                            }
                            if (SearchUpdateDialog == DialogResult.No)
                            {
                                checkUpdate = false;
                            }
                        }
                    }
                    catch
                    {

                    }

                }
            }

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

        void NewsClick()
        {
            var NewsBlockURLLoad = webClient.DownloadString("https://game-programmer.ru/BlockNews/NewsURL.ini");
            string[] NewsBlockURL = new string[] { "" };
            NewsBlockURL = NewsBlockURLLoad.Split(';');
            OneBlockURL = NewsBlockURL[0].Substring(NewsBlockURL[0].IndexOf("OneBlock=") + 9);
            TwoBlockURL = NewsBlockURL[1].Substring(NewsBlockURL[1].IndexOf("TwoBlock=") + 9);
            ThreeBlockURL = NewsBlockURL[2].Substring(NewsBlockURL[2].IndexOf("ThreeBlock=") + 11);

            if (OneBlockURL != "")
            {
                OneNews.Cursor = Cursors.Hand;
            }
            if (TwoBlockURL != "")
            {
                TwoNews.Cursor = Cursors.Hand;
            }
            if (ThreeBlockURL != "")
            {
                ThreeNews.Cursor = Cursors.Hand;
            }

        }

        private void OneNews_Click(object sender, EventArgs e)
        {
            if (OneBlockURL != "")
            {
                Process.Start(OneBlockURL);
            }
        }

        private void TwoNews_Click(object sender, EventArgs e)
        {
            if (TwoBlockURL != "")
            {
                Process.Start(TwoBlockURL);
            }
        }

        private void ThreeNews_Click(object sender, EventArgs e)
        {
            if (ThreeBlockURL != "")
            {
                Process.Start(ThreeBlockURL);
            }
        }

        private void ProfileAvatar_Click(object sender, EventArgs e)
        {
            MainProfile mainProfile = new MainProfile();
            
                Arma3Profile = File.ReadAllLines(@"NickName.Arma3Profile", Encoding.UTF8);
                if(Arma3Profile.Length != 0)
                {
                    NickName = Crypto.DecryptStringAES(Arma3Profile[0], SharedSecret);
                }

            //if (this.NickName == null)
            //{
            //    Arma3Profile = File.ReadAllLines(@"NickName.Arma3Profile", Encoding.UTF8);
            //    NickName = Crypto.DecryptStringAES(Arma3Profile[0], SharedSecret);
            //   // NickName = Arma3Profile[0];
            //}
            mainProfile.StartPosition = FormStartPosition.Manual;
            mainProfile.Location = Location;
            mainProfile.LauncherTheme = LauncherTheme;
            mainProfile.NickName = this.NickName;
            this.Hide();
            mainProfile.Show();
        }

        private void профильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainProfile mainProfile = new MainProfile();
           
                Arma3Profile = File.ReadAllLines(@"NickName.Arma3Profile", Encoding.UTF8);
                if (Arma3Profile.Length != 0)
                {
                    NickName = Crypto.DecryptStringAES(Arma3Profile[0], SharedSecret);
                }

            mainProfile.StartPosition = FormStartPosition.Manual;
            mainProfile.Location = Location;
            mainProfile.LauncherTheme = LauncherTheme;
            mainProfile.NickName = this.NickName;
            this.Hide();
            mainProfile.Show();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            SettingMenu.Show(MousePosition);          
        }

        private void сменитьНикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterNick enterNick = new EnterNick();
            enterNick.Show();
            enterNick.TopMost = true;
        }

        private void SettingMenu_MouseLeave(object sender, EventArgs e)
        {
            SettingMenu.Hide();
        }

        private void параметрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2.Show();
            form2.InstallSetting = this.Install;
            form2.TopMost = true;
        }

        private void установитьАвтарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog avatar = new OpenFileDialog();
            avatar.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

            if (avatar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ProfileAvatar.Image = new Bitmap(avatar.FileName);
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

        private void профильToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainProfile mainProfile = new MainProfile();

            Arma3Profile = File.ReadAllLines(@"NickName.Arma3Profile", Encoding.UTF8);
            if (Arma3Profile.Length != 0)
            {
                NickName = Crypto.DecryptStringAES(Arma3Profile[0], SharedSecret);
            }

            mainProfile.StartPosition = FormStartPosition.Manual;
            mainProfile.Location = Location;
            mainProfile.LauncherTheme = LauncherTheme;
            mainProfile.NickName = this.NickName;
            this.Hide();
            mainProfile.Show();
        }
    }
}
