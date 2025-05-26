using System.Runtime.CompilerServices;
using Microsoft.Extensions.Configuration;
using iitSystemWeb;

namespace iitLogWeb2
{
    public interface ILog
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
        void WriteLog( string LogMessage, string LogType, int LogLevel );
        void SaveLog();
    } // end of public interface IiitLog

    public class iitLog 
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

            //public LogClass() 
            //{ 
            //    this.SystemName = Static.SystemName;
            //    this.FunctionEnterTime = DateTime.Now.ToString( "yyyy/MM/dd HH:mm:ss.fff" );
            //    this.LogMessage = "";
            //    this.HostIP = "";
            //    this.ClientIP = "";
            //    this.except = null;
            //} // end of public LogClass()

        public string  LogDirectory { get; set; }
        public string  PrefixLogFileName { get; set; }
        public string  DebugMust {  get; set; }
        public string  DebugLog {  get; set; }
        public int     DefaultLogLevel { get; set; }
        //public LogClass Log { get; set; }

        //public ILog()
        //{
        //    LogDirectory = Static.config[ "iitLog:iLogDirectory" ];
        //    if (LogDirectory == null)
        //        LogDirectory = AppDomain.CurrentDomain.BaseDirectory;

        //    DebugMust = Static.config[ "iitLog:iLogMust" ];

        //    PrefixLogFileName = Static.config[ "iitLog:iLogFileName" ];

        //    DebugLog = Static.config[ "iitLog:iLogDebug" ];

        //    if( Static.config[ "iitLog:iLogLevel" ] != null )
        //        this.LogLevel = Convert.ToInt32( Static.config[ "iitLog:iLogLevel" ] );
        //    else
        //        this.LogLevel = iitConst.LOG.LEVEL_LOWEST;

        //    Log = new LogClass();
        //} // end of public ILog()
        //
        public void WriteLog( string LogMessage, string LogType, int LogLevel,
                            [System.Runtime.CompilerServices.CallerMemberName] string CallerName = "",
                            [System.Runtime.CompilerServices.CallerFilePath] string CallerSourceFile = "",
                            [System.Runtime.CompilerServices.CallerLineNumber] int CallerLineNumber = 0 )
        {
            iitLog lc =   new iitLog();
            //
            try
            {
                lc.SystemName           =   Static.SystemName;
                lc.FunctionName         =   Path.GetFileName( CallerSourceFile ) + "->" + CallerName + "()";
                lc.FunctionEnterTime    =   this.FunctionEnterTime;
                lc.LogLevel             =   LogLevel;
                lc.LogType              =   LogType;                    // DEBUG, INFO, WARN, ERROR, CRITIAL, OFF
                lc.FunctionExitTime     =   DateTime.Now.ToString( "yyyy/MM/dd HH:mm:ss.fff" );
                //
                if( LogMessage.Length > 0 )
                    lc.LogMessage       =   this.LogMessage + LogMessage;
                else
                    lc.LogMessage       =   this.LogMessage;
                //
                lc.HostIP               =   Static.HostIP;
                lc.ClientIP             =   Static.httpContextAccessor.HttpContext.Items[ "ClientIP" ].ToString();
                lc.except               =   this.except;
                //
                SaveLog( lc );
            } // end of try
            catch
            {
            } // end of catch
        } // end of WriteLog( ... )
        //
        private void SaveLog( iitLog iLog )
        {
            bool LogMust = false;
            string[] DebugMustFunction;
            DateTime TmpDateTime;
            string LogFileName, FuncMessage;

            try
            {
                //TmpDateTime = DateTime.Now;

                //if (DebugMust != null)
                //{
                //    DebugMustFunction = DebugMust.Split(',');

                //    foreach (string ss in DebugMustFunction)
                //    {
                //        if (iLog.FunctionName.Contains(ss))
                //        {
                //            LogMust = true;
                //            break;
                //        } // end of if( iLog.FunctionName.IndexOf( ss ) >= 0 )
                //    } // end of foreach( string ss in DebugMustFunction )
                //} // end of if (DebugMust != null)

                //if (PrefixLogFileName != null)
                //    LogFileName = PrefixLogFileName + TmpDateTime.ToString("yyyyMMdd") + ".Log";
                //else
                //    LogFileName = "iLog" + TmpDateTime.ToString("yyyyMMdd") + ".Log";

                //FuncMessage = iLog.LogMessage;

                //if (iLog.except != null)
                //{
                //    if (FuncMessage == String.Empty)
                //        FuncMessage = iLog.except.Message + " " + iLog.except.Source + " " + iLog.except.StackTrace;
                //    else
                //        FuncMessage = FuncMessage + ", " + iLog.except.Message + " " + iLog.except.Source + " " + iLog.except.StackTrace;
                //} // end of if( ex != null )

                //if (FuncMessage.Length > 0)
                //    iLog.LogMessage = "1 " + iLog.FunctionEnterTime + " " + iLog.FunctionExitTime + " " + iLog.LogType + " " +
                //                        ProgramInfo.ProgramVersion + " " + iLog.FunctionName + " HIP " + iLog.HostIP + " CIP " +
                //                        iLog.ClientIP + " " + FuncMessage + "\r\n";
                //else
                //    iLog.LogMessage = "1 " + iLog.FunctionEnterTime + " " + iLog.FunctionExitTime + " " + iLog.LogType + " " +
                //                        ProgramInfo.ProgramVersion + " " + iLog.FunctionName + " HIP " + iLog.HostIP + " CIP " +
                //                        iLog.ClientIP + "\r\n";

                //if (!Directory.Exists(LogDirectory))
                //    Directory.CreateDirectory(LogDirectory);

                //if (DebugLog == null)
                //    DebugLog = "0";

                //if (LogMust || (DebugLog == "1" && iLog.LogLevel == iitConst.LOG.LEVEL_DEBUG) || (iLog.LogLevel >= LogLevel))
                //    File.AppendAllText(LogDirectory + @"\" + LogFileName, iLog.LogMessage);
            } // end of try
            catch
            {
            } // end of catch
        } // end of SaveLog()
    } // end of public interface ILog
}
