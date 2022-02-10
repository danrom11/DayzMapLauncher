using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace DayzMap_Launcher
{
    public partial class HelpForm : Form
    {
        public int x_HelpForm = 0; public int y_HelpForm = 0;
        public bool OnOffGameHelpForm;
        public string Avatarimage;
        public string NickName;
        public String sMacAddress = string.Empty;
        const string SharedSecret = "He continually hurt Princess Mary's feelings and tormented her, but it cost her no effort to forgive him. Could he be to blame toward her, or could her father, whom she knew loved her in spite of it all, be unjust? And what is justice? The princess never thought of that proud word 'justice.' )3dV8g*EiK(%sc92xU0*99(Dt22j%IW#Wodfiz&(%72s3j4#";
        int LauncherTheme;
        public int GetTheme
        {
            get { return GetTheme; }
            set { LauncherTheme = value; } 
        }
        public HelpForm()
        {
            InitializeComponent();
            LnHelp.Visible = false;
            LnNews.Visible = false;
            LnShop.Visible = false;
            BtnBack.Visible = false;

            TextBoxAnswer.ReadOnly = true;
            TextBoxAnswer.Enabled = false;

            SettingMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            //Collapse.BalloonTipTitle = "DayzMap Launcher";
            //Collapse.BalloonTipText = "Приложение свёрнуто";
            //Collapse.Text = "DayzMap Launcher";
        }

        private void HelpForm_MouseDown(object sender, MouseEventArgs e)
        {
            x_HelpForm = e.X; y_HelpForm = e.Y;
        }

        private void HelpForm_MouseMove(object sender, MouseEventArgs e)
        {
            LnShop.Visible = false;
            LnNews.Visible = false;
            LnHelp.Visible = false;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - x_HelpForm), this.Location.Y + (e.Y - y_HelpForm));
            }
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"Profile/avatarka.png"))
            {
                Avatarimage = @"Profile/avatarka.png";
                ProfileAvatar.Image = new Bitmap(Avatarimage);
            }         
        }

        private void panel1_Click(object sender, EventArgs e)
        {

            Form form1 = Application.OpenForms[0];
            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = Location;
            form1.Show();
            this.Close();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            //Form3 form3 = new Form3();
            //form3.Show();
        }

        

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OnOffGameHelpForm == false)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Нельзя закрыть лаунчер пока запущена игра!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (OnOffGameHelpForm == false)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Нельзя закрыть лаунчер пока запущена игра!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnRez_Click(object sender, EventArgs e)
        {
            Form form1 = Application.OpenForms[0];
            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = Location;
            form1.Show();
            form1.WindowState = FormWindowState.Minimized;
            this.Close();
            //MessageBox.Show("Временно не доступно!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // WindowState = FormWindowState.Minimized;
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

        private void BtnNews_Click(object sender, EventArgs e)
        {
            Process.Start("https://dayzmap.ru/forums/novosti-servera-arma3-altis-lajf-elysium.28/");
        }

        private void BtnShop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Временно не доступно!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void QuesOne_Click(object sender, EventArgs e)
        {
            QuesOne.Visible = false;
            QuesTwo.Visible = false;
            QuesThree.Visible = false;
            QuesFour.Visible = false;
            QuesFive.Visible = false;
            BtnBack.Visible = true;

            TextBoxAnswer.Enabled = true;
            TextBoxAnswer.Text = "Ваш профиль находиться справа вверху рядом с настройками. Вы можете кликнуть левой кнопкой мыши по месту где должн быть ваш аватар, или вы можете кликнуть правой кнопкой мыши, чтобы вышла всплывающие окно.";
        }

        private void QuesTwo_Click(object sender, EventArgs e)
        {
            QuesOne.Visible = false;
            QuesTwo.Visible = false;
            QuesThree.Visible = false;
            QuesFour.Visible = false;
            QuesFive.Visible = false;
            BtnBack.Visible = true;

            TextBoxAnswer.Enabled = true;
            TextBoxAnswer.Text = "Вы должны зайти в свой профиль, после нажать на свою большую аватарку правой кнопкой мыши, после вы должны выбрать \"Сменить ник\"";
        }

        private void QuesThree_Click(object sender, EventArgs e)
        {
            QuesOne.Visible = false;
            QuesTwo.Visible = false;
            QuesThree.Visible = false;
            QuesFour.Visible = false;
            QuesFive.Visible = false;
            BtnBack.Visible = true;

            TextBoxAnswer.Enabled = true;
            TextBoxAnswer.Text = "Удалить папку BattlEye по пути C:\\Program Files(x86)\\Common Files";            
        }

        private void QuesFour_Click(object sender, EventArgs e)
        {
            QuesOne.Visible = false;
            QuesTwo.Visible = false;
            QuesThree.Visible = false;
            QuesFour.Visible = false;
            QuesFive.Visible = false;
            BtnBack.Visible = true;

            TextBoxAnswer.Enabled = true;
            TextBoxAnswer.Text = "Запустите TeamSpeak 3 от имени администратора"; 
        }

        private void QuesFive_Click(object sender, EventArgs e)
        {
            QuesOne.Visible = false;
            QuesTwo.Visible = false;
            QuesThree.Visible = false;
            QuesFour.Visible = false;
            QuesFive.Visible = false;
            BtnBack.Visible = true;

            TextBoxAnswer.Enabled = true;
            TextBoxAnswer.Text = "TeamSpeak 3 зайдите в →инструменты →параметры →запись и выставите кнопку Ctrl";
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            QuesOne.Visible = true;
            QuesTwo.Visible = true;
            QuesThree.Visible = true;
            QuesFour.Visible = true;
            QuesFive.Visible = true;
            BtnBack.Visible = true;

            TextBoxAnswer.Enabled = false;
            TextBoxAnswer.Text = null;
            BtnBack.Visible = false;
        }

        private void профильToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainProfile mainProfile = new MainProfile();

            string[] Arma3Profile = File.ReadAllLines(@"NickName.Arma3Profile", Encoding.UTF8);
            if (Arma3Profile.Length != 0)
            {
                NickName = Crypto.DecryptStringAES(Arma3Profile[0], SharedSecret);
            }

            mainProfile.StartPosition = FormStartPosition.Manual;
            mainProfile.Location = Location;
            mainProfile.LauncherTheme = LauncherTheme;
            mainProfile.NickName = NickName;
            this.Hide();
            mainProfile.Show();
        }

        private void BtnSettings_MouseMove(object sender, MouseEventArgs e)
        {
            SettingMenu.Show(MousePosition);
        }

        private void SettingMenu_MouseLeave(object sender, EventArgs e)
        {
            SettingMenu.Hide();
        }

        private void параметрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
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
    }
}
