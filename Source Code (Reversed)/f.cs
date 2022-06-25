using System;
using System.Windows.Forms;
using Lean.Forms;

internal static class f
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		Application.Run(new Main());
	}
}
