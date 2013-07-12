using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Lasy.Validator;
namespace DALService.Objects
{

    public class Sale
    {
        public Sale()
        {
        }

        public Sale(string username, string phone, string product,double unitprice, int quantity, DateTime salesdate)
        {
            this.username = username;
            this.phone = phone;
            this.product = product;
            this.unitprice = unitprice;

            this.quantity = quantity;
            this.salesdate = salesdate;
        }


        public virtual string username { get; set; }

        public virtual string phone { get; set; }

        public virtual string product { get; set; }


        [DES(des = true)]
        public virtual double unitprice { get; set; }



        [DES(des = true)]
        public virtual int quantity { get; set; }


        public virtual DateTime salesdate { get; set; }
    }
}