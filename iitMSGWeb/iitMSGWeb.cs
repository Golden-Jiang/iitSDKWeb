//===================================================================================================
// Project Name  : iit SDK For ASP.NET Core DLL
// Program Name  : iitMSGWeb.cs
// Description   : iit Web SDK 中定義所有公用訊息
// Version		 : Ver 1.0.0.0
// Create Author : Golden Jiang 2025/05/24 20:30 建立於 D:\Golden\TSB2\Product\iit SDK For Win-Web\iitLogWeb 目錄
// Update Record :
// Note          :
//===================================================================================================
//---------------------------------------------------------------------------------------------------
// declare package
//---------------------------------------------------------------------------------------------------
//using iitSystemWeb;
//---------------------------------------------------------------------------------------------------
// Program Area
//---------------------------------------------------------------------------------------------------
namespace iitMSGWeb
{
    public partial class iitMSG
    {
        public static bool Start()
        {
            bool    ReturnValue = false;
            string  FunctionName = "iitMessage.cs->iit->iitMSG->Start() : ";
//
            try
            { 
                INITMSG     =   new Dictionary<string, string>();
                DESCMSG     =   new Dictionary<string, string>();
                HTTPMSG     =   new Dictionary<string, string>();
//
                INITMSG.Add( iitMSG.CODE.INIT.SYSTEM_START,                                 "程式啟動, 初始設定完成" );
                INITMSG.Add( iitMSG.CODE.INIT.SYSTEM_CLOSEING,                              "執行程式結束程序..." );
                INITMSG.Add( iitMSG.CODE.INIT.LOG_SERVICE_START,                            "LogService started" );
                INITMSG.Add( iitMSG.CODE.INIT.LOG_SERVICE_CLOSED,                           "LogService closed" );
                INITMSG.Add( iitMSG.CODE.INIT.HTTPSERVER_START,                             "iitHTTPServer started" );
                INITMSG.Add( iitMSG.CODE.INIT.HTTPSERVER_CLOSED,                            "iitHTTPServer closed" );
                INITMSG.Add( iitMSG.CODE.INIT.WEBSOCKET_SERVER_START,                       "iitWebSocketServer started" );
                INITMSG.Add( iitMSG.CODE.INIT.WEBSOCKET_SERVER_CLOSED,                      "iitWebSocketServer closed" );
                INITMSG.Add( iitMSG.CODE.INIT.CALLSERVER_START,                             "iitCallServer started" );
                INITMSG.Add( iitMSG.CODE.INIT.CALLSERVER_CLOSED,                            "iitCallServer closed" );
                INITMSG.Add( iitMSG.CODE.INIT.CALLNUMBER_START,                             "iitCallNumber started" );
                INITMSG.Add( iitMSG.CODE.INIT.CALLNUMBER_CLOSED,                            "iitCallNumber closed" );
                INITMSG.Add( iitMSG.CODE.INIT.CALLVOICE_START,                              "iitCallVoice started" );
                INITMSG.Add( iitMSG.CODE.INIT.CALLVOICE_CLOSED,                             "iitCallVoice closed" );
                INITMSG.Add( iitMSG.CODE.INIT.CALLTELLER_START,                             "iitCallTeller started" );
                INITMSG.Add( iitMSG.CODE.INIT.CALLTELLER_CLOSED,                            "iitCallTeller closed" );
                INITMSG.Add( iitMSG.CODE.INIT.IAGENT_START,                                 "iAgent started" );
                INITMSG.Add( iitMSG.CODE.INIT.IAGENT_CLOSED,                                "iAgent closed" );
//
                INITMSG.Add( iitMSG.CODE.INIT.SYSTEM_START_ERROR,                           "系統初始設定錯誤" );
                INITMSG.Add( iitMSG.CODE.INIT.PROGRAM_DUP_EXECUTE_ERROR,                    "程式將因重複執行執行而結束" );
                INITMSG.Add( iitMSG.CODE.INIT.LOG_ALREADY_START_ERROR,                      "LogService is already started" );
                INITMSG.Add( iitMSG.CODE.INIT.LOGTHREAD_START_ERROR,                        "LogThread start failure !" );
                INITMSG.Add( iitMSG.CODE.INIT.HTTPSERVER_ALREADY_START_ERROR,               "iitHTTPServer is already started" );
                INITMSG.Add( iitMSG.CODE.INIT.HTTPSERVER_START_ERROR,                       "iitHTTPServer start failure !" );
                INITMSG.Add( iitMSG.CODE.INIT.WEBSOCKET_SERVER_ALREADY_START_ERROR,         "iitWebSocketServer is already started" );
                INITMSG.Add( iitMSG.CODE.INIT.WEBSOCKET_SERVER_START_ERROR,                 "iitWebSocketServer start failure !" );
                INITMSG.Add( iitMSG.CODE.INIT.CALLSERVER_ALREADY_START_ERROR,               "iitCallServer is already started" );
                INITMSG.Add( iitMSG.CODE.INIT.CALLSERVER_THREAD_START_ERROR,                "iitCallServer Thread start failure !" );
                INITMSG.Add( iitMSG.CODE.INIT.CALLSERVER_START_ERROR,                       "iitCallServer start failure !" );
                INITMSG.Add( iitMSG.CODE.INIT.CALLNUMBER_ALREADY_START_ERROR,               "iitCallNumber is already started" );
                INITMSG.Add( iitMSG.CODE.INIT.CALLNUMBER_THREAD_START_ERROR,                "iitCallNumber Thread start failure !" );
                INITMSG.Add( iitMSG.CODE.INIT.CALLNUMBER_START_ERROR,                       "iitCallNumber start failure !" );
                INITMSG.Add( iitMSG.CODE.INIT.CALLVOICE_ALREADY_START_ERROR,                "iitCallVoice is already started" );
                INITMSG.Add( iitMSG.CODE.INIT.CALLVOICE_THREAD_START_ERROR,                 "iitCallVoice Thread start failure !" );
                INITMSG.Add( iitMSG.CODE.INIT.CALLVOICE_START_ERROR,                        "iitCallVoice start failure !" );
                INITMSG.Add( iitMSG.CODE.INIT.CALLTELLER_ALREADY_START_ERROR,               "iitCallTeller is already started" );
                INITMSG.Add( iitMSG.CODE.INIT.CALLTELLER_THREAD_START_ERROR,                "iitCallTeller Thread start failure !" );
                INITMSG.Add( iitMSG.CODE.INIT.CALLTELLER_START_ERROR,                       "iitCallTeller start failure !" );
                INITMSG.Add( iitMSG.CODE.INIT.IAGENT_ALREADY_START_ERROR,                   "iAgent is already started" );
                INITMSG.Add( iitMSG.CODE.INIT.IAGENT_THREAD_START_ERROR,                    "iAgent Thread start failure !" );
                INITMSG.Add( iitMSG.CODE.INIT.IAGENT_START_ERROR,                           "iAgent start failure !" );
                INITMSG.Add( iitMSG.CODE.INIT.READ_SERVICE_ERROR,                           "Read Service failure !" );
                DESCMSG.Add( iitMSG.CODE.INIT.DISPATCH_THREAD_START_ERROR,                  "Dispatch Thread start failure !" );
//
                DESCMSG.Add( iitMSG.CODE.DESC.LOGIN_NEW,                                    "New Login" );
                DESCMSG.Add( iitMSG.CODE.DESC.LOGIN_AGAIN,                                  "ReLogin" );
                DESCMSG.Add( iitMSG.CODE.DESC.LOGIN_ALREADY,                                "Already Login" );
                DESCMSG.Add( iitMSG.CODE.DESC.GET_NO_OK,                                    "Get No" );
                DESCMSG.Add( iitMSG.CODE.DESC.CALL_NO_OK,                                   "Call No" );
                DESCMSG.Add( iitMSG.CODE.DESC.CURRNTT_CALL_OK,                              "Receive Current Call" );
                DESCMSG.Add( iitMSG.CODE.DESC.SERVICENAME,                                  "Service Name" );
                DESCMSG.Add( iitMSG.CODE.DESC.SERVICEINFO_OK,                               "Receive Service Info" );
                DESCMSG.Add( iitMSG.CODE.DESC.PING_OK,                                      "Ping OK" );
//
                HTTPMSG.Add( iitMSG.CODE.HTTP.SUCCESS,                                      "交易成功" );
                HTTPMSG.Add( iitMSG.CODE.HTTP.UNKNOW_ERROR,                                 "UnKonw Error !" );
                HTTPMSG.Add( iitMSG.CODE.HTTP.OTHER_ERROR,                                  "System or other Error !" );
                HTTPMSG.Add( iitMSG.CODE.HTTP.SERVERNAME_ERROR,                             "ServerName Error !" );
                HTTPMSG.Add( iitMSG.CODE.HTTP.BRANCHID_NOT_FOUND,                           "Can not find argument [BranchID] !" );
                HTTPMSG.Add( iitMSG.CODE.HTTP.DEVICEID_NOT_FOUND,                           "Can not find argument [DeviceID] !" );
                HTTPMSG.Add( iitMSG.CODE.HTTP.FUNCCODE_NOT_FOUND,                           "Can not find argument [TxCode] !" );
                HTTPMSG.Add( iitMSG.CODE.HTTP.UNKNOW_FUNCCODE,                              "unKnow [TxCode] !" );
                HTTPMSG.Add( iitMSG.CODE.HTTP.DEVICEIP_NOT_FOUND,                           "Can not find argument [DeviceIP] !" );
                HTTPMSG.Add( iitMSG.CODE.HTTP.DEVICEPORT_NOT_FOUND,                         "Can not find argument [DevicePort] !" );
                HTTPMSG.Add( iitMSG.CODE.HTTP.SERVICEID_NOT_FOUND,                          "Can not find argument [ServiceID] !" );
                HTTPMSG.Add( iitMSG.CODE.HTTP.CHILDTYPE_NOT_FOUND,                          "Can not find argument [ChildType] !" );
                HTTPMSG.Add( iitMSG.CODE.HTTP.DEVICEPORT_ERROR,                             "[DevicePort] is not digit !" );
                HTTPMSG.Add( iitMSG.CODE.HTTP.CALLNO_NOT_FOUND,                             "Can not find argument [CallNo] !" );
                HTTPMSG.Add( iitMSG.CODE.HTTP.TELLNO_NOT_FOUND,                             "Can not find argument [TellerNo] !" );                
                HTTPMSG.Add( iitMSG.CODE.HTTP.HTTP_SERVERNAME_NOT_FOUND,                    "Can not find argument [HTTPServerName] !" );
                HTTPMSG.Add( iitMSG.CODE.HTTP.SERVICEID_NOT_EXIST,                          "Can not find ServiceID !" );
                HTTPMSG.Add( iitMSG.CODE.HTTP.CLIENT_NOT_LOGIN,                             "Client not Login !" );
                HTTPMSG.Add( iitMSG.CODE.HTTP.UNKNOW_HTTP_COMMAND,                          "Unknow HTTP Command !" );
                HTTPMSG.Add( iitMSG.CODE.HTTP.NOT_FOUND,                                    "Data not found" );
//
                ReturnValue =   true;
            } // end of try
            catch( Exception except )
            {
                throw new Exception( FunctionName + except.Message );
            } // end of catch
//
            return ReturnValue;
        } // end of Start()
//
        public static bool IsNullHTTPMSG( string Index )
        {
            bool    ReturnValue = true;
//
            try
            {
                if( ! String.IsNullOrEmpty( iitMSG.HTTPMSG[ Index ] ) )
                    ReturnValue =   false;
            } // end of try
            catch
            {
            } // end of catch
//
            return ReturnValue;
        } // end of IsNullHTTPMSG( ... )
    } // end of public partial class iitMSG
} // end of iitMSGWeb
//===================================================================================================
// End of iitMSMWeb.cs
//===================================================================================================
