using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Order_Graber_Web.Models
{
    public class PRODUCTS
    {
        public int product_id { get; set; }
        public string product_code { get; set; }
        public string product_name { get; set; }
        public double cost_price { get; set; }
        public double sale_price { get; set; }
        public string state { get; set; }

    }
}