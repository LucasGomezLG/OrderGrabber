using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Order_Graber_Web.Models
{
    public class ORDERS_DETAIL
    {

        public int line_id { get; set; }
        public int order_id { get; set; }
        public int product_id { get; set; }
        public int quantity { get; set; }
        public double total_line { get; set; }

        public virtual ORDERS ORDERS { get; set; }
        public virtual PRODUCTS PRODUCTS { get; set; }

    }
}