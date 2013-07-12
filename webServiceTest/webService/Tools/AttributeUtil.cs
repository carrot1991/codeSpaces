using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using SalesApplication.Models.Objects;
using DALService.Objects;


namespace RSAService.Tools
{
    public class AttributeUtil
    {
        public static Boolean getDESAttribute(Type type, String properyName)
        {
            PropertyInfo property = type.GetProperty(properyName);
            object[] attributes = property.GetCustomAttributes(typeof(DESAttribute), false);
            if (attributes == null || attributes.Length == 0)
                return false;
            foreach (Attribute loAtt in attributes)
            {
                DESAttribute desAtttibute = null;
                if (loAtt is DESAttribute)
                {
                    desAtttibute = (DESAttribute)loAtt;
                    return desAtttibute.des;
                }
            }
            return false;
        }
    }
}
