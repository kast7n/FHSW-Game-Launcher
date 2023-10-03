using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Launcher.Web;

namespace Launcher.VersionChecker
{
    internal class VersionCheck
    {
        
        
        
        private string _VersionCheckUrl = "https://dl.fhsw-europe.com/version/"; // https://176.9.19.239/version/
        private string _LocalFHSWversion = "";
        private string _RemoteFHSWversion = "";
        private string _STversion = "";
        private string _Minimodversion = "";


        public VersionCheck()
        {
        }

        
        private string CheckLocalFHSWVersion()
        {
            string FHSWversion = "";
            // Read in the game directory from Options
            string mod_dir = "F:\\Program Files (x86)\\Battlefield 1942\\Mods\\FHSW\\"; //Modify

            // check if mod folder \Mods\FHSW exists, if yes open init.con, read "game.setCustomGameVersion 0.621"
            if (Directory.Exists(mod_dir))
            {
                var lines = File.ReadLines(mod_dir + "init.con");
                foreach (var line in lines)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        if (line.Contains("game.setCustomGameVersion"))
                        {
                            string[] temp = line.Split(' ');
                            FHSWversion = temp[1];
                            break;
                        }
                    }
                }
            }
            return FHSWversion;
        }
        public string CheckRemoteFHSWversion()
        {
            Trace.WriteLine("vchk: Line 74");
            Web.WebClient webClient = new Web.WebClient();
            //if (webClient.CheckURL(_VersionCheckUrl))
            //{
                string versions = "";
                try
                {
                    HttpWebRequest httpsRequest = (HttpWebRequest)WebRequest.Create(_VersionCheckUrl);
                    HttpWebResponse httpsResponse = (HttpWebResponse)httpsRequest.GetResponse();
                    if (httpsResponse != null)
                    {
                        Stream receiveStream = httpsResponse.GetResponseStream();
                        StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                        Trace.WriteLine("versions:" + readStream.ReadToEnd());
                        readStream.Close();
                        //if (httpsResponse.CharacterSet != null)
                        //    {
                        //        versions = httpsResponse.CharacterSet;
                        //        Trace.WriteLine("versions:" + versions);
                        //    }   
                    }
                    httpsResponse.Close();
                    
                }
                catch (WebException ex)
                {
                    // Do some exception here
                    Trace.WriteLine("Web Exception:" + ex.Message);
                }

            //}
            Trace.WriteLine("Returning 'test' to main:");
            return _RemoteFHSWversion = "test";
        }

        private void CheckMinimodVersion()
        {


        }

        private void CheckSTVersion()
        {

        }
    }
}
