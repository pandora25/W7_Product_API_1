using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
//using Newtonsoft.Json;

namespace Cars_DealerShip_FinalCapstone
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            // xml
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            // stop the ininiti loop
            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
