using System;
using System.Linq;
using Microsoft.Win32;

internal class d
{
	private string m_a;

	private string[] m_c = new string[7] { "Hardware\\Description\\System\\CentralProcessor\\0", "HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 0\\Target Id 0\\Logical Unit Id 0", "SYSTEM\\CurrentControlSet\\Control\\SystemInformation", "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\WindowsUpdate", "SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0001", "SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0012" };

	private string[,] m_d = new string[7, 7]
	{
		{ "SystemProductName", "Identifier", "Previous Update Revision", "ProcessorNameString", "VendorIdentifier", "Platform Specific Field1", "Component Information" },
		{ "SerialNumber", "Identifier", "SystemManufacturer", "nop", "nop", "nop", "nop" },
		{ "ComputerHardwareId", "ComputerHardwareIds", "BIOSVendor", "ProductId", "ProcessorNameString", "BIOSReleaseDate", "nop" },
		{ "ProductId", "InstallDate", "InstallTime", "nop", "nop", "nop", "nop" },
		{ "SusClientId", "nop", "nop", "nop", "nop", "nop", "nop" },
		{ "NetCfgInstanceId", "NetLuidIndex", "nop", "nop", "nop", "nop", "nop" },
		{ "NetworkAddress", "NetCfgInstanceId", "NetworkInterfaceInstallTimestamp", "nop", "nop", "nop", "nop" }
	};

	public void b()
	{
		this.m_a = "pBuU91Vl9qHzPee3zGd7";
		for (int j = 0; j < this.m_c.Length; j++)
		{
			c(j);
		}
	}

	private void c(int a)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(this.m_c[a], writable: true);
		if (registryKey != null)
		{
			for (int j = 0; j < this.m_d.GetLength(1) && !(this.m_d[a, j] == "nop"); j++)
			{
				registryKey.SetValue(this.m_d[a, j], this.m_a);
				this.m_a = "Gnaqk5MlQeuWinW2qQ4M";
			}
			registryKey.Close();
		}
	}
}
