using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace DayzMap_Launcher
{
    public class RebootAddons
    {
        public string[] dllFile;
        public string GameVersion;
        WebClient webClient = new WebClient();
        public void Reboot(string dirArm3)
        {
            dllFile = File.ReadAllLines(dirArm3 + "/" + "Launcher directory.dll", Encoding.UTF8);
            GameVersion = dllFile[0];
            var GameVersionServer = webClient.DownloadString("https://game-programmer.ru/GameFiles/GlobalVersion.config");
            if (GameVersion != GameVersionServer)
            {
                string link2 = @"https://game-programmer.ru/GameFiles/RebootAddons.ini";
                WebClient webClient2 = new WebClient();
                webClient2.DownloadFileAsync(new Uri(link2), "RebootAddons.ini");
                Thread.Sleep(1000);

                string[] RebootAddons = File.ReadAllLines(@"RebootAddons.ini", Encoding.UTF8);
                for (int i = 0; i < RebootAddons.Length; i++)
                {

                    if (System.IO.File.Exists(dirArm3 + "/" + "@Elysium" + "/" + "addons" + "/" + RebootAddons[i]))
                        File.Delete(dirArm3 + "/" + "@Elysium" + "/" + "addons" + "/" + RebootAddons[i]);
                }
                using (StreamWriter stream = new StreamWriter(dirArm3 + "/" + "Launcher directory.dll"))
                {
                    stream.Write(GameVersionServer);
                    stream.Close();
                }
            }
        }
    }
}
