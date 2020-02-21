using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Order_Graber_Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Customer", action = "IndexCustomer", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Create",
               url: "Create",
               defaults: new { controller = "Customer", action = "Create", id = UrlParameter.Optional }
           );

        }
    }
}
