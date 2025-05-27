//===================================================================================================
// Project Name  : iit SDK For MVC Core DLL
// Program Name  : iitSystemWeb.cs
// Description   : iit Web SDK 中處理系統和環境
// Version		 : Ver 1.0.0.0
// Create Author : Golden Jiang 2025/05/22 15:40 建立於 D:\Golden\TSB2\Product\iit SDK For Win-Web\iitSystemWeb 目錄
// Update Record :
// Note          :
//===================================================================================================
//---------------------------------------------------------------------------------------------------
// declare package
//---------------------------------------------------------------------------------------------------
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
//---------------------------------------------------------------------------------------------------
// Program Area
//---------------------------------------------------------------------------------------------------
namespace iitSystemWeb
{
    public class iitConst
    {
        public class LOG
        {
            public const int        MAX_LOG_QUEUE = 4096;
            public const int        MAX_LOG_QUEUE1 = 4096;
//
            public const int        LEVEL_LOWEST = 0;
            public const int        LEVEL_1 = 1;
            public const int        LEVEL_2 = 2;
            public const int        LEVEL_3 = 3;
            public const int        LEVEL_4 = 4;
            public const int        LEVEL_HIGHEST = 5;
            public const int        LEVEL_DEBUG = -1;
//
            public const bool       DISPLAY_YES = true;
            public const bool       DISPLAY_NO = false;
//
            public const bool       LOG_BACK_YES = true;
            public const bool       LOG_BACK_NO = false;
//
            public const bool       DEBUG_LOG_YES = true;
            public const bool       DEBUG_LOG_NO = false;
//
//            public const string     DEBUG   = "DEBUG";
            public const string     INFO    = "INFO";
            public const string     WARN    = "WARN";
            public const string     ERROR   = "ERROR";
            public const string     CRITIAL = "CRITIAL";
            public const string     OFF     = "OFF";
        } // end of LOG
    } // end of public class iitConst
    //
    public class ProgramInfo
    { 
        public static string  ProgramVersion = "V1.0";
    }
    //
    public class APISuccess
    {
        public const string A0000   =   "交易成功";       
    }
    //
    public class Static
    {
        public static object _lock = new object(); 
        public static string SystemName = "";
        public static string HostIP = "";
        public static string ClientIP = "";
        public static IConfiguration config = null;
        public static IHttpContextAccessor httpContextAccessor = null;
//
        public class Log
        {
            public static string  LogDirectory { get; set; }
            public static string  PrefixLogFileName { get; set; }
            public static string  DebugMust {  get; set; }
            public static string  DebugLog {  get; set; }
            public static int     LogLevel { get; set; }
        } // end of public class Log
    } // end of public class Static
} // end of namespace iitSystemWeb
//===================================================================================================
// End of iitSystemWeb.cs
//===================================================================================================
