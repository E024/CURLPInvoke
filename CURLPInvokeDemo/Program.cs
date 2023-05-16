using AESTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CURLPInvokeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CurlStatus curlStatus = CurlStatus.Ok;

            string url = "https:/m.baidu.com/";

            WebHeaderCollection webHeader = new WebHeaderCollection();
            webHeader.Add("Content-Type", "application/json");
            webHeader.Add("Referer", url);
            webHeader.Add("Cookie", "cc=123;c2=123;");
            webHeader.Add("Accept-Encoding", "text/html");
            webHeader.Add("User-Agent", "Mozilla/6.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/111.0.0.0 Safari/537.36");

            var html = Easy.GetHtml(url, webHeader, ref curlStatus);
            Console.WriteLine(html);
            Console.ReadKey();
            url = "http://eth0.me";
            html = Easy.GetHtml(url, webHeader, ref curlStatus);
            Console.WriteLine(html);
            Console.ReadKey();

            //var url = "http://eth0.me";
            var postData = "{\"name\":\"John\", \"age\":30, \"city\":\"New York\"}";

            html = Easy.Post(url, postData, webHeader, ref curlStatus);
            Console.WriteLine(html);
            Console.ReadKey();




            Easy.CleanupMe();
        }
    }
}
