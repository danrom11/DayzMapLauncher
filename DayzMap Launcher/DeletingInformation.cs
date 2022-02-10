using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayzMap_Launcher
{ 
    public class DeletingInformation
    {
        public string MyDock = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public void DeletingServerInformation(string Nick)
        {
            if (Nick != null || Nick != "" && Nick.Length > 0)
            {
                if (System.IO.File.Exists(MyDock + "\\Arma 3 - Other Profiles" + "\\" + Nick + "\\" + Nick + ".Arma3Profile"))
                {
                    var ipserver = File.ReadAllLines(MyDock + "\\Arma 3 - Other Profiles" + "\\" + Nick + "\\" + Nick + ".Arma3Profile", Encoding.Default).Where(s => !s.Contains("remoteIPAddress"));
                    File.WriteAllLines(MyDock + "\\Arma 3 - Other Profiles" + "\\" + Nick + "\\" + Nick + ".Arma3Profile", ipserver, Encoding.Default);

                    var remotePort = File.ReadAllLines(MyDock + "\\Arma 3 - Other Profiles" + "\\" + Nick + "\\" + Nick + ".Arma3Profile", Encoding.Default).Where(s => !s.Contains("remotePort"));
                    File.WriteAllLines(MyDock + "\\Arma 3 - Other Profiles" + "\\" + Nick + "\\" + Nick + ".Arma3Profile", remotePort, Encoding.Default);
                }
                else
                {
                    var ipserver = File.ReadAllLines(MyDock + "\\Arma 3" + "\\" + Nick + ".Arma3Profile", Encoding.Default).Where(s => !s.Contains("remoteIPAddress"));
                    File.WriteAllLines(MyDock + "\\Arma 3" + "\\" + Nick + ".Arma3Profile", ipserver, Encoding.Default);

                    var remotePort = File.ReadAllLines(MyDock + "\\Arma 3" + "\\" + Nick + ".Arma3Profile", Encoding.Default).Where(s => !s.Contains("remotePort"));
                    File.WriteAllLines(MyDock + "\\Arma 3" + "\\" + Nick + ".Arma3Profile", remotePort, Encoding.Default);
                }
            }            
        }
    }
}
