using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Serialization;
using RSAService.Tools;
using System.Configuration;
using DALService.Tools;

namespace RSAService.Service
{
    /// <summary>
    /// getKey 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    [System.Web.Script.Services.ScriptService]
    public class getKey : System.Web.Services.WebService
    {

        [WebMethod]
        public string constructKey()
        {
            string path = new RSAUtils().GetKeyFunction();
            path = Server.MapPath("~/MyXml/") +path + ConfigurationManager.AppSettings["rsaPrivateKeyFilePath"];
            return path;
        }

        [WebMethod]
        public String get(String path)
        {
            RSAUtils rsa = new RSAUtils();
            JavaScriptSerializer jss = new JavaScriptSerializer();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("RSA_E", rsa.getRSA_E(path));
            dic.Add("RSA_M", rsa.getRSA_M(path));
            string jsonstr = Json.Serializer(dic);
            return jsonstr;
        }
    }
}
