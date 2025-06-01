//===================================================================================================
// Project Name  : iit SDK For MVC Core DLL
// Program Name  : iitSystenmTools.cs
// Description   : iit Web SDK 中公用函數
// Version		 : Ver 1.0.0.0
// Create Author : Golden Jiang 2025/05/29 14:30 建立於 D:\Golden\TSB2\Product\iit SDK For Win-Web\iitToolsWeb 目錄
// Update Record :
// Note          :
//===================================================================================================
//---------------------------------------------------------------------------------------------------
// declare package
//---------------------------------------------------------------------------------------------------
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using iitSystemWeb;
using iitDataWeb;
using iitLogWeb;
using iitMSGWeb;
//---------------------------------------------------------------------------------------------------
// Program Area
//---------------------------------------------------------------------------------------------------
namespace iitToolsWeb
{
    public class iitSystemTools
    {
        public static void SystemStart( IConfiguration config )
        {
            if( Static.config == null )
            {
                lock( Static._lock )
                {
                    Static.config = config;
                    Static.SystemName = GetSystemName( Static.config );
                    Static.HostIP = GetHostIP();
                    //
                    Static.Log.LogDirectory = Static.config[ "iitLog:iLogDirectory" ];
                    if (Static.Log.LogDirectory == null)
                        Static.Log.LogDirectory = AppDomain.CurrentDomain.BaseDirectory;

                    Static.Log.DebugMust = Static.config[ "iitLog:iLogMust" ];

                    Static.Log.PrefixLogFileName = Static.config[ "iitLog:iLogFileName" ];

                    Static.Log.DebugLog = Static.config[ "iitLog:iLogDebug" ];

                    if( Static.config[ "iitLog:iLogLevel" ] != null )
                        Static.Log.LogLevel = Convert.ToInt32( Static.config[ "iitLog:iLogLevel" ] );
                    else
                        Static.Log.LogLevel = iitConst.LOG.LEVEL_LOWEST;

                    Static.Log.LogReady = false;

                    //Static.httpContextAccessor.HttpContext.Items[ "ClientIP" ] = "::1";
                } // end of lock (Static._lock)
            } // end of if (Static.config == null)

            // 初始化系統公用訊息
            iitMSG.Start();

            Static.SystemStartMesage = $"WebAPI System Start at {DateTime.Now.ToString( "yyyy/MM/dd HH:mm:ss.fff" )}";
        } // end of public static void InitStatic( IConfiguration config, ...)
         
        public static string GetSystemName( IConfiguration _config )
        {
            return _config[ "System:SystemName" ];
        } // end of GetSystemName()
        //
        public static void SetClientIP( IHttpContextAccessor httpContextAccessor )
        {
            //Static.httpContextAccessor = httpContextAccessor;
            httpContextAccessor.HttpContext.Items[ "ClientIP" ] = httpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();
        } // end of GetClientIP( ... )
        //
        public static string GetHostIP()
        {
            string ReturnValue = "";
            //
            try
            {
                IPHostEntry iphostentry = Dns.GetHostEntry(Dns.GetHostName());    // 取得本機的IpHostEntry類別實體，MSDN建議新的用法
                                                                                  //
                foreach( IPAddress ipaddress in iphostentry.AddressList )          // 檢查所有 IP 位址
                {
                    if( ipaddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork )  // 只取得IP V4的Address
                    {
                        ReturnValue = ipaddress.ToString();
                        break;
                    } // end of if( ipaddress.AddressFamily ... )
                } // end of foreach( IPAddress ipaddress in iphostentry.AddressList )   
            } // end of try
            catch
            {
            } // end of catch
              //
            return ReturnValue;
        } // end of GetHostIP( ... )
    } // end of public class iitSystemTools
} // end of namespace iitToolsWeb
//===================================================================================================
// End of iitToolsWeb.cs
//===================================================================================================
