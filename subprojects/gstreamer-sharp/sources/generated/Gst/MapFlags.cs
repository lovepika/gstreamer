// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.MapFlagsGType))]
	public enum MapFlags : uint {

		Read = 1,
		Write = 2,
		FlagLast = 65536,
	}

	internal class MapFlagsGType {
		[DllImport ("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_map_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_map_flags_get_type ());
			}
		}
	}
#endregion
}