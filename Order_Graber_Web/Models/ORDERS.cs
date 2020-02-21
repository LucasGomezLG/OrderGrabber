using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Order_Graber_Web.Models
{
    public class ORDERS
    {
        public int order_id { get; set; }
        public int client_id { get; set; }
        public DateTime order_date { get; set; }
        public double total_order { get; set; }
        public string state { get; set; }

    }
}