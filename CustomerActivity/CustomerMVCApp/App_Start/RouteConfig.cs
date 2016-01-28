using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CustomerMVCApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "CustomerIndex",
                url: "{controller}/{action}/{name}",
                defaults: new { controller = "Customer", action = "Index", name = UrlParameter.Optional }
           );
            routes.MapRoute(
                name: "CustomerDetail",
                url: "{controller}/{action}/{name}",
                defaults: new { controller = "Customer", action = "Detail", name = "" }
           );

            routes.MapRoute(
               name: "CustomerEdit",
               url: "{controller}/{action}/{name}",
               defaults: new { controller = "Customer", action = "Edit", name = "" }
          );

            routes.MapRoute(
              name: "CustomerDelete",
              url: "{controller}/{action}/{name}",
              defaults: new { controller = "Customer", action = "Delete", name = "" }
         );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            
        }
    }
}
