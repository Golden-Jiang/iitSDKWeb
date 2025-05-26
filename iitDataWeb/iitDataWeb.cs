//===================================================================================================
// Project Name  : iit SDK For MVC Core DLL
// Program Name  : iitDataWeb.cs
// Description   : iit Web SDK 中處理公用資料結構
// Version		 : Ver 1.0.0.0
// Create Author : Golden Jiang 2025/05/23 19:00 建立於 D:\Golden\TSB2\Product\iit SDK For Win-Web\iitDataWeb 目錄
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
    public class iitDataWeb
    {

    } // end of public class iitDataWeb

    [Serializable]
    public class iitAPIResultClass
    {
        public string   RespCode;
        public string   RespDesc;
        public object   RespData;
        public string   RequestDateTime;
        public string   RespDateTime;
//
        public iitAPIResultClass()
        {
            RespCode        =   iitMSG.CODE.HTTP.UNKNOW_ERROR;
            RespDesc        =   "交易失敗";
            RespData        =   null;
            RequestDateTime =   DateTime.Now.ToString( "yyyy/MM/dd HH:mm:ss.fff" );
            RespDateTime    =   "";
        } // end of public APIResultClass()
    } // end of APIResultClass
} // end of namespace iitDataWeb
//===================================================================================================
// End of iitDataWeb.cs
//===================================================================================================
