//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Order_Graber_DataService
{
    using System;
    using System.Collections.Generic;
    
    public partial class ORDERS_DETAIL
    {
        public int line_id { get; set; }
        public Nullable<int> order_id { get; set; }
        public Nullable<int> product_id { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<double> total_line { get; set; }
    
        public virtual ORDERS ORDERS { get; set; }
        public virtual PRODUCTS PRODUCTS { get; set; }
    }
}
