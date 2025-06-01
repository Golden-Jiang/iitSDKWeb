using iitDataWeb;
using iitMSGWeb;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iitToolsWeb
{
    public class iitDataTools
    {
        public static void SetResponseResult<T>( iitAPIResultClass APIResult, string RespCode, string RespDesc, T RespData )
        {
            APIResult.RespCode = RespCode;
            APIResult.RespDesc = RespDesc;
            APIResult.RespData = RespData;
            //APIResult.RespData       =   JsonConvert.SerializeObject(RespData);
            APIResult.RespDateTime = DateTime.Now.ToString( "yyyy/MM/dd HH:mm:ss.fff" );
        } // end of SetResponseResult( ... )

        public static string APIErrorProcess( iitAPIResultClass APIResult, string RespCode, string RespDesc )
        {
            string  ReturnValue = "";
 
            APIResult.RespCode      =   RespCode;
            APIResult.RespDesc      =   RespDesc;
            APIResult.RespDateTime  =   DateTime.Now.ToString( "yyyy/MM/dd HH:mm:ss.fff" );
            
            ReturnValue =   JsonConvert.SerializeObject( APIResult );

            return ReturnValue;
        } // end of APIErrorProcess( ... )

        public static string CheckQuery( IHttpContextAccessor httpContextAccessor, 
                                         iitAPIResultClass APIResult, string ParaName, ref string ParaValue )
        {
            string  ReturnValue = "";
//
            try
            {
                //string aa = httpContextAccessor.HttpContext.Request.Query[ "TeleNo"];
                if( httpContextAccessor.HttpContext.Request.Query[ ParaName ].ToString() != null )
                {
                    ParaValue    =   httpContextAccessor.HttpContext.Request.Query[ParaName].ToString().Trim();
                    if( ParaValue.Length == 0 )
                        ReturnValue =   iitDataTools.APIErrorProcess( APIResult, "1002", $"{iitMSG.APIError.E1002} [{ParaName}]" );
                } // end of if( allUrlKeyValues.LastOrDefault( x => x.Key == ParaName ).Value != null )
                else
                   ReturnValue =   iitDataTools.APIErrorProcess( APIResult, "1001", $"{iitMSG.APIError.E1001} [{ParaName}]" );
            } // end of try
            catch
            {
            } // end of catch
 
            return ReturnValue;
        } // end of CheckQuery( ... )
    } // end of public class iitDataTools
} // end of namespace iitToolsWeb
//===================================================================================================
// End of iitDataTools.cs
//===================================================================================================
