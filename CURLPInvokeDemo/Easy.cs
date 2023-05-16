using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AESTest
{
    public static class Easy
    {
        static SafeCurlHandle safeCurl;
        static Easy()
        {
            safeCurl = Initialize();
            safeCurl.SetOpt(CurlOpt.SslVerifyPeer, false);
            safeCurl.SetOpt(CurlOpt.Useragent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/111.0.0.0 Safari/537.36");
            safeCurl.SetOpt(CurlOpt.AcceptEncoding, "text/html");
        }
        public static SafeCurlHandle Initialize()
        {
            var curlHandle = CurlNative.curl_easy_init();
            return new SafeCurlHandle(curlHandle);
        }

        public static string GetHtml(string url, WebHeaderCollection webHeader, ref CurlStatus status, WebProxy proxy = null)
        {
            safeCurl.SetOpt(CurlOpt.Url, url);
            safeCurl.SetOpt(CurlOpt.HttpGet, true);
            StringBuilder sb = new StringBuilder();
            safeCurl.SetOpt(CurlOpt.WriteData, IntPtr.Zero);




            //safeCurl.SetOpt(CurlOpt.Proxy, "192.168.100.182");
            //safeCurl.SetOpt(CurlOpt.ProxyPort, 808);
            //safeCurl.SetOpt(CurlOpt.HttpProxyTunnel, true);

            if (webHeader != null && webHeader.Count != 0)
            {
                IntPtr headers = IntPtr.Zero;
                foreach (string header in webHeader.AllKeys)
                {
                    headers = CurlNative.curl_slist_append(headers, $"{header}: {webHeader.Get(header)}");
                }
                safeCurl.SetOpt(CurlOpt.Httpheader, headers);
            }

            if (proxy != null)
            {
                safeCurl.SetOpt(CurlOpt.Proxy, proxy.Address.Host);
                safeCurl.SetOpt(CurlOpt.ProxyPort, proxy.Address.Port);
                safeCurl.SetOpt(CurlOpt.HttpProxyTunnel, true);
            }
            else
            {
                safeCurl.SetOpt(CurlOpt.Proxy, string.Empty);
                safeCurl.SetOpt(CurlOpt.ProxyPort, 0);
                safeCurl.SetOpt(CurlOpt.HttpProxyTunnel, false);
            }
            string result = string.Empty;
            CurlOpt.ReadWriteCallbackDelegate callback2 = (ptr, size, nMemB, userdata) =>
            {
                int len = size * nMemB;
                byte[] bytes = new byte[len];
                Marshal.Copy(ptr, bytes, 0, len);
                result += Encoding.UTF8.GetString(bytes);
                return len;
            };
            safeCurl.SetOpt(CurlOpt.WriteFunction, callback2);

            status = safeCurl.Perform();

            return result;
        }
        const int CURLFORM_COPYNAME = 1;
        const int CURLFORM_COPYCONTENTS = 4;
        const int CURLFORM_CONTENTTYPE = 14;
        const int CURLFORM_END = 18;
        public static string Post(string url, string data, WebHeaderCollection webHeader, ref CurlStatus status, WebProxy proxy = null)
        {
            safeCurl.SetOpt(CurlOpt.Url, url);
            safeCurl.SetOpt(CurlOpt.Post, true);
            //设置Post数据
            IntPtr postDataPtr = Marshal.StringToHGlobalAnsi(data);
            safeCurl.SetOpt(CurlOpt.Postfields, postDataPtr);

            if (webHeader != null && webHeader.Count != 0)
            {
                IntPtr headers = IntPtr.Zero;
                foreach (string header in webHeader.AllKeys)
                {
                    headers = CurlNative.curl_slist_append(headers, $"{header}: {webHeader.Get(header)}");
                }
                safeCurl.SetOpt(CurlOpt.Httpheader, headers);
            }


            if (proxy != null)
            {
                safeCurl.SetOpt(CurlOpt.Proxy, proxy.Address.Host);
                safeCurl.SetOpt(CurlOpt.ProxyPort, proxy.Address.Port);
                safeCurl.SetOpt(CurlOpt.HttpProxyTunnel, true);
            }
            else
            {
                safeCurl.SetOpt(CurlOpt.Proxy, string.Empty);
                safeCurl.SetOpt(CurlOpt.ProxyPort, 0);
                safeCurl.SetOpt(CurlOpt.HttpProxyTunnel, false);
            }

            string result = string.Empty;
            CurlOpt.ReadWriteCallbackDelegate callback2 = (ptr, size, nMemB, userdata) =>
            {
                int len = size * nMemB;
                byte[] bytes = new byte[len];
                Marshal.Copy(ptr, bytes, 0, len);
                result += Encoding.UTF8.GetString(bytes);
                return len;
            };
            safeCurl.SetOpt(CurlOpt.WriteFunction, callback2);

            status = safeCurl.Perform();

            return result;
        }

        public static void CleanupMe()
        {
            if (safeCurl != null)
            {
                Cleanup(safeCurl);
            }
        }

        public static CurlStatus SetOpt<TValue>(this SafeCurlHandle handle, CurlOpt<TValue> option, TValue value)
        {
            var curl = handle.GetUnsafeHandle();

            switch (value)
            {
                case string stringValue:
                    return CurlNative.curl_easy_setopt(curl, option.optionValue, stringValue);
                case bool boolValue:
                    return CurlNative.curl_easy_setopt(curl, option.optionValue, boolValue ? 1 : 0);
                case int intValue:
                    return CurlNative.curl_easy_setopt(curl, option.optionValue, intValue);
                case IntPtr handleValue:
                    return CurlNative.curl_easy_setopt(curl, option.optionValue, handleValue);
                case SafeCurlHandle curlHandleValue:
                    return CurlNative.curl_easy_setopt(curl, option.optionValue, curl);
                case CurlOpt.ReadWriteCallbackDelegate delegateValue:
                    return CurlNative.curl_easy_setopt(curl, option.optionValue, Marshal.GetFunctionPointerForDelegate(delegateValue));
                default:
                    throw new Exception($"Unsupported option: {option}");
            }
        }
        public static CurlStatus Perform(this SafeCurlHandle handle)
        {
            return CurlNative.curl_easy_perform(handle.GetUnsafeHandle());
        }
        public static void Cleanup(SafeCurlHandle handle)
        {
            CurlNative.curl_easy_cleanup(handle.GetUnsafeHandle());
        }
    }
}
