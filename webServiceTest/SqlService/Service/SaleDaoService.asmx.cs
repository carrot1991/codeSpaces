﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DAO;
using DAO.implements;
using DALService.Tools;
using System.Configuration;

using DALService.Objects;
using DAO._interface;


namespace DALService.Service
{
    /// <summary>
    /// SaleDaoService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class SaleDaoService : System.Web.Services.WebService
    {
        IDAL idal = (IDAL)Resolver.createInstance("SqlService.Service.SaleDaoService", "idal");

        [WebMethod]
        public Boolean SaveSale(String strSale,String strProduct)
        {

            

            Sale sale = (Sale)Json.Deserializer(strSale, typeof(Sale));
            Product product = (Product)Json.Deserializer(strProduct, typeof(Product));
            try
            {
                return idal.saveTWO(product, sale);
            }
            catch (Exception e) { 
                System.Console.WriteLine(e.Message);
                return false;
            }
        }

    }
}
