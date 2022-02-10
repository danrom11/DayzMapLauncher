using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DayzMap_Launcher
{
    public partial class Form2 : Form
    {
        public int CpValue = 0;
        public int ThCpValue = 0;
        public bool HtValue = false;
        public bool BlValue = false;
        public int RamValue = 0;
        public int VmValue = 0;
        public int LauncherTheme = 0;
        public bool InstallSetting = false;

        private int x = 0; private int y = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                DirArma3.Text = folder.SelectedPath;
            }
        }

        private void CpPU_Click(object sender, EventArgs e)
        {
            CpValue += 1;
            CP.Text = CpValue.ToString();
        }

        private void СpPD_Click(object sender, EventArgs e)
        {
            if (CpValue != 0)
            {
                CpValue -= 1;
                CP.Text = CpValue.ToString();
            }
        }

        private void HtPU_Click(object sender, EventArgs e)
        {
            if (HtValue == false) { HT.Location = new Point(HT.Location.X + 2, HT.Location.Y); }
            HtValue = true;
            HT.Text = "Вкл";
        }

        private void HtPD_Click(object sender, EventArgs e)
        {
            if (HtValue == true) { HT.Location = new Point(HT.Location.X - 2, HT.Location.Y); }
            HtValue = false;
            HT.Text = "Выкл";
        }

        private void BlPU_Click(object sender, EventArgs e)
        {
            if (BlValue == false) { BL.Location = new Point(BL.Location.X + 2, BL.Location.Y); }
            BlValue = true;
            BL.Text = "Вкл";
        }

        private void BlPD_Click(object sender, EventArgs e)
        {
            if (BlValue == true) { BL.Location = new Point(BL.Location.X - 2, BL.Location.Y); }
            BlValue = false;
            BL.Text = "Выкл";
        }

        private void RamPU_Click(object sender, EventArgs e)
        {
            RamValue += 256;
            RAM.Text = RamValue.ToString();

        }

        private void RamPD_Click(object sender, EventArgs e)
        {
            if (RamValue != 0)
            {
                RamValue -= 256;
                RAM.Text = RamValue.ToString();

            }

        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));
            }
        }

        private void VmPU_Click(object sender, EventArgs e)
        {
            VmValue += 256;
            VM.Text = VmValue.ToString();

        }

        private void VmPD_Click(object sender, EventArgs e)
        {
            if (VmValue != 0)
            {
                VmValue -= 256;
                VM.Text = VmValue.ToString();

            }
        }

        private void CP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void RAM_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void VM_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            if (InstallSetting == false)
            {
                using (StreamWriter stream = new StreamWriter(@"DayzMap Launcher.config"))
                {
                    stream.WriteLine(DirArma3.Text);
                    stream.WriteLine(CpValue);
                    stream.WriteLine(ThCpValue);
                    stream.WriteLine(HtValue);
                    stream.WriteLine(BlValue);
                    stream.WriteLine(RamValue);
                    stream.WriteLine(VmValue);
                    stream.WriteLine(LauncherTheme);
                    stream.Close();
                }
                MessageBox.Show("Настройки применены! Лаунчер будет перезагружен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
            else
            {
                MessageBox.Show("невозможно применить настройки во время скачивания и установки!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (HtValue == true)
            {
                HT.Text = "Вкл";
            }
            else { HT.Text = "Выкл"; }
            if (BlValue == true)
            {
                BL.Text = "Вкл";
            }
            else { BL.Text = "Выкл"; }

            if (ThCpValue == 0)
            {
                THCP.Text = "Windows System";
            }
            if (ThCpValue == 1)
            {
                THCP.Text = "INTEL";
            }
            if (ThCpValue == 2)
            {
                THCP.Text = "AMD";
            }

            if (LauncherTheme == 0)
            {
                TL.Text = "Standard Theme";
            }
            if (LauncherTheme == 1)
            {
                TL.Text = "Black & White Theme";
            }
        }

        private void ThCpPU_Click(object sender, EventArgs e)
        {
            if (ThCpValue != 2)
            {
                ThCpValue++;
                if (ThCpValue == 0)
                {
                    THCP.Text = "Windows System";
                }
                if (ThCpValue == 1)
                {
                    THCP.Text = "INTEL";
                }
                if (ThCpValue == 2)
                {
                    THCP.Text = "AMD";
                }
            }
        }

        private void ThCpPD_Click(object sender, EventArgs e)
        {
            if (ThCpValue != 0)
            {
                ThCpValue--;
                if (ThCpValue == 0)
                {
                    THCP.Text = "Windows System";
                }
                if (ThCpValue == 1)
                {
                    THCP.Text = "INTEL";
                }
                if (ThCpValue == 2)
                {
                    THCP.Text = "AMD";
                }
            }
        }

        private void TlPU_Click(object sender, EventArgs e)
        {
            if (LauncherTheme != 1)
            {
                LauncherTheme++;
            }
            if (LauncherTheme == 1)
            {

                TL.Text = "Black & White Theme";
            }
        }

        private void TlPD_Click(object sender, EventArgs e)
        {
            if (LauncherTheme != 0)
            {
                LauncherTheme--;
            }
            if (LauncherTheme == 0)
            {
                TL.Text = "Standard Theme";
            }
        }
    }
}
