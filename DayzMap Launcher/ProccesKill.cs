using System.Diagnostics;

namespace DayzMap_Launcher
{
    public class ProccesKill
    {
        public void procKill()
        {
            //WhatsApp.exe
            try
            {
                Process[] proc = Process.GetProcessesByName("WhatsApp");
                proc[0].Kill();
                proc[1].Kill();
                proc[2].Kill();
                proc[3].Kill();
                proc[4].Kill();
                proc[5].Kill();
            }
            catch
            {

            }
            //Discord.exe
            //try
            //{
            //    Process[] proc = Process.GetProcessesByName("Discord");
            //    proc[0].Kill();
            //    proc[1].Kill();
            //    proc[2].Kill();
            //    proc[3].Kill();
            //    proc[4].Kill();
            //    proc[5].Kill();
            //}
            //catch
            //{

            //}
            //Viber.exe
            try
            {
                Process[] proc = Process.GetProcessesByName("Viber");
                proc[0].Kill();
            }
            catch
            {

            }
            //raidcall.exe
            try
            {
                Process[] proc = Process.GetProcessesByName("raidcall");
                proc[0].Kill();
            }
            catch
            {

            }
            //Skype
            try
            {
                Process[] proc = Process.GetProcessesByName("Skype");
                proc[0].Kill();
                proc[1].Kill();
                proc[2].Kill();
                proc[3].Kill();
            }
            catch
            {

            }
        }
    }
}
