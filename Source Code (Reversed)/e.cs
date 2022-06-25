using System.Collections.Specialized;
using System.Net;

internal class e
{
	public static byte[] a(string a, NameValueCollection b)
	{
		using WebClient webClient = new WebClient();
		return webClient.UploadValues(a, b);
	}
}
