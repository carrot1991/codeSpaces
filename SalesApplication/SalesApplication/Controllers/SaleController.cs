using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SalesApplication.Models;
using SalesApplication.Models.Objects;
using SalesApplication.Tools;
using System.Configuration;
using SalesApplication.ServiceReference1;
using SalesApplication.ServiceReference2;
using SalesApplication.ServiceReference3;
using SalesApplication.ServiceReference4;
using System.Web.Script.Serialization;
using System.Collections;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Text;

namespace SalesApplication.Controllers
{
    public class SaleController : Controller
    {
        //
        // GET: /Sale/

        //public SalesModule salesModule { get; set; }

        public ActionResult Index()
        {
            ViewBag.Message = "销售单提交系统";

            getKeySoapClient getKeyService = new getKeySoapClient();
            string path = getKeyService.constructKey();
            System.Web.HttpContext.Current.Session["key"] = path;
            string str = getKeyService.get(path);
            Dictionary<string, string> dic = (Dictionary<string, string>)SalesApplication.Tools.Json.Deserializer(str, typeof(Dictionary<string, string>));

            ViewBag.GetRSA_E = dic["RSA_E"];
            ViewBag.GetRSA_M = dic["RSA_M"];

            return View();
        }


        [HttpPost]
        public ActionResult Create()
        {
            Sale sale = new Sale();

            System.Type saleType = typeof(Sale);
            Dictionary<string, string> hashMap = new Dictionary<string, string>();


            //接受页面表单数据，并分装
            foreach (String key in Request.Form.AllKeys)
            {
                hashMap.Add(key, Request.Form[key]);
            }


            //创建RSA解密的webService客户端对象，调用解密业务
            decrpytSoapClient decService = new decrpytSoapClient();
            string str_dic = SalesApplication.Tools.Json.Serializer(hashMap);
            string dec_res = decService.dec(str_dic, System.Web.HttpContext.Current.Session["key"].ToString());
            if (dec_res == null)
            {
                return View("error");
            }
            hashMap = (Dictionary<string, string>)SalesApplication.Tools.Json.Deserializer(dec_res, typeof(Dictionary<string, string>));




            //创建数据校验webService客户端对象，调用校验业务
            string strDictionary = SalesApplication.Tools.Json.Serializer(hashMap);
            ValidateServiceSoapClient validateService = new ValidateServiceSoapClient();
            Boolean res = validateService.validate(strDictionary);

            if (res)
            {
                foreach (var item in hashMap)
                {
                    System.Type t = saleType.GetProperty(item.Key).PropertyType;
                    var arg = Convert.ChangeType(item.Value, t);
                    saleType.GetProperty(item.Key).SetValue(sale, arg, null);
                }
            }
            else
            {
                return View("Error");
            }

            //调用sale存储webService客户端对象，执行保存业务逻辑
            String strSale = SalesApplication.Tools.Json.Serializer(sale);
            SaleDaoServiceSoapClient saleService = new SaleDaoServiceSoapClient();
            if (saleService.SaveSale(strSale))
                return View("Success");
            return View("Error");

        }

        public ActionResult Error()
        {
            return View();
        }
        public ActionResult Success()
        {
            return View();
        }
    }
}
