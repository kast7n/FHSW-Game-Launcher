/*
Stage 1: Download/Update FHSW-all-in-one, FHSW-Europe-Mappacks, S&T pack
Stage 2: Individual maps
Stage 5: Download/Update FHSW-Europe-Minimod

What is an "update": Download and install if client_version < server_version
Hence separate functionality of "update" to atomic methods (= save bandwidth):
 1. Check if there's a new version 
 2. If yes, download 
 3. Install it, overwrite the files - this will be in a separate installation-relate class


BF1942 + patches (widescreen patch) + master server patch + 4GB patch
FH0.7
FH fan mappack #6 
--
FHSW base mod
---
FHSW Europe minimod: maps/stuff, delete SSMs files if any in map folder
---
Extras: 
	S&T pack
	Event/CM mappacks
	HD graphics mod 
	zoom mod
Extras: BFP, Siege, BF1918, EOD, DC, FCD, ... whatever
---
First 3: install initially by installer. 
FHSW base mod would get installed and if installed it 'd get updated. 
Our minimod would get installed and if already installed update it. 
Extras are selectable in options.



FHSW file names:
 FHSW_v0.621.zip -> FHSW v0.621 Setup.exe
 FHSW_v0.611.zip -> FHSW v0.611 Setup.exe
 FHSW_v0.61_Patch.exe
 FHSW_v0.6_Setup_Part_1 / 2.exe
*/

using System;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text.RegularExpressions;
using static System.IO.File;
using Launcher.VersionChecker;

namespace Launcher.Updater;

public class Update
	// Will need to utilize functionality of BusyForm.cs from FH2 for asynch loading to allow cancelling download when user decides to.
{
    public Update()
	{

	}
	

    private void GetFilesOnServer()
	{
        Trace.WriteLine("updates: line 65");
        VersionCheck x = new VersionCheck();
        x.CheckRemoteFHSWversion();

        //string fhsw_base_url = "";
        //try
        //{

        //          Uri myUri = new Uri("http://www.contoso.com/");


        //          // Should use HttpClient here as below is deprecated
        //          HttpWebRequest request = (HttpWebRequest)WebRequest.Create(fhsw_base_url);
        //	using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        //	{
        //		using (StreamReader reader = new StreamReader(response.GetResponseStream()))
        //		{
        //			string html = reader.ReadToEnd();
        //			Regex regex = new Regex("<a href=\".*\">(?:.*)</a>");
        //			MatchCollection matches = regex.Matches(html);
        //			if (matches.Count > 0)
        //			{
        //                      foreach (Match match in matches)
        //				{
        //					if(match.Value != "../")
        //					{
        //                              this.version = (match.Groups["name"]).ToString();
        //                          }
        //				}
        //                  }
        //		}
        //	}
        //}
        //catch (Exception ex)
        //{
        //	this.version = ex.Message;
        //}


    }

	

    private void Download()
	{

	}

	private void UpdateFHSW() 
	{
		


	}

	public string StartUpdate()
	{
		//this.VersionCheck();
		//this.Download();
		//Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
		//Trace.AutoFlush = true;
		//Trace.Indent();

		//this.VersionCheck();
		this.GetFilesOnServer();

        Trace.WriteLine("Entering Main");
        return "Test";
    }



	// Else download FHSW = DownloadFHSW() and UpdateFHSW()
	//if (!Directory.Exists(mod_dir))
	//{

	//}
 


	
}
