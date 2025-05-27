//===================================================================================================
// Project Name  : iit SDK For MVC Core DLL
// Program Name  : DataTools.cs
// Description   : iit Web SDK 中處理公用資料模組
// Version		 : Ver 1.0.0.0
// Create Author : Golden Jiang 2025/05/27 10:00 建立於 D:\Golden\TSB2\Product\iit SDK For Win-Web\iitDataWeb 目錄
// Update Record :
// Note          :
//===================================================================================================
//---------------------------------------------------------------------------------------------------
// declare package
//---------------------------------------------------------------------------------------------------
using iitMSGWeb;
//---------------------------------------------------------------------------------------------------
// Program Area
//---------------------------------------------------------------------------------------------------
namespace iitDataWeb
{
    public class DataTools
    {
        public static void SetResponseResult<T>( iitAPIResultClass APIResult, string RespCode, string RespDesc, T RespData )
        {
            APIResult.RespCode = RespCode;
            APIResult.RespDesc = RespDesc;
            APIResult.RespData = RespData;
            //APIResult.RespData       =   JsonConvert.SerializeObject(RespData);
            APIResult.RespDateTime = DateTime.Now.ToString( "yyyy/MM/dd HH:mm:ss.fff" );
        } // end of SetResponseResult( ... )
    } // end of public class DataTools
} // end of namespace iitDataWeb
//===================================================================================================
// End of DataTools.cs
//===================================================================================================
