//===================================================================================================
// Project Name  : iit SDK For Windows DLL
// Program Name  : iitMSGDefine.cs
// Description   : iit Web SDK 中定義所有公用訊息
// Version		 : Ver 1.0.0.0
// Create Author : Golden Jiang 2025/05/24 20:30 建立於 D:\Golden\TSB2\Product\iit SDK For Win-Web\iitLogWeb 目錄
// Update Record :
// Note          :
//===================================================================================================
//---------------------------------------------------------------------------------------------------
// declare package
//---------------------------------------------------------------------------------------------------
//
// iit SDK For Windows 參考
//
//using iitSystemWeb;
//---------------------------------------------------------------------------------------------------
// Program Area
//---------------------------------------------------------------------------------------------------
namespace iitMSGWeb
{
    public partial class iitMSG
    {
        /// <summary>
        /// 查詢方式
        /// iitMSG.INITMSG[ iitMSG_CODE.INIT..... ]
        /// iitMSG.DESCMSG[ iitMSG_CODE.DESC..... ]
        /// iitMSG.HTTPMSG[ iitMSG_CODE.HTTP..... ]
        /// </summary>
        public partial class CODE
        {
            public class INIT
            {
                public const string SYSTEM_START                            = "N100001";    // 程式啟動, 初始設定完成
                public const string SYSTEM_CLOSEING                         = "N100002";    
                public const string LOG_SERVICE_START                       = "N100010";    
                public const string LOG_SERVICE_CLOSED                      = "N100011";    
                public const string HTTPSERVER_START                        = "N100020";    
                public const string HTTPSERVER_CLOSED                       = "N100021";    
                public const string WEBSOCKET_SERVER_START                  = "N100022";    
                public const string WEBSOCKET_SERVER_CLOSED                 = "N100023";    
                public const string CALLSERVER_START                        = "N100030";    
                public const string CALLSERVER_CLOSED                       = "N100031";    
                public const string CALLNUMBER_START                        = "N100040";    
                public const string CALLNUMBER_CLOSED                       = "N100041";    
                public const string CALLVOICE_START                         = "N100050";    
                public const string CALLVOICE_CLOSED                        = "N100051";    
                public const string CALLTELLER_START                        = "N100060";    
                public const string CALLTELLER_CLOSED                       = "N100061";    
                public const string IAGENT_START                            = "N100070";    
                public const string IAGENT_CLOSED                           = "N100071";    
//
                public const string SYSTEM_START_ERROR                      = "E100001";    // 系統初始設定錯誤
                public const string PROGRAM_DUP_EXECUTE_ERROR               = "E100002";    
                public const string LOG_ALREADY_START_ERROR                 = "E100010";    
                public const string LOGTHREAD_START_ERROR                   = "E100011";    
                public const string HTTPSERVER_ALREADY_START_ERROR          = "E100020";    
                public const string HTTPSERVER_START_ERROR                  = "E100021";    
                public const string WEBSOCKET_SERVER_ALREADY_START_ERROR    = "E100022";    
                public const string WEBSOCKET_SERVER_START_ERROR            = "E100023";    
                public const string CALLSERVER_ALREADY_START_ERROR          = "E100030";    
                public const string CALLSERVER_THREAD_START_ERROR           = "E100031";    
                public const string CALLSERVER_START_ERROR                  = "E100032";    
                public const string CALLNUMBER_ALREADY_START_ERROR          = "E100040";    
                public const string CALLNUMBER_THREAD_START_ERROR           = "E100041";    
                public const string CALLNUMBER_START_ERROR                  = "E100042";    
                public const string CALLVOICE_ALREADY_START_ERROR           = "E100050";    
                public const string CALLVOICE_THREAD_START_ERROR            = "E100051";    
                public const string CALLVOICE_START_ERROR                   = "E100052";    
                public const string CALLTELLER_ALREADY_START_ERROR          = "E100060";    
                public const string CALLTELLER_THREAD_START_ERROR           = "E100061";    
                public const string CALLTELLER_START_ERROR                  = "E100062";    
                public const string IAGENT_ALREADY_START_ERROR              = "E100070";    
                public const string IAGENT_THREAD_START_ERROR               = "E100071";    
                public const string IAGENT_START_ERROR                      = "E100072";
//                    
                public const string READ_SERVICE_ERROR                      = "E110001";    
                public const string DISPATCH_THREAD_START_ERROR             = "E120001";    
            } // end of INIT
//
            public class DESC
            {
                public const string LOGIN_NEW                               = "N200001";    
                public const string LOGIN_AGAIN                             = "N200002";    
                public const string LOGIN_ALREADY                           = "N200003";    
                public const string GET_NO_OK                               = "N200004";    
                public const string CALL_NO_OK                              = "N200005";  
                public const string CURRNTT_CALL_OK                         = "N200006";   
                public const string SERVICENAME                             = "N200007";    
                public const string SERVICEINFO_OK                          = "N200008";    
                public const string PING_OK                                 = "N200009";    
            } // end of DESC
//
            public class HTTP
            {
                public const string SUCCESS                     =   "0000";
                public const string UNKNOW_HTTP_COMMAND         =   "5990";
                public const string UNKNOW_FUNCCODE             =   "5991";
                public const string NOT_FOUND                   =   "5992";
                public const string OTHER_ERROR                 =   "5998";
                public const string UNKNOW_ERROR                =   "9999";
//
                public const string BRANCHID_NOT_FOUND          =   "5001";
                public const string DEVICEID_NOT_FOUND          =   "5002";
                public const string SERVICEID_NOT_FOUND         =   "5003";
                public const string CHILDTYPE_NOT_FOUND         =   "5004";
                public const string FUNCCODE_NOT_FOUND          =   "5005";
                public const string DEVICEIP_NOT_FOUND          =   "5006";
                public const string DEVICEPORT_NOT_FOUND        =   "5007";
                public const string CALLNO_NOT_FOUND            =   "5008";
                public const string TELLNO_NOT_FOUND            =   "5009";
                public const string HTTP_SERVERNAME_NOT_FOUND   =   "5010";
//
                public const string SERVERNAME_ERROR            =   "5101";
                public const string DEVICEPORT_ERROR            =   "5103";
//
                public const string SERVICEID_NOT_EXIST         =   "5201";
                public const string CLIENT_NOT_LOGIN            =   "5202";
            } // end of HTTP
        } // end of public partial class CODE
//
        public class APIError
        {
            public const string E1000   =   "未定義的 API";       
            public const string E1001   =   "遺失 GET 參數";        
            public const string E1002   =   "GET 參數錯誤";        
            public const string E2000   =   "資料不存在";        
            public const string E2001   =   "已超過當天取號次數";        
            public const string E2002   =   "取號失敗";        
            public const string E2003   =   "分行營業狀態為已休息中";        
            public const string E2004   =   "本日無取號記錄";        
            public const string E2005   =   "帳號不存在";        
            public const string E2006   =   "已超過每次預填單數";        
            public const string E2007   =   "分行目前為非營業中";        
            public const string E2008   =   "新增重複資料錯誤";        
            public const string E2009   =   "資料錯誤";        
            public const string E20091  =   "外幣帳號";        
            public const string E20092  =   "虛擬帳號";        
            public const string E2101   =   "超過次數";        
            public const string E3001   =   "登入失敗";        
            public const string E3002   =   "登入分行失敗";        
            public const string E3003   =   "登入分行失敗,不在人力支援表中";        
            public const string E8500   =   "API 作業愈時";        
            public const string E8501   =   "API 作業錯誤";        
        } // end of APIError
        public static Dictionary<string, string> INITMSG { get; private set; }
        public static Dictionary<string, string> DESCMSG { get; private set; }
        public static Dictionary<string, string> HTTPMSG { get; private set; }
    } // end of public partial class iitMSG
} // end of iitMSGWeb
//===================================================================================================
// End of iitMSGDefine.cs
//===================================================================================================
