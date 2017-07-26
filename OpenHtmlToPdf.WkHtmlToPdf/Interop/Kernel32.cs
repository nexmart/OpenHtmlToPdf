using System;
using System.Runtime.InteropServices;

namespace OpenHtmlToPdf.WkHtmlToPdf.Interop
{
    static class Kernel32
    {
        [DllImport("kernel32", SetLastError = true)]
        public static extern bool FreeLibrary(IntPtr hModule);

        [DllImport("kernel32", SetLastError = true)]
        public static extern IntPtr LoadLibraryW([MarshalAs(UnmanagedType.LPWStr)]string lpFileName);
    }
}