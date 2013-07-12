using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DALService.Objects
{
    public class Product
    {

        public Product()
        {

        }

        public Product(string id, double cost)
        {
            this.id = id;
            this.cost = cost;
        }
        public virtual string id { get; set; }
        [DES(des = true)]
        public virtual double cost { get; set; }
    }
}