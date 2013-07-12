using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using DAO.implements;

namespace DALService.Tools
{
    
    class Resolver
    {
        //存放实例列表
        static IDictionary<string, IDictionary<string, Object>> instance_hashMap = null;

        //根据Service名称与属性名称 获取 属性相应的实例，这些实例都放在一个HashMap中
        public static Object createInstance(string service_type,string param_name)
        {
            Object result;           
            try
            {
                if (instance_hashMap == null)
                {
                    instance_hashMap = new Dictionary<string, IDictionary<string, Object>>();
                    XMLReader xmlReader = new XMLReader();
                    xmlReader.readXml2Resolver();
                }
                result = instance_hashMap[service_type][param_name];
            }
            catch (Exception e)
            {
                result = null;
            }
            return result;
        }

        public static void addParam(string service_type, string param_name, string param_type)
        {
            Assembly assembly = Assembly.Load("DAO");
            object param = assembly.CreateInstance(param_type);

            addParam(service_type, param_name, param);
       
        }

        public static void addParam(string service_type, string param_name, Object param)
        {
            IDictionary<string, Object> param_hashMap = new Dictionary<string, Object>();
            Boolean exist = instance_hashMap.TryGetValue(service_type, out param_hashMap);
            if(param_hashMap==null)
                param_hashMap = new Dictionary<string, Object>();
           
            param_hashMap.Add(param_name,param);

            if (exist)
                instance_hashMap[service_type] = param_hashMap;
            else
                instance_hashMap.Add(service_type, param_hashMap);            
        }

    }
}
