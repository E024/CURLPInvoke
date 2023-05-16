using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AESTest
{
    public class CurlOpt<TValue> : CurlOpt
    {
        public CurlOpt(int optionValue) : base(optionValue)
        {
        }
    }
    //id 在  https://github.com/curl/curl/blob/master/packages/OS400/curl.inc.in 可以找到对应
    public class CurlOpt
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

        public delegate int ReadWriteCallbackDelegate(IntPtr buf, int size, int nmemb, IntPtr userdata);

        public readonly int optionValue;

        public CurlOpt(int optionValue)
        {
            this.optionValue = optionValue;
        }

        // public static readonly CurlOpt<string> Url = new(10002);
        // public static readonly CurlOpt<ushort> Port = new(3);
        // public static readonly CurlOpt<int> Timeout = new(13);
        // public static readonly CurlOpt<bool> Post = new(47);

        public static readonly CurlOpt<bool> Verbose = new CurlOpt<bool>(41);
        public static readonly CurlOpt<bool> Header = new CurlOpt<bool>(42);
        public static readonly CurlOpt<bool> NoProgress = new CurlOpt<bool>(43);
        public static readonly CurlOpt<bool> NoSignal = new CurlOpt<bool>(99);

        public static readonly CurlOpt<bool> WildcardMatch = new CurlOpt<bool>(197);

        public static readonly CurlOpt<ReadWriteCallbackDelegate> WriteFunction = new CurlOpt<ReadWriteCallbackDelegate>(20011);
        public static readonly CurlOpt<IntPtr> WriteData = new CurlOpt<IntPtr>(10001);
        public static readonly CurlOpt<ReadWriteCallbackDelegate> ReadFunction = new CurlOpt<ReadWriteCallbackDelegate>(20012);
        public static readonly CurlOpt<IntPtr> ReadData = new CurlOpt<IntPtr>(10009);
        // public static readonly CurlOpt<TODO> IoctlFunction = new (20130); // [ioctl_callback ] - Deprecated option Callback for I/O operations. See CURLOPT_IOCTLFUNCTION
        public static readonly CurlOpt<IntPtr> IoctlData = new CurlOpt<IntPtr>(10131);
        // public static readonly CurlOpt<TODO> SeekFunction = new (20167); // [seek_callback ] - Callback for seek operations. See CURLOPT_SEEKFUNCTION
        public static readonly CurlOpt<IntPtr> SeekData = new CurlOpt<IntPtr>(10168);
        // public static readonly CurlOpt<TODO> SockOptFunction = new (20148); // [sockopt_callback ] - Callback for sockopt operations. See CURLOPT_SOCKOPTFUNCTION
        public static readonly CurlOpt<IntPtr> SockOptData = new CurlOpt<IntPtr>(10149);
        // public static readonly CurlOpt<TODO> OpenSocketFunction = new (20163); // [opensocket_callback ] - Callback for socket creation. See CURLOPT_OPENSOCKETFUNCTION
        public static readonly CurlOpt<IntPtr> OpenSocketData = new CurlOpt<IntPtr>(10164);
        // public static readonly CurlOpt<TODO> CloseSocketFunction = new (20208); // [closesocket_callback ] - Callback for closing socket. See CURLOPT_CLOSESOCKETFUNCTION
        public static readonly CurlOpt<IntPtr> CloseSocketData = new CurlOpt<IntPtr>(10209);
        // public static readonly CurlOpt<TODO> ProgressFunction = new (20056); // [progress_callback ] - OBSOLETE callback for progress meter. See CURLOPT_PROGRESSFUNCTION
        public static readonly CurlOpt<IntPtr> ProgressData = new CurlOpt<IntPtr>(10057);
        // public static readonly CurlOpt<TODO> XferInfoFunction = new (20219); // [progress_callback ] - Callback for progress meter. See CURLOPT_XFERINFOFUNCTION
        // public static readonly CurlOpt<TODO> HeaderFunction = new (20079); // [header_callback ] - Callback for writing received headers. See CURLOPT_HEADERFUNCTION
        public static readonly CurlOpt<IntPtr> HeaderData = new CurlOpt<IntPtr>(10029);
        // public static readonly CurlOpt<TODO> DebugFunction = new (20094); // [debug_callback ] - Callback for debug information. See CURLOPT_DEBUGFUNCTION
        public static readonly CurlOpt<IntPtr> DebugData = new CurlOpt<IntPtr>(10095);
        // public static readonly CurlOpt<TODO> SslCtxFunction = new (20108); // [ssl_ctx_callback ] - Callback for SSL context logic. See CURLOPT_SSL_CTX_FUNCTION
        public static readonly CurlOpt<IntPtr> SslCtxData = new CurlOpt<IntPtr>(10109);
        // public static readonly CurlOpt<TODO> ConvToNetworkFunction = new (20143); // [conv_callback ] - OBSOLETE Callback for code base conversion. See CURLOPT_CONV_TO_NETWORK_FUNCTION
        // public static readonly CurlOpt<TODO> ConvFromNetworkFunction = new (20142); // [conv_callback ] - OBSOLETE Callback for code base conversion. See CURLOPT_CONV_FROM_NETWORK_FUNCTION
        // public static readonly CurlOpt<TODO> ConvFromUtf8Function = new (20144); // [conv_callback ] - OBSOLETE Callback for code base conversion. See CURLOPT_CONV_FROM_UTF8_FUNCTION
        // public static readonly CurlOpt<TODO> InterleaveFunction = new (20196); // [interleave_callback ] - Callback for RTSP interleaved data. See CURLOPT_INTERLEAVEFUNCTION
        public static readonly CurlOpt<IntPtr> InterleaveData = new CurlOpt<IntPtr>(10195);
        // public static readonly CurlOpt<TODO> ChunkBgnFunction = new (20198); // [chunk_bgn_callback ] - Callback for wildcard download start of chunk. See CURLOPT_CHUNK_BGN_FUNCTION
        // public static readonly CurlOpt<TODO> ChunkEndFunction = new (20199); // [chunk_end_callback ] - Callback for wildcard download end of chunk. See CURLOPT_CHUNK_END_FUNCTION
        public static readonly CurlOpt<IntPtr> ChunkData = new CurlOpt<IntPtr>(10201);
        // public static readonly CurlOpt<TODO> FnmatchFunction = new (20200); // [fnmatch_callback ] - Callback for wildcard matching. See CURLOPT_FNMATCH_FUNCTION
        public static readonly CurlOpt<IntPtr> FnmatchData = new CurlOpt<IntPtr>(10202);
        public static readonly CurlOpt<bool> SuppressConnectHeaders = new CurlOpt<bool>(265);

        // public static readonly CurlOpt<TODO> ResolverStartFunction = new (20272); // [resolver_start_cb ] - Callback to be called before a new resolve request is started. See CURLOPT_RESOLVER_START_FUNCTION
        // public static readonly CurlOpt<TODO> ResolverStartData = new (10273); // [void *pointer] - Data pointer to pass to resolver start callback. See CURLOPT_RESOLVER_START_DATA
        // public static readonly CurlOpt<TODO> ErrorBuffer = new (10010); // [char *buf] - Error message buffer. See CURLOPT_ERRORBUFFER
        // public static readonly CurlOpt<TODO> Stderr = new (10037); // [FILE *stream] - stderr replacement stream. See CURLOPT_STDERR
        public static readonly CurlOpt<bool> FailOnError = new CurlOpt<bool>(45);
        public static readonly CurlOpt<bool> KeepSendingOnError = new CurlOpt<bool>(245);
        public static readonly CurlOpt<string> Url = new CurlOpt<string>(10002);
        public static readonly CurlOpt<bool> PathAsIs = new CurlOpt<bool>(234);

        // public static readonly CurlOpt<TODO> Protocols = new (181); // [long bitmask ] - Deprecated option Allowed protocols. See CURLOPT_PROTOCOLS
        // public static readonly CurlOpt<TODO> RedirectProtocols = new (182); // [long bitmask ] - Deprecated option Protocols to allow redirects to. See CURLOPT_REDIR_PROTOCOLS
        public static readonly CurlOpt<string> DefaultProtocol = new CurlOpt<string>(10238);
        public static readonly CurlOpt<string> Proxy = new CurlOpt<string>(10004);
        public static readonly CurlOpt<string> PreProxy = new CurlOpt<string>(10262);
        public static readonly CurlOpt<int> ProxyPort = new CurlOpt<int>(59);

        // public static readonly CurlOpt<TODO> ProxyType = new (101); // [long type ] - Proxy type. See CURLOPT_PROXYTYPE
        public static readonly CurlOpt<string> NoProxy = new CurlOpt<string>(10177);
        public static readonly CurlOpt<bool> HttpProxyTunnel = new CurlOpt<bool>(61);

        // public static readonly CurlOpt<TODO> ConnectTo = new (10243); // [struct curl_slist *connect_to] - Connect to a specific host and port. See CURLOPT_CONNECT_TO
        // public static readonly CurlOpt<TODO> Socks5Auth = new (267); // [long bitmask ] - Socks5 authentication methods. See CURLOPT_SOCKS5_AUTH
        public static readonly CurlOpt<string> Socks5GssapiService = new CurlOpt<string>(10179);

        // public static readonly CurlOpt<TODO> Socks5GssapiNec = new (180); // [long nec ] - Socks5 GSSAPI NEC mode. See CURLOPT_SOCKS5_GSSAPI_NEC
        public static readonly CurlOpt<string> ProxyServiceName = new CurlOpt<string>(10235);
        public static readonly CurlOpt<bool> HaProxyProtocol = new CurlOpt<bool>(274);
        public static readonly CurlOpt<string> ServiceName = new CurlOpt<string>(10236);
        public static readonly CurlOpt<string> Interface = new CurlOpt<string>(10062);

        public static readonly CurlOpt<int> LocalPort = new CurlOpt<int>(139);

        // public static readonly CurlOpt<TODO> LocalPortRange = new (140); // [long range ] - Bind connection locally to port range. See CURLOPT_LOCALPORTRANGE
        // public static readonly CurlOpt<TODO> DnsCacheTimeout = new (92); // [long age ] - Timeout for DNS cache. See CURLOPT_DNS_CACHE_TIMEOUT
        public static readonly CurlOpt<bool> DnsUseGlobalCache = new CurlOpt<bool>(91);
        public static readonly CurlOpt<string> DohUrl = new CurlOpt<string>(10279);
        public static readonly CurlOpt<int> BufferSize = new CurlOpt<int>(98);
        public static readonly CurlOpt<int> Port = new CurlOpt<int>(3);
        public static readonly CurlOpt<bool> TcpFastOpen = new CurlOpt<bool>(244);
        public static readonly CurlOpt<bool> TcpNoDelay = new CurlOpt<bool>(121);
        public static readonly CurlOpt<int> AddressScope = new CurlOpt<int>(171);
        public static readonly CurlOpt<bool> TcpKeepalive = new CurlOpt<bool>(213);
        public static readonly CurlOpt<int> TcpKeepIdle = new CurlOpt<int>(214);
        public static readonly CurlOpt<int> TcpKeepInterval = new CurlOpt<int>(215);
        public static readonly CurlOpt<string> UnixSocketPath = new CurlOpt<string>(10231);
        public static readonly CurlOpt<string> AbstractUnixSocket = new CurlOpt<string>(10264);

        // public static readonly CurlOpt<TODO> Netrc = new (51); // [long level ] - Enable .netrc parsing. See CURLOPT_NETRC
        public static readonly CurlOpt<string> NetrcFile = new CurlOpt<string>(10118);
        public static readonly CurlOpt<string> UserPassword = new CurlOpt<string>(10005);
        public static readonly CurlOpt<string> ProxyUserPassword = new CurlOpt<string>(10006);
        public static readonly CurlOpt<string> Username = new CurlOpt<string>(10173);
        public static readonly CurlOpt<string> Password = new CurlOpt<string>(10174);
        public static readonly CurlOpt<string> LoginOptions = new CurlOpt<string>(10224);
        public static readonly CurlOpt<bool> ProxyUsername = new CurlOpt<bool>(10175);
        public static readonly CurlOpt<bool> ProxyPassword = new CurlOpt<bool>(10176);

        // public static readonly CurlOpt<TODO> Httpauth = new (107); // [long bitmask ] - HTTP server authentication methods. See CURLOPT_HTTPAUTH
        public static readonly CurlOpt<string> TlsAuthUsername = new CurlOpt<string>(10204);
        public static readonly CurlOpt<string> ProxyTlsAuthUsername = new CurlOpt<string>(10251);
        public static readonly CurlOpt<string> TlsAuthPassword = new CurlOpt<string>(10205);
        public static readonly CurlOpt<string> ProxyTlsAuthPassword = new CurlOpt<string>(10252);
        public static readonly CurlOpt<string> TlsAuthType = new CurlOpt<string>(10206);
        public static readonly CurlOpt<string> ProxyTlsAuthType = new CurlOpt<string>(10253);

        // public static readonly CurlOpt<TODO> Proxyauth = new (111); // [long bitmask ] - HTTP proxy authentication methods. See CURLOPT_PROXYAUTH
        public static readonly CurlOpt<string> SaslAuthorized = new CurlOpt<string>(10289);
        public static readonly CurlOpt<bool> SaslIr = new CurlOpt<bool>(218);
        public static readonly CurlOpt<string> XOAuth2Bearer = new CurlOpt<string>(10220);

        // public static readonly CurlOpt<TODO> DisallowUsernameInUrl = new (278); // [long disallow ] - Do not allow username in URL. See CURLOPT_DISALLOW_USERNAME_IN_URL
        // public static readonly CurlOpt<TODO> Autoreferer = new (58); // [long autorefer ] - Automatically set Referer: header. See CURLOPT_AUTOREFERER
        public static readonly CurlOpt<string> AcceptEncoding = new CurlOpt<string>(10102);
        public static readonly CurlOpt<bool> TransferEncoding = new CurlOpt<bool>(207);
        public static readonly CurlOpt<bool> FollowLocation = new CurlOpt<bool>(52);
        public static readonly CurlOpt<bool> UnrestrictedAuth = new CurlOpt<bool>(105);
        public static readonly CurlOpt<int> MaxRedirects = new CurlOpt<int>(68);

        // public static readonly CurlOpt<TODO> Postredir = new (161); // [long bitmask ] - How to act on redirects after POST. See CURLOPT_POSTREDIR
        public static readonly CurlOpt<bool> Put = new CurlOpt<bool>(54);
        public static readonly CurlOpt<bool> Post = new CurlOpt<bool>(47);

        //string postData = "param1=value1&param2=value2";
        //IntPtr postDataPtr = Marshal.StringToHGlobalAnsi(postData);
        public static readonly CurlOpt<IntPtr> Postfields = new CurlOpt<IntPtr>(10015); // [char *postdata] - Send a POST with this data. See CURLOPT_POSTFIELDS
        public static readonly CurlOpt<int> PostFieldSize = new CurlOpt<int>(60);
        public static readonly CurlOpt<string> ContentType = new CurlOpt<string>(14);

        public static readonly CurlOpt<long> PostFieldSizeLarge = new CurlOpt<long>(30120);

        // public static readonly CurlOpt<TODO> Copypostfields = new (10165); // [char *data] - Send a POST with this data - and copy it. See CURLOPT_COPYPOSTFIELDS
        // public static readonly CurlOpt<TODO> Httppost = new (10024); // [struct curl_httppost *formpost] - Deprecated option Multipart formpost HTTP POST. See CURLOPT_HTTPPOST
        public static readonly CurlOpt<string> Referer = new CurlOpt<string>(10016);
        public static readonly CurlOpt<string> Useragent = new CurlOpt<string>(10018);
        public static readonly CurlOpt<string> CURLOPT_ACCEPT_ENCODING = new CurlOpt<string>(10018);

        // public static readonly CurlOpt<TODO> Httpheader = new (10023); // [struct curl_slist *headers] - Custom HTTP headers. See CURLOPT_HTTPHEADER
        public static readonly CurlOpt<IntPtr> Httpheader = new CurlOpt<IntPtr>(10023);
        // public static readonly CurlOpt<TODO> Headeropt = new (229); // [long bitmask ] - Control custom headers. See CURLOPT_HEADEROPT
        // public static readonly CurlOpt<TODO> Proxyheader = new (10228); // [struct curl_slist *headers] - Custom HTTP headers sent to proxy. See CURLOPT_PROXYHEADER
        // public static readonly CurlOpt<TODO> Http200Aliases = new (10104); // [struct curl_slist *aliases] - Alternative versions of 200 OK. See CURLOPT_HTTP200ALIASES
        public static readonly CurlOpt<string> Cookie = new CurlOpt<string>(10022);
        public static readonly CurlOpt<string> CookieFile = new CurlOpt<string>(10031);
        public static readonly CurlOpt<string> Cookiejar = new CurlOpt<string>(10082);

        // public static readonly CurlOpt<TODO> Cookiesession = new (96); // [long init ] - Start a new cookie session. See CURLOPT_COOKIESESSION
        public static readonly CurlOpt<string> CookieList = new CurlOpt<string>(10135);

        public static readonly CurlOpt<string> Altsvc = new CurlOpt<string>(10287);

        // public static readonly CurlOpt<TODO> AltsvcCtrl = new (286); // [long bitmask ] - Enable and configure Alt-Svc: treatment. See CURLOPT_ALTSVC_CTRL
        public static readonly CurlOpt<bool> HttpGet = new CurlOpt<bool>(80);

        // public static readonly CurlOpt<TODO> RequestTarget = new (10266); // [string ] - Set the request target. CURLOPT_REQUEST_TARGET
        // public static readonly CurlOpt<TODO> HttpVersion = new (84); // [long version ] - HTTP version to use. CURLOPT_HTTP_VERSION
        // public static readonly CurlOpt<TODO> Http09Allowed = new (285); // [long allowed ] - Allow HTTP/0.9 responses. CURLOPT_HTTP09_ALLOWED
        // public static readonly CurlOpt<TODO> IgnoreContentLength = new (136); // [long ignore ] - Ignore Content-Length. See CURLOPT_IGNORE_CONTENT_LENGTH
        public static readonly CurlOpt<bool> HttpContentDecoding = new CurlOpt<bool>(158);

        public static readonly CurlOpt<bool> HttpTransferDecoding = new CurlOpt<bool>(157);

        public static readonly CurlOpt<int> Expect100TimeoutMs = new CurlOpt<int>(227);

        // public static readonly CurlOpt<TODO> TrailerFunction = new (20283); // [curl_trailer_callback *func] - Set callback for sending trailing headers. See CURLOPT_TRAILERFUNCTION
        // public static readonly CurlOpt<TODO> TrailerData = new (10284); // [void *userdata] - Custom pointer passed to the trailing headers callback. See CURLOPT_TRAILERDATA
        public static readonly CurlOpt<bool> PipeWait = new CurlOpt<bool>(237);
        public static readonly CurlOpt<SafeCurlHandle> StreamDepends = new CurlOpt<SafeCurlHandle>(10240);
        public static readonly CurlOpt<SafeCurlHandle> StreamDependsE = new CurlOpt<SafeCurlHandle>(10241);
        public static readonly CurlOpt<int> StreamWeight = new CurlOpt<int>(239);
        public static readonly CurlOpt<string> MailFrom = new CurlOpt<string>(10186);

        // public static readonly CurlOpt<TODO> MailRcpt = new (10187); // [struct curl_slist *rcpts] - Address of the recipients. See CURLOPT_MAIL_RCPT
        public static readonly CurlOpt<string> MailAuth = new CurlOpt<string>(10217);
        public static readonly CurlOpt<bool> MailRcptAllowFails = new CurlOpt<bool>(290);
        public static readonly CurlOpt<int> TftpBlkSize = new CurlOpt<int>(178);
        public static readonly CurlOpt<bool> TftpNoOptions = new CurlOpt<bool>(242);
        public static readonly CurlOpt<string> FtpPort = new CurlOpt<string>(10017);

        // public static readonly CurlOpt<TODO> Quote = new (10028); // [struct curl_slist *cmds] - Commands to run before transfer. See CURLOPT_QUOTE
        // public static readonly CurlOpt<TODO> Postquote = new (10039); // [struct curl_slist *cmds] - Commands to run after transfer. See CURLOPT_POSTQUOTE
        // public static readonly CurlOpt<TODO> Prequote = new (10093); // [struct curl_slist *cmds] - Commands to run just before transfer. See CURLOPT_PREQUOTE
        public static readonly CurlOpt<bool> Append = new CurlOpt<bool>(50);
        public static readonly CurlOpt<bool> FtpUseEprt = new CurlOpt<bool>(106);
        public static readonly CurlOpt<bool> FtpUseEpsv = new CurlOpt<bool>(85);
        public static readonly CurlOpt<bool> FtpUsePret = new CurlOpt<bool>(188);

        // public static readonly CurlOpt<TODO> FtpCreateMissingDirs = new (110); // [long create ] - Create missing directories on the remote server. See CURLOPT_FTP_CREATE_MISSING_DIRS
        public static readonly CurlOpt<string> FtpAlternativeToUser = new CurlOpt<string>(10147);

        public static readonly CurlOpt<bool> FtpSkipPasvIp = new CurlOpt<bool>(137);

        // public static readonly CurlOpt<TODO> FtpSslAuth = new (129); // [long order ] - Control how to do TLS. See CURLOPT_FTPSSLAUTH
        // public static readonly CurlOpt<TODO> FtpSslCcc = new (154); // [long how ] - Back to non-TLS again after authentication. See CURLOPT_FTP_SSL_CCC
        public static readonly CurlOpt<string> FtpAccount = new CurlOpt<string>(10134);

        // public static readonly CurlOpt<TODO> FtpFileMethod = new (138); // [long method ] - Specify how to reach files. See CURLOPT_FTP_FILEMETHOD
        // public static readonly CurlOpt<TODO> RtspRequest = new (189); // [long request ] - RTSP request. See CURLOPT_RTSP_REQUEST
        public static readonly CurlOpt<string> RtspSessionId = new CurlOpt<string>(10190);
        public static readonly CurlOpt<string> RtspStreamUri = new CurlOpt<string>(10191);
        public static readonly CurlOpt<string> RtspTransport = new CurlOpt<string>(10192);
        public static readonly CurlOpt<int> RtspClientCSeq = new CurlOpt<int>(193);
        public static readonly CurlOpt<int> RtspServerCSeq = new CurlOpt<int>(194);
        public static readonly CurlOpt<bool> TransferText = new CurlOpt<bool>(53);
        public static readonly CurlOpt<bool> ProxyTransferMode = new CurlOpt<bool>(166);
        public static readonly CurlOpt<bool> Crlf = new CurlOpt<bool>(27);
        public static readonly CurlOpt<string> Range = new CurlOpt<string>(10007);
        public static readonly CurlOpt<int> ResumeFrom = new CurlOpt<int>(21);
        public static readonly CurlOpt<long> ResumeFromLarge = new CurlOpt<long>(30116);

        // public static readonly CurlOpt<TODO> Curlu = new (10282); // [void *pointer] - Set URL to work on with a URL handle. See CURLOPT_CURLU
        public static readonly CurlOpt<string> CustomRequest = new CurlOpt<string>(10036);
        public static readonly CurlOpt<bool> FileTime = new CurlOpt<bool>(69);
        public static readonly CurlOpt<bool> DirListOnly = new CurlOpt<bool>(48);
        public static readonly CurlOpt<bool> Nobody = new CurlOpt<bool>(44);
        public static readonly CurlOpt<int> InfileSize = new CurlOpt<int>(14);
        public static readonly CurlOpt<long> InFileSizeLarge = new CurlOpt<long>(30115);
        public static readonly CurlOpt<bool> Upload = new CurlOpt<bool>(46);

        public static readonly CurlOpt<int> UploadBufferSize = new CurlOpt<int>(280);

        // public static readonly CurlOpt<TODO> MimePost = new (10269); // [mime ] - Post/send MIME data. See CURLOPT_MIMEPOST
        public static readonly CurlOpt<int> MaxFileSize = new CurlOpt<int>(114);

        public static readonly CurlOpt<long> MaxFileSizeLarge = new CurlOpt<long>(30117);

        // public static readonly CurlOpt<TODO> Timecondition = new (33); // [long cond ] - Make a time conditional request. See CURLOPT_TIMECONDITION
        public static readonly CurlOpt<int> TimeValue = new CurlOpt<int>(34);
        public static readonly CurlOpt<long> TimeValueLarge = new CurlOpt<long>(30270);
        public static readonly CurlOpt<int> Timeout = new CurlOpt<int>(13);
        public static readonly CurlOpt<int> TimeoutMs = new CurlOpt<int>(155);
        public static readonly CurlOpt<int> LowSpeedLimit = new CurlOpt<int>(19);
        public static readonly CurlOpt<int> LowSpeedTime = new CurlOpt<int>(20);
        public static readonly CurlOpt<long> MaxSendSpeedLarge = new CurlOpt<long>(30145);
        public static readonly CurlOpt<long> MaxReceiveSpeedLarge = new CurlOpt<long>(30146);
        public static readonly CurlOpt<int> MaxConnects = new CurlOpt<int>(71);
        public static readonly CurlOpt<bool> FreshConnect = new CurlOpt<bool>(74);
        public static readonly CurlOpt<bool> ForbidReuse = new CurlOpt<bool>(75);
        public static readonly CurlOpt<int> MaxAgeConn = new CurlOpt<int>(288);
        public static readonly CurlOpt<int> ConnectTimeout = new CurlOpt<int>(78);
        public static readonly CurlOpt<int> ConnectTimeoutMs = new CurlOpt<int>(156);

        // public static readonly CurlOpt<TODO> Ipresolve = new (113); // [long resolve ] - IP version to use. See CURLOPT_IPRESOLVE
        public static readonly CurlOpt<bool> ConnectOnly = new CurlOpt<bool>(141);
        public static readonly CurlOpt<bool> UseSsl = new CurlOpt<bool>(119);

        // public static readonly CurlOpt<TODO> Resolve = new (10203); // [struct curl_slist *hosts] - Provide fixed/fake name resolves. See CURLOPT_RESOLVE
        public static readonly CurlOpt<string> DnsInterface = new CurlOpt<string>(10221);
        public static readonly CurlOpt<string> DnsLocalIp4 = new CurlOpt<string>(10222);
        public static readonly CurlOpt<string> DnsLocalIp6 = new CurlOpt<string>(10223);
        public static readonly CurlOpt<string> DnsServers = new CurlOpt<string>(10211);

        public static readonly CurlOpt<bool> DnsShuffleAddresses = new CurlOpt<bool>(275);

        public static readonly CurlOpt<int> AcceptTimeoutMs = new CurlOpt<int>(212);
        public static readonly CurlOpt<int> HappyEyeballsTimeoutMs = new CurlOpt<int>(271);
        public static readonly CurlOpt<int> UpkeepIntervalMs = new CurlOpt<int>(281);
        public static readonly CurlOpt<string> SslCCert = new CurlOpt<string>(10025);
        public static readonly CurlOpt<string> ProxySslCert = new CurlOpt<string>(10254);
        public static readonly CurlOpt<string> SslCertType = new CurlOpt<string>(10086);
        public static readonly CurlOpt<string> ProxySslCertType = new CurlOpt<string>(10255);
        public static readonly CurlOpt<string> SslKey = new CurlOpt<string>(10087);
        public static readonly CurlOpt<string> ProxySslKey = new CurlOpt<string>(10256);
        public static readonly CurlOpt<string> SslKeyType = new CurlOpt<string>(10088);
        public static readonly CurlOpt<string> ProxySslKeyType = new CurlOpt<string>(10257);
        public static readonly CurlOpt<string> KeyPasswd = new CurlOpt<string>(10026);
        public static readonly CurlOpt<string> ProxyKeyPasswd = new CurlOpt<string>(10258);
        public static readonly CurlOpt<bool> SslEnableAlpn = new CurlOpt<bool>(226);
        public static readonly CurlOpt<bool> SslEnableNpn = new CurlOpt<bool>(225);
        public static readonly CurlOpt<string> SslEngine = new CurlOpt<string>(10089);
        public static readonly CurlOpt<bool> SslEngineDefault = new CurlOpt<bool>(90);
        public static readonly CurlOpt<bool> SslFalseStart = new CurlOpt<bool>(233);

        // public static readonly CurlOpt<TODO> Sslversion = new (32); // [long version ] - SSL version to use. See CURLOPT_SSLVERSION
        // public static readonly CurlOpt<TODO> ProxySslversion = new (250); // [long version ] - Proxy SSL version to use. See CURLOPT_PROXY_SSLVERSION
        public static readonly CurlOpt<bool> SslVerifyHost = new CurlOpt<bool>(81);
        public static readonly CurlOpt<bool> ProxySslVerifyHost = new CurlOpt<bool>(249);
        public static readonly CurlOpt<bool> SslVerifyPeer = new CurlOpt<bool>(64);
        public static readonly CurlOpt<bool> ProxySslVerifyPeer = new CurlOpt<bool>(248);
        public static readonly CurlOpt<bool> SslVerifyStatus = new CurlOpt<bool>(232);
        public static readonly CurlOpt<string> CaInfo = new CurlOpt<string>(10065);
        public static readonly CurlOpt<string> ProxyCaInfo = new CurlOpt<string>(10246);
        public static readonly CurlOpt<string> IssuerCert = new CurlOpt<string>(10170);
        public static readonly CurlOpt<string> Capath = new CurlOpt<string>(10097);
        public static readonly CurlOpt<string> ProxyCapath = new CurlOpt<string>(10247);
        public static readonly CurlOpt<string> CrlFile = new CurlOpt<string>(10169);
        public static readonly CurlOpt<string> ProxyCrlFile = new CurlOpt<string>(10260);
        public static readonly CurlOpt<bool> CertInfo = new CurlOpt<bool>(172);
        public static readonly CurlOpt<string> PinnedPublicKey = new CurlOpt<string>(10230);
        public static readonly CurlOpt<string> ProxyPinnedPublicKey = new CurlOpt<string>(10263);
        public static readonly CurlOpt<string> RandomFile = new CurlOpt<string>(10076);
        public static readonly CurlOpt<string> EgdSocket = new CurlOpt<string>(10077);
        public static readonly CurlOpt<string> SslCipherList = new CurlOpt<string>(10083);
        public static readonly CurlOpt<string> ProxySslCipherList = new CurlOpt<string>(10259);
        public static readonly CurlOpt<string> Tls13Ciphers = new CurlOpt<string>(10276);
        public static readonly CurlOpt<string> ProxyTls13Ciphers = new CurlOpt<string>(10277);
        public static readonly CurlOpt<bool> SslSessionIdCache = new CurlOpt<bool>(150);

        // public static readonly CurlOpt<TODO> SslOptions = new (216); // [long bitmask ] - Control SSL behavior. See CURLOPT_SSL_OPTIONS
        // public static readonly CurlOpt<TODO> ProxySslOptions = new (261); // [long bitmask ] - Control proxy SSL behavior. See CURLOPT_PROXY_SSL_OPTIONS
        public static readonly CurlOpt<string> KrbLevel = new CurlOpt<string>(10063);

        // public static readonly CurlOpt<TODO> GssapiDelegation = new (210); // [long level ] - Disable GSS-API delegation. See CURLOPT_GSSAPI_DELEGATION
        // public static readonly CurlOpt<TODO> SshAuthTypes = new (151); // [long bitmask ] - SSH authentication types. See CURLOPT_SSH_AUTH_TYPES
        public static readonly CurlOpt<bool> SshCompression = new CurlOpt<bool>(268);
        public static readonly CurlOpt<string> SshHostPublicKeyMd5 = new CurlOpt<string>(10162);
        public static readonly CurlOpt<string> SshPublicKeyfile = new CurlOpt<string>(10152);
        public static readonly CurlOpt<string> SshPrivateKeyfile = new CurlOpt<string>(10153);

        public static readonly CurlOpt<string> SshKnownHosts = new CurlOpt<string>(10183);
        // public static readonly CurlOpt<TODO> SshKeyFunction = new (20184); // [ssh_keycallback ] - Callback for known hosts handling. See CURLOPT_SSH_KEYFUNCTION
        // public static readonly CurlOpt<TODO> SshKeyData = new (10185); // [void *pointer] - Custom pointer to pass to ssh key callback. See CURLOPT_SSH_KEYDATA
        // public static readonly CurlOpt<TODO> Private = new (10103); // [void *pointer] - Private pointer to store. See CURLOPT_PRIVATE
        // public static readonly CurlOpt<TODO> Share = new (10100); // [CURLSH *share] - Share object to use. See CURLOPT_SHARE
        // public static readonly CurlOpt<TODO> NewFilePerms = new (159); // [long mode ] - Mode for creating new remote files. See CURLOPT_NEW_FILE_PERMS
        // public static readonly CurlOpt<TODO> NewDirectoryPerms = new (160); // [long mode ] - Mode for creating new remote directories. See CURLOPT_NEW_DIRECTORY_PERMS
        // public static readonly CurlOpt<TODO> Telnetoptions = new (10070); // [struct curl_slist *cmds] - TELNET options. See CURLOPT_TELNETOPTIONS
    }
}
