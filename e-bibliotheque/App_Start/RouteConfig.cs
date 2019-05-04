using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace e_bibliotheque
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Afficher",
                url: "{controller}",
                defaults: new { controller = "Afficher", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Auteurs",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Afficher", action = "Auteurs", id = UrlParameter.Optional }
            );

            routes.MapRoute(
              name: "Auteur",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Afficher", action = "Auteur", id = UrlParameter.Optional }
          );

            routes.MapRoute(
                   name: "Livre",
                   url: "{controller}/{action}/{id}",
                   defaults: new { controller = "Afficher", action = "Livre", id = UrlParameter.Optional }
               );

            routes.MapRoute(
                  name: "Rechercher",
                  url: "{controller}/{Livre}/{id}",
                  defaults: new { controller = "Rechercher", action = "Livre", id = UrlParameter.Optional }
              );
        }
    }
}
