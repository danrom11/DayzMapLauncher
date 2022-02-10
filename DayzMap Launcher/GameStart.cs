using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace DayzMap_Launcher
{
    public class GameStart
    {
        BootForm bootForm = new BootForm();
        string CpValue;
        string ThCpValue;
        string HtValue;
        string BlValue;
        string RamValue;
        string VmValue;
        public void Arma3Start(string[] dirParam, string nick)
        {
            string NickName = " -name=" + nick + " ";

            if (dirParam[1] != "0") { CpValue = " -cpuCount=" + dirParam[1]; } else { CpValue = ""; }

            if (dirParam[2] == "0") { ThCpValue = ""; }
            if (dirParam[2] == "1") { ThCpValue = " -malloc=tbb4malloc_bi"; }
            if (dirParam[2] == "2") { ThCpValue = " -malloc=jemalloc_bi"; }

            if (dirParam[3] == true.ToString()) { HtValue = " -enableHT"; } else { HtValue = ""; }

            if (dirParam[4] == true.ToString()) { BlValue = " -hugePages"; } else { BlValue = ""; }

            if (dirParam[5] != "0") { RamValue = " -maxMem=" + dirParam[5]; } else { RamValue = ""; }
            if (dirParam[6] != "0") { VmValue = " -maxVram=" + dirParam[6]; } else { VmValue = ""; }

           string GameDirFIX = dirParam[0].Replace(" ", "\" \"").Replace("\\", "/");
            using (StreamWriter stream = new StreamWriter(dirParam[0] + "/" + "START_Elysium_64bit.bat"))
            {
                stream.Write("start " + GameDirFIX + "/" + "arma3battleye.exe -win64 -nolauncher -nobenchmark -noPause -nosplash" + NickName + CpValue + ThCpValue + HtValue + BlValue + RamValue + VmValue + " -mod=@Elysium");
                stream.Close();
            }
            bootForm.Close();
        }
        string[] AddonsServer;
        string fileSizeSer;

        bool restartUp = false;
        public void CheckGameAddonsFiles(string[] dirParam)
        {
           bootForm.Show();
            AddonsServer = File.ReadAllLines(@"addons.ini", System.Text.Encoding.Default);
            for(int i = 0; i < AddonsServer.Length; i++)
            {
                FileInfo file = new FileInfo(dirParam[0] + "/" + "@Elysium" + "/" + "addons" + "/" + AddonsServer[i]);
                long sizeLoc = file.Length;
                //MessageBox.Show(sizeLoc.ToString() + " 1");

                var webRequest = HttpWebRequest.Create("https://game-programmer.ru/GameFiles/addons" + "/" + AddonsServer[i]);
                webRequest.Method = "HEAD";

                using (var webResponse = webRequest.GetResponse())
                {
                     fileSizeSer = webResponse.Headers.Get("Content-Length");
                  //  MessageBox.Show(fileSizeSer + " 2");
                    
                }
                if (sizeLoc.ToString() != fileSizeSer)
                {
                    try
                    {
                        File.Delete(dirParam[0] + "/" + "@Elysium" + "/" + "addons" + "/" + AddonsServer[i]);
                        restartUp = true;
                    }
                    catch
                    {

                    }
                }
            }
            if(restartUp == true)
            {
                MessageBox.Show("Обнаружены повреждённые файлы! Лаунчер будет автоматически перезагружен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
            }
        }

        public void ChekNickGame(string nick)
        {
            string MyDock = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (!System.IO.Directory.Exists(MyDock + "\\Arma 3 - Other Profiles" + "\\" + nick))
            {
                Directory.CreateDirectory(MyDock + "\\Arma 3 - Other Profiles" + "\\" + nick);
            }
            else
            {
                return;
            }
        }
    }
}
