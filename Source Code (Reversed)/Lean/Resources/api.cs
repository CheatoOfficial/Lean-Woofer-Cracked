using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace Lean.Resources
{
	public class api
	{
		[DataContract]
		private class response_structure
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private bool a;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string c;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string d;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string e;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string f;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private user_data_structure g;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private app_data_structure h;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private List<msg> i;

			[DataMember]
			public bool success
			{
				[CompilerGenerated]
				get
				{
					return a;
				}
				[CompilerGenerated]
				set
				{
					a = value;
				}
			}

			[DataMember]
			public string sessionid
			{
				[CompilerGenerated]
				get
				{
					return b;
				}
				[CompilerGenerated]
				set
				{
					DateTime dateTime = default(DateTime).AddYears(2021).AddMonths(6).AddDays(7.8650462962963);
					if ((!(DateTime.Now > dateTime)) ? true : false)
					{
					}
					b = value;
				}
			}

			[DataMember]
			public string contents
			{
				[CompilerGenerated]
				get
				{
					DateTime dateTime = default(DateTime).AddYears(2021).AddMonths(6).AddDays(7.58689814814815);
					if ((!(dateTime < DateTime.Now)) ? true : false)
					{
					}
					return c;
				}
				[CompilerGenerated]
				set
				{
					c = value;
				}
			}

			[DataMember]
			public string response
			{
				[CompilerGenerated]
				get
				{
					return d;
				}
				[CompilerGenerated]
				set
				{
					d = value;
				}
			}

			[DataMember]
			public string message
			{
				[CompilerGenerated]
				get
				{
					return e;
				}
				[CompilerGenerated]
				set
				{
					e = value;
				}
			}

			[DataMember]
			public string download
			{
				[CompilerGenerated]
				get
				{
					return f;
				}
				[CompilerGenerated]
				set
				{
					f = value;
				}
			}

			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public user_data_structure info
			{
				[CompilerGenerated]
				get
				{
					return g;
				}
				[CompilerGenerated]
				set
				{
					g = value;
				}
			}

			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public app_data_structure appinfo
			{
				[CompilerGenerated]
				get
				{
					return h;
				}
				[CompilerGenerated]
				set
				{
					h = value;
				}
			}

			[DataMember]
			public List<msg> messages
			{
				[CompilerGenerated]
				get
				{
					return i;
				}
				[CompilerGenerated]
				set
				{
					i = value;
				}
			}
		}

		public class msg
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string a;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string c;

			public string message
			{
				[CompilerGenerated]
				get
				{
					return a;
				}
				[CompilerGenerated]
				set
				{
					a = value;
				}
			}

			public string author
			{
				[CompilerGenerated]
				get
				{
					return b;
				}
				[CompilerGenerated]
				set
				{
					b = value;
				}
			}

			public string timestamp
			{
				[CompilerGenerated]
				get
				{
					return c;
				}
				[CompilerGenerated]
				set
				{
					c = value;
				}
			}
		}

		[DataContract]
		private class user_data_structure
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string a;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string c;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string d;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string e;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private List<Data> f;

			[DataMember]
			public string username
			{
				[CompilerGenerated]
				get
				{
					return a;
				}
				[CompilerGenerated]
				set
				{
					DateTime dateTime = default(DateTime).AddYears(2021).AddMonths(6).AddDays(7.8078125);
					if ((dateTime - DateTime.Now).TotalDays >= 0.0)
					{
					}
					a = value;
				}
			}

			[DataMember]
			public string ip
			{
				[CompilerGenerated]
				get
				{
					DateTime dateTime = default(DateTime).AddYears(2021).AddMonths(6).AddDays(8.3121875);
					if ((DateTime.Now - dateTime).TotalDays <= 0.0)
					{
					}
					return b;
				}
				[CompilerGenerated]
				set
				{
					b = value;
				}
			}

			[DataMember]
			public string hwid
			{
				[CompilerGenerated]
				get
				{
					return c;
				}
				[CompilerGenerated]
				set
				{
					c = value;
				}
			}

			[DataMember]
			public string createdate
			{
				[CompilerGenerated]
				get
				{
					return d;
				}
				[CompilerGenerated]
				set
				{
					d = value;
				}
			}

			[DataMember]
			public string lastlogin
			{
				[CompilerGenerated]
				get
				{
					return e;
				}
				[CompilerGenerated]
				set
				{
					e = value;
				}
			}

			[DataMember]
			public List<Data> subscriptions
			{
				[CompilerGenerated]
				get
				{
					return f;
				}
				[CompilerGenerated]
				set
				{
					f = value;
				}
			}
		}

		[DataContract]
		private class app_data_structure
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string a;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string c;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string d;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string e;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string f;

			[DataMember]
			public string numUsers
			{
				[CompilerGenerated]
				get
				{
					return a;
				}
				[CompilerGenerated]
				set
				{
					a = value;
				}
			}

			[DataMember]
			public string numOnlineUsers
			{
				[CompilerGenerated]
				get
				{
					return b;
				}
				[CompilerGenerated]
				set
				{
					b = value;
				}
			}

			[DataMember]
			public string numKeys
			{
				[CompilerGenerated]
				get
				{
					return c;
				}
				[CompilerGenerated]
				set
				{
					c = value;
				}
			}

			[DataMember]
			public string version
			{
				[CompilerGenerated]
				get
				{
					return d;
				}
				[CompilerGenerated]
				set
				{
					d = value;
				}
			}

			[DataMember]
			public string customerPanelLink
			{
				[CompilerGenerated]
				get
				{
					return e;
				}
				[CompilerGenerated]
				set
				{
					e = value;
				}
			}

			[DataMember]
			public string downloadLink
			{
				[CompilerGenerated]
				get
				{
					return f;
				}
				[CompilerGenerated]
				set
				{
					f = value;
				}
			}
		}

		public class app_data_class
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string a;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string c;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string d;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string e;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string f;

			public string numUsers
			{
				[CompilerGenerated]
				get
				{
					return a;
				}
				[CompilerGenerated]
				set
				{
					a = value;
				}
			}

			public string numOnlineUsers
			{
				[CompilerGenerated]
				get
				{
					return b;
				}
				[CompilerGenerated]
				set
				{
					DateTime dateTime = new DateTime(2022, 7, 8);
					if ((dateTime - DateTime.Now).TotalDays < 0.0)
					{
						throw new ArgumentException();
					}
					b = value;
				}
			}

			public string numKeys
			{
				[CompilerGenerated]
				get
				{
					DateTime dateTime = default(DateTime).AddYears(2021).AddMonths(6).AddDays(7.55943287037037);
					if ((dateTime - DateTime.Now).TotalDays >= 0.0)
					{
					}
					return c;
				}
				[CompilerGenerated]
				set
				{
					c = value;
				}
			}

			public string version
			{
				[CompilerGenerated]
				get
				{
					return d;
				}
				[CompilerGenerated]
				set
				{
					d = value;
				}
			}

			public string customerPanelLink
			{
				[CompilerGenerated]
				get
				{
					return e;
				}
				[CompilerGenerated]
				set
				{
					e = value;
				}
			}

			public string downloadLink
			{
				[CompilerGenerated]
				get
				{
					return f;
				}
				[CompilerGenerated]
				set
				{
					f = value;
				}
			}
		}

		public class user_data_class
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string a;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string c;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string d;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string e;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private List<Data> f;

			public string username
			{
				[CompilerGenerated]
				get
				{
					return a;
				}
				[CompilerGenerated]
				set
				{
					a = value;
				}
			}

			public string ip
			{
				[CompilerGenerated]
				get
				{
					return b;
				}
				[CompilerGenerated]
				set
				{
					DateTime dateTime = default(DateTime).AddYears(2021).AddMonths(6).AddDays(7.84493055555556);
					if (DateTime.Now > dateTime || 1 == 0)
					{
						throw new ArgumentOutOfRangeException();
					}
					b = value;
				}
			}

			public string hwid
			{
				[CompilerGenerated]
				get
				{
					DateTime dateTime = default(DateTime).AddYears(2021).AddMonths(6).AddDays(7.63849537037037);
					if ((DateTime.Now - dateTime).TotalDays <= 0.0)
					{
					}
					return c;
				}
				[CompilerGenerated]
				set
				{
					c = value;
				}
			}

			public string createdate
			{
				[CompilerGenerated]
				get
				{
					return d;
				}
				[CompilerGenerated]
				set
				{
					d = value;
				}
			}

			public string lastlogin
			{
				[CompilerGenerated]
				get
				{
					return e;
				}
				[CompilerGenerated]
				set
				{
					e = value;
				}
			}

			public List<Data> subscriptions
			{
				[CompilerGenerated]
				get
				{
					return f;
				}
				[CompilerGenerated]
				set
				{
					f = value;
				}
			}
		}

		public class Data
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string a;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string c;

			public string subscription
			{
				[CompilerGenerated]
				get
				{
					return a;
				}
				[CompilerGenerated]
				set
				{
					DateTime dateTime = new DateTime(2022, 7, 8, 10, 5, 48);
					if ((dateTime - DateTime.Now).TotalDays >= 0.0)
					{
					}
					a = value;
				}
			}

			public string expiry
			{
				[CompilerGenerated]
				get
				{
					DateTime dateTime = new DateTime(2022, 7, 8);
					if (dateTime < DateTime.Now || 1 == 0)
					{
						throw new ArgumentException();
					}
					return b;
				}
				[CompilerGenerated]
				set
				{
					b = value;
				}
			}

			public string timeleft
			{
				[CompilerGenerated]
				get
				{
					return c;
				}
				[CompilerGenerated]
				set
				{
					c = value;
				}
			}
		}

		public class response_class
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private bool a;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;

			public bool success
			{
				[CompilerGenerated]
				get
				{
					return a;
				}
				[CompilerGenerated]
				set
				{
					a = value;
				}
			}

			public string message
			{
				[CompilerGenerated]
				get
				{
					DateTime dateTime = new DateTime(2022, 7, 8);
					if ((DateTime.Now - dateTime).TotalDays <= 0.0)
					{
					}
					return b;
				}
				[CompilerGenerated]
				set
				{
					DateTime dateTime = new DateTime(2022, 7, 8, 11, 10, 44);
					if ((dateTime - DateTime.Now).TotalDays >= 0.0)
					{
					}
					b = value;
				}
			}
		}

		public string name;

		public string ownerid;

		public string secret;

		public string version;

		private string m_a;

		private string m_b;

		private bool m_c;

		public app_data_class app_data = new app_data_class();

		public user_data_class user_data = new user_data_class();

		public response_class response = new response_class();

		private json_wrapper m_d = new json_wrapper(new response_structure());

		public static bool IsDebugRelease => true;

		public api(string name, string ownerid, string secret, string version)
		{
			if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version))
			{
				error("Security error, please reinstall the software!");
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		public void init()
		{
			this.m_b = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection
			{
				["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init")),
				["ver"] = encryption.encrypt(version, secret, text),
				["hash"] = checksum(Process.GetCurrentProcess().MainModule.FileName),
				["enckey"] = encryption.encrypt(this.m_b, secret, text),
				["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
				["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
				["init_iv"] = text
			};
			string text2 = a(nameValueCollection);
			if (text2 == "KeyAuth_Invalid")
			{
				MessageBox.Show("Missing dll files, extract whole folder", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Application.Exit();
			}
			text2 = encryption.decrypt(text2, secret, text);
			response_structure response_structure = this.m_d.string_to_generic<response_structure>(text2);
			d(response_structure);
			if (response_structure.success)
			{
				b(response_structure.appinfo);
				this.m_a = response_structure.sessionid;
				this.m_c = true;
			}
			else if (response_structure.message == "invalidver")
			{
				app_data.downloadLink = response_structure.download;
			}
		}

		public void Checkinit()
		{
			DateTime dateTime = new DateTime(2022, 7, 9);
			if (dateTime < DateTime.Now || 1 == 0)
			{
				throw new ArgumentException();
			}
			if (!this.m_c)
			{
				if (IsDebugRelease)
				{
					error("Security error, please reinstall the software! (2)");
				}
				else
				{
					error("Security error, please reinstall the software! (2)");
				}
			}
		}

		public void register(string username, string pass, string key)
		{
			DateTime dateTime = new DateTime(2022, 7, 9, 2, 22, 41);
			if ((!(DateTime.Now > dateTime)) ? true : false)
			{
			}
			Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection
			{
				["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register")),
				["username"] = encryption.encrypt(username, this.m_b, text),
				["pass"] = encryption.encrypt(pass, this.m_b, text),
				["key"] = encryption.encrypt(key, this.m_b, text),
				["hwid"] = encryption.encrypt(value, this.m_b, text),
				["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.m_a)),
				["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
				["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
				["init_iv"] = text
			};
			string message = a(nameValueCollection);
			message = encryption.decrypt(message, this.m_b, text);
			response_structure response_structure = this.m_d.string_to_generic<response_structure>(message);
			d(response_structure);
			if (response_structure.success)
			{
				c(response_structure.info);
			}
		}

		public void login(string username, string pass)
		{
			Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection
			{
				["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("login")),
				["username"] = encryption.encrypt(username, this.m_b, text),
				["pass"] = encryption.encrypt(pass, this.m_b, text),
				["hwid"] = encryption.encrypt(value, this.m_b, text),
				["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.m_a)),
				["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
				["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
				["init_iv"] = text
			};
			string message = a(nameValueCollection);
			message = encryption.decrypt(message, this.m_b, text);
			response_structure response_structure = this.m_d.string_to_generic<response_structure>(message);
			d(response_structure);
			if (response_structure.success)
			{
				c(response_structure.info);
			}
		}

		public void upgrade(string username, string key)
		{
			Checkinit();
			_ = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection
			{
				["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade")),
				["username"] = encryption.encrypt(username, this.m_b, text),
				["key"] = encryption.encrypt(key, this.m_b, text),
				["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.m_a)),
				["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
				["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
				["init_iv"] = text
			};
			string message = a(nameValueCollection);
			message = encryption.decrypt(message, this.m_b, text);
			response_structure response_structure = this.m_d.string_to_generic<response_structure>(message);
			response_structure.success = false;
			d(response_structure);
		}

		public void license(string key)
		{
			Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection
			{
				["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("license")),
				["key"] = encryption.encrypt(key, this.m_b, text),
				["hwid"] = encryption.encrypt(value, this.m_b, text),
				["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.m_a)),
				["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
				["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
				["init_iv"] = text
			};
			string message = a(nameValueCollection);
			message = encryption.decrypt(message, this.m_b, text);
			response_structure response_structure = this.m_d.string_to_generic<response_structure>(message);
			d(response_structure);
			if (response_structure.success)
			{
				c(response_structure.info);
			}
		}

		public void check()
		{
			Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection
			{
				["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("check")),
				["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.m_a)),
				["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
				["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
				["init_iv"] = text
			};
			string message = a(nameValueCollection);
			message = encryption.decrypt(message, this.m_b, text);
			response_structure response_structure = this.m_d.string_to_generic<response_structure>(message);
			d(response_structure);
		}

		public void setvar(string var, string data)
		{
			Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection
			{
				["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("setvar")),
				["var"] = encryption.encrypt(var, this.m_b, text),
				["data"] = encryption.encrypt(data, this.m_b, text),
				["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.m_a)),
				["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
				["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
				["init_iv"] = text
			};
			string message = a(nameValueCollection);
			message = encryption.decrypt(message, this.m_b, text);
			response_structure response_structure = this.m_d.string_to_generic<response_structure>(message);
			d(response_structure);
		}

		public string getvar(string var)
		{
			Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection
			{
				["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("getvar")),
				["var"] = encryption.encrypt(var, this.m_b, text),
				["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.m_a)),
				["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
				["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
				["init_iv"] = text
			};
			string message = a(nameValueCollection);
			message = encryption.decrypt(message, this.m_b, text);
			response_structure response_structure = this.m_d.string_to_generic<response_structure>(message);
			d(response_structure);
			if (response_structure.success)
			{
				return response_structure.response;
			}
			return null;
		}

		public void ban()
		{
			Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection
			{
				["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban")),
				["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.m_a)),
				["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
				["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
				["init_iv"] = text
			};
			string message = a(nameValueCollection);
			message = encryption.decrypt(message, this.m_b, text);
			response_structure response_structure = this.m_d.string_to_generic<response_structure>(message);
			d(response_structure);
		}

		public string var(string varid)
		{
			Checkinit();
			_ = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection
			{
				["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var")),
				["varid"] = encryption.encrypt(varid, this.m_b, text),
				["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.m_a)),
				["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
				["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
				["init_iv"] = text
			};
			string message = a(nameValueCollection);
			message = encryption.decrypt(message, this.m_b, text);
			response_structure response_structure = this.m_d.string_to_generic<response_structure>(message);
			d(response_structure);
			if (response_structure.success)
			{
				return response_structure.message;
			}
			return null;
		}

		public List<msg> chatget(string channelname)
		{
			Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection
			{
				["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatget")),
				["channel"] = encryption.encrypt(channelname, this.m_b, text),
				["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.m_a)),
				["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
				["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
				["init_iv"] = text
			};
			string message = a(nameValueCollection);
			message = encryption.decrypt(message, this.m_b, text);
			response_structure response_structure = this.m_d.string_to_generic<response_structure>(message);
			d(response_structure);
			if (response_structure.success)
			{
				return response_structure.messages;
			}
			return null;
		}

		public bool chatsend(string msg, string channelname)
		{
			Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection
			{
				["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatsend")),
				["message"] = encryption.encrypt(msg, this.m_b, text),
				["channel"] = encryption.encrypt(channelname, this.m_b, text),
				["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.m_a)),
				["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
				["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
				["init_iv"] = text
			};
			string message = a(nameValueCollection);
			message = encryption.decrypt(message, this.m_b, text);
			response_structure response_structure = this.m_d.string_to_generic<response_structure>(message);
			d(response_structure);
			if (response_structure.success)
			{
				return true;
			}
			return false;
		}

		public bool checkblack()
		{
			Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection
			{
				["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("checkblacklist")),
				["hwid"] = encryption.encrypt(value, this.m_b, text),
				["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.m_a)),
				["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
				["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
				["init_iv"] = text
			};
			string message = a(nameValueCollection);
			message = encryption.decrypt(message, this.m_b, text);
			response_structure response_structure = this.m_d.string_to_generic<response_structure>(message);
			d(response_structure);
			if (response_structure.success)
			{
				return true;
			}
			return false;
		}

		public string webhook(string webid, string param, string body = "", string conttype = "")
		{
			Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection
			{
				["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook")),
				["webid"] = encryption.encrypt(webid, this.m_b, text),
				["params"] = encryption.encrypt(param, this.m_b, text),
				["body"] = encryption.encrypt(body, this.m_b, text),
				["conttype"] = encryption.encrypt(conttype, this.m_b, text),
				["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.m_a)),
				["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
				["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
				["init_iv"] = text
			};
			string message = a(nameValueCollection);
			message = encryption.decrypt(message, this.m_b, text);
			response_structure response_structure = this.m_d.string_to_generic<response_structure>(message);
			d(response_structure);
			if (response_structure.success)
			{
				return response_structure.response;
			}
			return null;
		}

		public byte[] download(string fileid)
		{
			Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection
			{
				["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file")),
				["fileid"] = encryption.encrypt(fileid, this.m_b, text),
				["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.m_a)),
				["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
				["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
				["init_iv"] = text
			};
			string message = a(nameValueCollection);
			message = encryption.decrypt(message, this.m_b, text);
			response_structure response_structure = this.m_d.string_to_generic<response_structure>(message);
			d(response_structure);
			if (response_structure.success)
			{
				return encryption.str_to_byte_arr(response_structure.contents);
			}
			return null;
		}

		public void log(string message)
		{
			Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection
			{
				["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("log")),
				["pcuser"] = encryption.encrypt(Environment.UserName, this.m_b, text),
				["message"] = encryption.encrypt(message, this.m_b, text),
				["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.m_a)),
				["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
				["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
				["init_iv"] = text
			};
			a(nameValueCollection);
		}

		public static string checksum(string filename)
		{
			using MD5 mD = MD5.Create();
			using FileStream inputStream = File.OpenRead(filename);
			byte[] array = mD.ComputeHash(inputStream);
			return BitConverter.ToString(array).Replace("-", "").ToLowerInvariant();
		}

		public static void error(string message)
		{
			MessageBox.Show(message, "Lean Protection", MessageBoxButtons.OK);
			Environment.Exit(0);
		}

		private static string a(NameValueCollection a)
		{
			try
			{
				using WebClient webClient = new WebClient();
				byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.0/", a);
				return Encoding.Default.GetString(bytes);
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)ex.Response;
				HttpStatusCode statusCode = httpWebResponse.StatusCode;
				HttpStatusCode httpStatusCode = statusCode;
				if (httpStatusCode != (HttpStatusCode)429)
				{
					error("Connection failure, Try again!");
					Environment.Exit(0);
					return "";
				}
				error("You are connecting too fast to Woofer, please wait!");
				Environment.Exit(0);
				return "";
			}
		}

		private void b(app_data_structure a)
		{
			app_data.numUsers = a.numUsers;
			app_data.numOnlineUsers = a.numOnlineUsers;
			app_data.numKeys = a.numKeys;
			app_data.version = a.version;
			app_data.customerPanelLink = a.customerPanelLink;
		}

		private void c(user_data_structure a)
		{
			user_data.username = a.username;
			user_data.ip = a.ip;
			user_data.hwid = a.hwid;
			user_data.createdate = a.createdate;
			user_data.lastlogin = a.lastlogin;
			user_data.subscriptions = a.subscriptions;
		}

		public string expirydaysleft()
		{
			Checkinit();
			DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			TimeSpan timeSpan = dateTime - DateTime.Now;
			return Convert.ToString(timeSpan.Days + " Days " + timeSpan.Hours + " Hours Left");
		}

		private void d(response_structure a)
		{
			response.success = a.success;
			response.message = a.message;
		}
	}
}
