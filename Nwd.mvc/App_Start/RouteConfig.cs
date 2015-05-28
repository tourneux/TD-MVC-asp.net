using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Nwd.mvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes( RouteCollection routes )
        {
            routes.IgnoreRoute( "{resource}.axd/{*pathInfo}" );

            routes.MapRoute(
                name: "controller",
                url: "Admin/",
                defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Admin_Albums",
                url: "Admin/Album/List",
                defaults: new { controller = "Album", action = "AdminAlbums", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Album",
                url: "music/album/{id}",
                defaults: new { controller = "Album", action = "Details", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Index",
                url: "music/albums/catalog/",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
