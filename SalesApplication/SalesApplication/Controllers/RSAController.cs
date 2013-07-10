using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SalesApplication.Tools;
using System.Configuration;

namespace SalesApplication.Controllers
{
    public class RSAController : Controller
    {
        //
        // GET: /RSA/

        public ActionResult Index()
        {
            return View();
        }

        //public JsonResult GenerateKey()
        //{
        //    GetKey.GetKeyFunction();
        //    string path = Session["key"].ToString() + ConfigurationManager.AppSettings["rsaPrivateKeyFilePath"];
        //    RSAUtils.InitCrypto(Server.MapPath("~/MyXml/") + path);
        //    JsonResult json = new JsonResult();
        //    //String jsonStr = "GetRSA_E:" + RSAUtils.getRSA_E()+
        //    ViewBag.GetRSA_E = RSAUtils.getRSA_E();
        //    ViewBag.GetRSA_M = RSAUtils.getRSA_M();
        //    return json;
        //}

    }


}
