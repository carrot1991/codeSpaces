using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using RSAService.Tools;
using DALService.Tools;
using SalesApplication.Models.Objects;
using DALService.Objects;


namespace webService
{
    /// <summary>
    /// decrpyt 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class decrpyt : System.Web.Services.WebService
    {

        [WebMethod]
        public string dec(String strDic, String keyFileName)
        {
            Dictionary<string, string> hashMap = (Dictionary<string, string>)Json.Deserializer(strDic, typeof(Dictionary<string, string>));
            Dictionary<string, string> t_hashMap = new Dictionary<string, string>();
            Boolean des = false;
            foreach (var item in hashMap)
            {
                try
                {
                    des = AttributeUtil.getDESAttribute(typeof(Sale), item.Key);
                }
                catch (System.Exception ex)
                {
                    try
                    {
                        des = AttributeUtil.getDESAttribute(typeof(Product), item.Key);
                    }
                    catch (System.Exception ex2)
                    {
                    }
                }


                string result;
                if (des)
                {
                    try
                    {
                        result = RSAUtils.Decrypt(item.Value, keyFileName);
                    }
                    catch (Exception e)
                    {
                        return null;
                    }
                }
                else
                {
                    result = item.Value;
                }
                t_hashMap.Add(item.Key, result);
            }

            return Json.Serializer(t_hashMap);
        }
    }
}
