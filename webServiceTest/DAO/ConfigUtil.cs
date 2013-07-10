using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Reflection;
using System.Xml;
using System.Configuration;
namespace DAO
{
    class ConfigUtil
    {
        public static string getConnectionString()
        {
            String connectionStrings = ConfigurationManager.ConnectionStrings["connStrings"].ToString();
            return connectionStrings;
        }


        /// <summary>
        /// 读取配置文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private Dictionary<string, MethodInfo> LoadAppConfig(string filename)
        {
            var processors = new Dictionary<string, MethodInfo>();
            var xml = new XmlDocument();
            xml.Load(filename);

            foreach (XmlNode node in xml.SelectNodes("dbConfig/connectionStrings/*"))
            {
                if (node.NodeType != XmlNodeType.Element)
                    continue;

                var method = node.Name;
                try
                {
                    string typeName = node.Attributes["type"].Value;//程序集名称
                    string methodName = node.Attributes["method"].Value;//方法名称
                    var t = Type.GetType(typeName);
                    var m = t.GetMethod(methodName);
                    processors.Add(methodName, m);
                }
                catch (Exception e)
                {

                }
            }
            return processors;
        }

    }
}
