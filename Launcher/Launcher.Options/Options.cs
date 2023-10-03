using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.Options
{

    public class OptionDirectory
    {
        static string directory = "";
        static string userName = "";

        public OptionDirectory()
        {
            try
            {
                var txtFile = File.OpenText("Settings.txt");
                string readDirectory = txtFile.ReadLine();
                string readName = txtFile.ReadLine();
                txtFile.Close();
                if (readDirectory != null) {    //might need fix
                    if (readDirectory.StartsWith("Game Directory"))
                    {
                        directory = readDirectory;
                        directory = directory.Remove(0, 15);
                    }
                    if (readName.StartsWith("Username"))
                    {
                        userName = readName;
                        userName = userName.Remove(0, 10);
                    }
                }
            }
            catch (Exception ex) when (ex is System.IO.FileNotFoundException || ex is System.NullReferenceException)
            {
                //Code to create file
                using (FileStream fs = File.Create("Settings.txt"))
                {
                }
            }
        }


        public static void exportOptions()
        { 
            string createDirectoryText = "Game Directory:" + directory + Environment.NewLine;
            string createUserNameText = "Username: " + userName + Environment.NewLine;
            File.WriteAllText("Settings.Txt", createDirectoryText + createUserNameText);
            
        }
        public static void setUsername(string tempUsername)
        {
            userName = tempUsername;
        }
        public string getUsername()
        {
            return userName;
        }
        public static void setDirectory(string tempDirectory)
        {
            directory = tempDirectory;
        }
        public string getDirectory()
        {
            return directory;
        }
    }
}

    

