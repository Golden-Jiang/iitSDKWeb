//===================================================================================================
// Project Name  : iit SDK For ASP.NET Core DLL
// Program Name  : iitLog.cs
// Description   : iit Web SDK 中處理程式執行記錄(使用依賴注入)
// Version		 : Ver 1.0.0.0
// Create Author : Golden Jiang 2025/06/01 13:30 建立於 D:\Golden\TSB2\Product\iitSDKWeb\iitLogWeb 目錄
// Update Record :
// Note          :
//===================================================================================================
//---------------------------------------------------------------------------------------------------
// declare package
//---------------------------------------------------------------------------------------------------
using Microsoft.AspNetCore.Http;
//
// iitSDKWeb
//
using iitSystemWeb;
using System.Runtime.CompilerServices;
//---------------------------------------------------------------------------------------------------
// Program Area
//---------------------------------------------------------------------------------------------------
namespace iitLogWeb
{
    public interface IiitLog
    {
        public string SystemName { get; set; }

        public string FunctionName { get; set; }

        public string FunctionEnterTime { get; set; }

        public int LogLevel { get; set; }

        public string LogType { get; set; }

        public string FunctionExitTime { get; set; }

        public string LogMessage { get; set; }

        public string HostIP { get; set; }

        public string ClientIP { get; set; }

        public Exception except { get; set; }

        //public abstract void WriteLog();
        public void WriteLog( string message, string LogType, int LogLevel, string ClinntIP,
                              [CallerMemberName] string memberName = "", 
                              [CallerFilePath] string filePath = "", 
                              [CallerLineNumber] int lineNumber = 0 );

        public void SaveLog( IiitLog log );
        public void ResetLog( IiitLog log );
    } // end of public interface IiitLog

    public class iitLog : IiitLog
    {
        public string SystemName { get; set; }

        public string FunctionName { get; set; }

        public string FunctionEnterTime { get; set; }

        public int LogLevel { get; set; }

        public string LogType { get; set; }

        public string FunctionExitTime { get; set; }

        public string LogMessage { get; set; }

        public string HostIP { get; set; }

        public string ClientIP { get; set; }

        public Exception except { get; set; }

        public iitLog() 
        { 
            this.SystemName = Static.SystemName;
            this.FunctionEnterTime = DateTime.Now.ToString( "yyyy/MM/dd HH:mm:ss.fff" );
            this.LogMessage = "";
            this.HostIP = "";
            this.ClientIP = "null";
            this.except = null;
        } // end of public LogClass()

        public void ResetLog( IiitLog iLog )
        {
            this.LogMessage = "";
            this.ClientIP = "null";
            this.except = null;
        }

        public void WriteLog( string LogMessage, string LogType, int LogLevel, string ClinntIP,
                            [System.Runtime.CompilerServices.CallerMemberName] string CallerName = "",
                            [System.Runtime.CompilerServices.CallerFilePath] string CallerSourceFile = "",
                            [System.Runtime.CompilerServices.CallerLineNumber] int CallerLineNumber = 0 )
        {
            try
            {
                this.FunctionName       =   Path.GetFileName( CallerSourceFile ) + "->" + CallerName + "()";
                this.LogLevel           =   LogLevel;
                this.LogType            =   LogType;                    // DEBUG, INFO, WARN, ERROR, CRITIAL, OFF
                this.FunctionExitTime   =   DateTime.Now.ToString( "yyyy/MM/dd HH:mm:ss.fff" );
                 
                if( LogMessage.Length > 0 )
                    this.LogMessage     =   this.LogMessage + LogMessage;
                
                this.HostIP             =   Static.HostIP;
                this.ClientIP           =   ClinntIP;
                 
                SaveLog( this );

                ResetLog( this );
            } // end of try
            catch
            {
            } // end of catch
        } // end of WriteLog( ... )
         
        public void SaveLog( IiitLog iLog )
        {
            bool LogMust = false;
            string[] DebugMustFunction;
            DateTime TmpDateTime;
            string LogFileName, FuncMessage;

            try
            {
                TmpDateTime = DateTime.Now;

                if (Static.Log.DebugMust != null)
                {
                    DebugMustFunction = Static.Log.DebugMust.Split(',');

                    foreach (string ss in DebugMustFunction)
                    {
                        if (iLog.FunctionName.Contains(ss))
                        {
                            LogMust = true;
                            break;
                        } // end of if( iLog.FunctionName.IndexOf( ss ) >= 0 )
                    } // end of foreach( string ss in DebugMustFunction )
                } // end of if (DebugMust != null)

                if (Static.Log.PrefixLogFileName != null)
                    LogFileName = Static.Log.PrefixLogFileName + TmpDateTime.ToString("yyyyMMdd") + ".Log";
                else
                    LogFileName = "iLog" + TmpDateTime.ToString("yyyyMMdd") + ".Log";

                FuncMessage = iLog.LogMessage;

                if (iLog.except != null)
                {
                    if (FuncMessage == String.Empty)
                        FuncMessage = iLog.except.Message + " " + iLog.except.Source + " " + iLog.except.StackTrace;
                    else
                        FuncMessage = FuncMessage + ", " + iLog.except.Message + " " + iLog.except.Source + " " + iLog.except.StackTrace;
                } // end of if( ex != null )

                if (FuncMessage.Length > 0)
                    iLog.LogMessage = "1 " + iLog.FunctionEnterTime + " " + iLog.FunctionExitTime + " " + iLog.LogType + " " +
                                        ProgramInfo.ProgramVersion + " " + iLog.FunctionName + " HIP " + iLog.HostIP + " CIP " +
                                        iLog.ClientIP + " " + FuncMessage + "\r\n";
                else
                    iLog.LogMessage = "1 " + iLog.FunctionEnterTime + " " + iLog.FunctionExitTime + " " + iLog.LogType + " " +
                                        ProgramInfo.ProgramVersion + " " + iLog.FunctionName + " HIP " + iLog.HostIP + " CIP " +
                                        iLog.ClientIP + "\r\n";

                if (!Directory.Exists(Static.Log.LogDirectory))
                    Directory.CreateDirectory(Static.Log.LogDirectory );

                if (Static.Log.DebugLog == null)
                    Static.Log.DebugLog = "0";

                if (LogMust || (Static.Log.DebugLog == "1" && iLog.LogLevel == iitConst.LOG.LEVEL_DEBUG) || (iLog.LogLevel >= Static.Log.LogLevel))
                    File.AppendAllText(Static.Log.LogDirectory + @"\" + LogFileName, iLog.LogMessage);
            } // end of try
            catch
            {
            } // end of catch
        } // end of SaveLog()
    } // end of public class iitLog
} // end of namespace iitLogWeb
//===================================================================================================
// End of iitLogWeb.cs
//===================================================================================================
