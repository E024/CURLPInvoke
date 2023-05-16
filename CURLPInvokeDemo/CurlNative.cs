using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AESTest
{
    public static class CurlNative
    {
        private const string NativeLibrary = "libcurl-x64.dll";
        private const string NativeLibrary32 = "libcurl.dll";

        [DllImport(NativeLibrary, EntryPoint = "curl_easy_init", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr curl_easy_init64();
        [DllImport(NativeLibrary32, EntryPoint = "curl_easy_init", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr curl_easy_init32();
        public static IntPtr curl_easy_init()
        {
            if (Environment.Is64BitProcess)
            {
                return curl_easy_init64();
            }
            else
            {
                return curl_easy_init32();
            }
        }

        [DllImport(NativeLibrary, EntryPoint = "curl_easy_setopt", CallingConvention = CallingConvention.Cdecl)]
        private static extern CurlStatus curl_easy_setopt64(IntPtr curl, int option, string value);
        [DllImport(NativeLibrary32, EntryPoint = "curl_easy_setopt", CallingConvention = CallingConvention.Cdecl)]
        private static extern CurlStatus curl_easy_setopt32(IntPtr curl, int option, string value);
        public static CurlStatus curl_easy_setopt(IntPtr curl, int option, string value)
        {
            if (Environment.Is64BitProcess)
            {
                return curl_easy_setopt64(curl, option, value);
            }
            else
            {
                return curl_easy_setopt32(curl, option, value);
            }
        }

        [DllImport(NativeLibrary, EntryPoint = "curl_easy_setopt", CallingConvention = CallingConvention.Cdecl)]
        private static extern CurlStatus curl_easy_setopt64(IntPtr curl, int option, int value);
        [DllImport(NativeLibrary32, EntryPoint = "curl_easy_setopt", CallingConvention = CallingConvention.Cdecl)]
        private static extern CurlStatus curl_easy_setopt32(IntPtr curl, int option, int value);
        public static CurlStatus curl_easy_setopt(IntPtr curl, int option, int value)
        {
            if (Environment.Is64BitProcess)
            {
                return curl_easy_setopt64(curl, option, value);
            }
            else
            {
                return curl_easy_setopt32(curl, option, value);
            }
        }

        [DllImport(NativeLibrary, EntryPoint = "curl_easy_setopt", CallingConvention = CallingConvention.Cdecl)]
        private static extern CurlStatus curl_easy_setopt64(IntPtr curl, int option, IntPtr value);
        [DllImport(NativeLibrary32, EntryPoint = "curl_easy_setopt", CallingConvention = CallingConvention.Cdecl)]
        private static extern CurlStatus curl_easy_setopt32(IntPtr curl, int option, IntPtr value);
        public static CurlStatus curl_easy_setopt(IntPtr curl, int option, IntPtr value)
        {
            if (Environment.Is64BitProcess)
            {
                return curl_easy_setopt64(curl, option, value);
            }
            else
            {
                return curl_easy_setopt32(curl, option, value);
            }
        }




        [DllImport(NativeLibrary, EntryPoint = "curl_easy_perform", CallingConvention = CallingConvention.Cdecl)]
        private static extern CurlStatus curl_easy_perform64(IntPtr curl);
        [DllImport(NativeLibrary32, EntryPoint = "curl_easy_perform", CallingConvention = CallingConvention.Cdecl)]
        private static extern CurlStatus curl_easy_perform32(IntPtr curl);
        public static CurlStatus curl_easy_perform(IntPtr curl)
        {
            if (Environment.Is64BitProcess)
            {
                return curl_easy_perform64(curl);
            }
            else
            {
                return curl_easy_perform32(curl);
            }
        }

        [DllImport(NativeLibrary, EntryPoint = "curl_easy_cleanup", CallingConvention = CallingConvention.Cdecl)]
        private static extern void curl_easy_cleanup64(IntPtr curl);
        [DllImport(NativeLibrary32, EntryPoint = "curl_easy_cleanup", CallingConvention = CallingConvention.Cdecl)]
        private static extern void curl_easy_cleanup32(IntPtr curl);
        public static void curl_easy_cleanup(IntPtr curl)
        {
            if (Environment.Is64BitProcess)
            {
                curl_easy_cleanup64(curl);
            }
            else
            {
                curl_easy_cleanup32(curl);
            }
        }

        [DllImport(NativeLibrary, EntryPoint = "curl_formadd", CallingConvention = CallingConvention.Cdecl)]
        private static extern int curl_formadd64(ref IntPtr firstItem, ref IntPtr lastItem, int option, string name, IntPtr value, string contenttype, int end);
        [DllImport(NativeLibrary32, EntryPoint = "curl_formadd", CallingConvention = CallingConvention.Cdecl)]
        private static extern int curl_formadd32(ref IntPtr firstItem, ref IntPtr lastItem, int option, string name, IntPtr value, string contenttype, int end);
        public static int curl_formadd(ref IntPtr firstItem, ref IntPtr lastItem, int option, string name, IntPtr value, string contenttype, int end)
        {
            if (Environment.Is64BitProcess)
            {
                return curl_formadd64(ref firstItem, ref lastItem, option, name, value, contenttype, end);
            }
            else
            {
                return curl_formadd32(ref firstItem, ref lastItem, option, name, value, contenttype, end);
            }
        }

        [DllImport(NativeLibrary, EntryPoint = "curl_slist_append", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr curl_slist_append64(IntPtr list, string header);
        [DllImport(NativeLibrary32, EntryPoint = "curl_slist_append", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr curl_slist_append32(IntPtr list, string header);

        public static IntPtr curl_slist_append(IntPtr list, string header)
        {
            if (Environment.Is64BitProcess)
            {
                return curl_slist_append64(list, header);
            }
            else
            {
                return curl_slist_append32(list, header);
            }
        }

    }
}
