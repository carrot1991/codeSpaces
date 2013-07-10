using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesApplication.Models.Objects
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class DESAttribute : Attribute
    {
        public Boolean des { get; set; }
    }
}
