using System;
using System.Runtime.InteropServices;

namespace Lean.Addons
{
	public class DiscordRpc
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void DisconnectedCallback(int errorCode, string message);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void ErrorCallback(int errorCode, string message);

		public struct EventHandlers
		{
			public ReadyCallback readyCallback;

			public DisconnectedCallback disconnectedCallback;

			public ErrorCallback errorCallback;
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void ReadyCallback();

		[Serializable]
		public struct RichPresence
		{
			public string state;

			public string details;

			public long startTimestamp;

			public long endTimestamp;

			public string largeImageKey;

			public string largeImageText;

			public string smallImageKey;

			public string smallImageText;

			public string partyId;

			public int partySize;

			public int partyMax;

			public string matchSecret;

			public string joinSecret;

			public string spectateSecret;

			public bool instance;
		}

		[DllImport("runtime.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Discord_Initialize(string applicationId, ref EventHandlers handlers, bool autoRegister, string optionalSteamId);

		[DllImport("runtime.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Discord_RunCallbacks();

		[DllImport("runtime.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Discord_Shutdown();

		[DllImport("runtime.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Discord_UpdatePresence(ref RichPresence presence);

		internal static void a(string a, ref object b, bool c, object d)
		{
			throw new NotImplementedException();
		}
	}
}
