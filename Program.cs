/*
 * Created with SharpDevelop 3.
 * User: F. Phoenix
 * Date: 09.11.2011
 * Time: 18:11
 * 
 */
using System;
using System.Windows.Forms;

namespace Wesnoth_PO_Sorter
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
