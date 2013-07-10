using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using SqlService.Tools;

namespace SqlService
{
    public class XMLReader
    {

        public static void readXml2Resolver()
        {
            XmlNodeReader reader = null;
            try
            {
                XmlDocument doc = new XmlDocument();
                // 装入指定的XML文档
                doc.Load(HttpContext.Current.Server.MapPath("~/" + "dao.xml"));

                // 设定XmlNodeReader对象来打开XML文件
                reader = new XmlNodeReader(doc);
                string service_type = String.Empty;
                // 读取XML文件中的数据，并显示出来
                while (reader.Read())
                {                 
                    //判断当前读取得节点类型
                    switch (reader.Name)
                    {
                        case "service":
                            service_type = reader.GetAttribute("type");
                            break;
                        case "param":
                            string param_name = reader.GetAttribute("name");
                            string param_type = reader.GetAttribute("type");
                            Resolver.addParam(service_type, param_name, param_type);
                            break;
                    }
                }
            }
            catch(Exception e)
            {

            }
            finally
            {
                //清除打开的数据流
                if (reader != null)
                    reader.Close();
            }
        }
    }
}