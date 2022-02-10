using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayzMap_Launcher
{
    public partial class EnterNick : Form
    {
        public string NickEnter;
        const string SharedSecret = "He continually hurt Princess Mary's feelings and tormented her, but it cost her no effort to forgive him. Could he be to blame toward her, or could her father, whom she knew loved her in spite of it all, be unjust? And what is justice? The princess never thought of that proud word 'justice.' )3dV8g*EiK(%sc92xU0*99(Dt22j%IW#Wodfiz&(%72s3j4#";
        DB db = new DB();
        public String sMacAddress = string.Empty;
        public EnterNick()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if(MyNick.Text != "")
            {
                NickEnter = MyNick.Text;


                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `players` WHERE `name` = @uL", db.getConnection());
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = NickEnter;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    string MyDock = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


                    ChekDID(NickEnter);




                    //if (!System.IO.Directory.Exists(MyDock + "\\Arma 3 - Other Profiles" + "\\" + NickEnter))
                    //{

                    //    var encryptedStringAES = Crypto.EncryptStringAES(NickEnter, SharedSecret);
                    //    using (StreamWriter stream = new StreamWriter(@"NickName.Arma3Profile"))
                    //    {
                    //        stream.WriteLine(encryptedStringAES);
                    //        stream.Close();
                    //    }
                    //    this.Hide();
                    //    MessageBox.Show("Ник успешно установлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //    //MessageBox.Show(MyDock + "\\Arma 3 - Other Profiles" + "\\" + NickEnter);
                    //    //MessageBox.Show(MyDock + "\\Arma 3 - Other Profiles" + "\\" + NickEnter + "\\" + NickEnter + ".Arma3Profile");
                    //    //MessageBox.Show(MyDock + "\\Arma 3 - Other Profiles" + "\\" + NickEnter + "\\" + NickEnter + ".vars.Arma3Profile");
                    //    //MessageBox.Show("Этот никнейм уже занят!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    //return;
                    //}
                    //else
                    //{
                    //    var encryptedStringAES = Crypto.EncryptStringAES(NickEnter, SharedSecret);
                    //    using (StreamWriter stream = new StreamWriter(@"NickName.Arma3Profile"))
                    //    {
                    //        stream.WriteLine(encryptedStringAES);
                    //        stream.Close();
                    //    }
                    //    this.Hide();
                    //    MessageBox.Show("Ник успешно установлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}

                }
                else
                {
                    var encryptedStringAES = Crypto.EncryptStringAES(NickEnter, SharedSecret);
                    using (StreamWriter stream = new StreamWriter(@"NickName.Arma3Profile"))
                    {
                        stream.WriteLine(encryptedStringAES);
                        stream.Close();
                    }
                    this.Close();
                    MessageBox.Show("Ник успешно установлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if(DID != "0")
            {
                if(DID == sMacAddress)
                {
                    var encryptedStringAES = Crypto.EncryptStringAES(NickName, SharedSecret);
                    using (StreamWriter stream = new StreamWriter(@"NickName.Arma3Profile"))
                    {
                        stream.WriteLine(encryptedStringAES);
                        stream.Close();
                    }
                    
                    MessageBox.Show("Ник успешно установлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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
                this.Close();
                MessageBox.Show("Ник успешно установлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Console.WriteLine("Ошибка!");
            }

            db.CloseConnection();
        }
        private void MyNick_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z')|| e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void EnterNick_Load(object sender, EventArgs e)
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
           
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
