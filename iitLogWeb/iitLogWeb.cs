//===================================================================================================
// Project Name  : iit SDK For ASP.NET Core DLL
// Program Name  : iitLogWeb.cs
// Description   : iit Web SDK 中處理程式執行記錄
// Version		 : Ver 1.0.0.0
// Create Author : Golden Jiang 2025/05/23 15:40 建立於 D:\Golden\TSB2\Product\iit SDK For Win-Web\iitLogWeb 目錄
// Update Record :
// Note          :
//===================================================================================================
//---------------------------------------------------------------------------------------------------
// declare package
//---------------------------------------------------------------------------------------------------
using iitSystemWeb;
//---------------------------------------------------------------------------------------------------
// Program Area
//---------------------------------------------------------------------------------------------------
namespace iitLogWeb
{
    public interface ILogClass
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
    } // end of public interface IiitLog

    public class ILog 
    {
        public class LogClass 
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

            public LogClass() 
            { 
                this.SystemName = Static.SystemName;
                this.FunctionEnterTime = DateTime.Now.ToString( "yyyy/MM/dd HH:mm:ss.fff" );
                this.LogMessage = "";
                this.HostIP = "";
                this.ClientIP = "";
                this.except = null;
            } // end of public LogClass()
        } // end of public class LogClass

        //public string  LogDirectory { get; set; }
        //public string  PrefixLogFileName { get; set; }
        //public string  DebugMust {  get; set; }
        //public string  DebugLog {  get; set; }
        //public int     LogLevel { get; set; }
        public LogClass Log { get; set; }

        public ILog()
        {
            Log = new LogClass();
        } // end of public ILog()
        //
        public void WriteLog( string LogMessage, string LogType, int LogLevel,
                            [System.Runtime.CompilerServices.CallerMemberName] string CallerName = "",
                            [System.Runtime.CompilerServices.CallerFilePath] string CallerSourceFile = "",
                            [System.Runtime.CompilerServices.CallerLineNumber] int CallerLineNumber = 0 )
        {
            ILog.LogClass lc =   new ILog.LogClass();
            //
            try
            {
                lc.SystemName           =   Static.SystemName;
                lc.FunctionName         =   Path.GetFileName( CallerSourceFile ) + "->" + CallerName + "()";
                lc.FunctionEnterTime    =   this.Log.FunctionEnterTime;
                lc.LogLevel             =   LogLevel;
                lc.LogType              =   LogType;                    // DEBUG, INFO, WARN, ERROR, CRITIAL, OFF
                lc.FunctionExitTime     =   DateTime.Now.ToString( "yyyy/MM/dd HH:mm:ss.fff" );
                //
                if( LogMessage.Length > 0 )
                    lc.LogMessage       =   this.Log.LogMessage + LogMessage;
                else
                    lc.LogMessage       =   this.Log.LogMessage;
                //
                lc.HostIP               =   Static.HostIP;
                lc.ClientIP             =   Static.ClientIP;
                lc.except               =   this.Log.except;
                //
                SaveLog( lc );
            } // end of try
            catch
            {
            } // end of catch
        } // end of WriteLog( ... )
        //
        private void SaveLog( ILog.LogClass iLog )
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
    } // end of public class ILog
} // end of namespace iitLogWeb
//===================================================================================================
// End of iitLogWeb.cs
//===================================================================================================
