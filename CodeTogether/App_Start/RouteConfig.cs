using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CodeTogether
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            
            routes.MapRoute(
              name: "Login",
              url: "Login/{action}/{id}",
              defaults: new { controller = "Login", action = "LoginIndex", id = UrlParameter.Optional }
            );
            
            routes.MapRoute(
              name: "Register",
              url: "Register/{action}/{id}",

              defaults: new { controller = "Register", action = "RegisterIndex", id = UrlParameter.Optional }
            );

            routes.MapRoute(
             name: "UserDashboard",
             url: "UserDashboard/{action}/{id}",

             defaults: new { controller = "UserDashboard", action = "UserDashboardIndex", id = UrlParameter.Optional }
            );

            routes.MapRoute(
             name: "MyProfile",
             url: "MyProfile/{action}/{id}",

             defaults: new { controller = "MyProfile", action = "MyProfileIndex", id = UrlParameter.Optional }
            );

        

        }

    }
}
