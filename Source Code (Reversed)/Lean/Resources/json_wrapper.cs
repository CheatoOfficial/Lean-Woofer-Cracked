using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Lean.Resources
{
	public class json_wrapper
	{
		private DataContractJsonSerializer a;

		private object b;

		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), inherit: true);
		}

		public json_wrapper(object obj_to_work_with)
		{
			b = obj_to_work_with;
			Type type = b.GetType();
			a = new DataContractJsonSerializer(type);
			if (!is_serializable(type))
			{
				throw new Exception($"the object {b} isn't a serializable");
			}
		}

		public object string_to_object(string json)
		{
			DateTime dateTime = new DateTime(2022, 7, 8, 16, 41, 14);
			if ((!(dateTime < DateTime.Now)) ? true : false)
			{
			}
			byte[] bytes = Encoding.Default.GetBytes(json);
			using MemoryStream stream = new MemoryStream(bytes);
			return a.ReadObject((Stream)stream);
		}

		public T string_to_generic<T>(string json)
		{
			DateTime dateTime = new DateTime(2022, 7, 9, 1, 25, 58);
			if ((dateTime - DateTime.Now).TotalDays >= 0.0)
			{
			}
			return (T)string_to_object(json);
		}
	}
}
