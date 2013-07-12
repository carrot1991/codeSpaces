using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DALService.Tools;
using SalesApplication.Models.Objects;
using DALService.Objects;


namespace ValidateService
{
    /// <summary>
    /// ValidateService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class ValidateService : System.Web.Services.WebService
    {

        [WebMethod]
        public Boolean validate(String strDictionary)
        {
            Dictionary<string, string> hashMap = (Dictionary<string, string>)Json.Deserializer(strDictionary, typeof(Dictionary<string, string>));
            foreach (var item in hashMap)
            {
                Type t = null;
                try
                {
                    t = typeof(Sale).GetProperty(item.Key).PropertyType;
                }
                catch (System.Exception ex)
                {
                    t = typeof(Product).GetProperty(item.Key).PropertyType;
                }
                if (null == t)
                    return false;
                try
                {
                    var arg = Convert.ChangeType(item.Value, t);
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            int unitprice = (int)(Convert.ChangeType((hashMap["unitprice"].ToString()), typeof(int)));
            int cost = (int)(Convert.ChangeType((hashMap["cost"].ToString()), typeof(int)));
            if (unitprice < cost) return false;
            return true;
        }
    }
}
