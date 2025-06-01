// Project Name  : iit SDK For MVC Core DLL
// Program Name  : iitCheckTools.cs
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
namespace iitToolsWeb
{
    public class iitCheckTools
    {
        public static bool CheckTeleNo( string TeleNo, iitAPIResultClass APIResult )
        {
            bool    ReturnValue = false;
//
            while( true )
            {
                APIResult.RespCode  =   "2000";
                APIResult.RespDesc  =   "電話號碼錯誤";
//
                if( ( TeleNo.Length < 10 ) || ( TeleNo.Substring( 0, 2 ).CompareTo( "09" ) != 0 ) )
                    break;
//
                int n;
                if( ! int.TryParse( TeleNo , out n ) )
                    break;
//      
                APIResult.RespCode  =   "0000";
                ReturnValue         =   true;
                break;
            } // end of whilr( true )
//
            return ReturnValue;
        } // end of CheckTeleNo( ... )
    } // end of public class iitCheckTools
} // end of namespace iitToolsWeb
//===================================================================================================
// End of iitCheckTools.cs
//===================================================================================================
