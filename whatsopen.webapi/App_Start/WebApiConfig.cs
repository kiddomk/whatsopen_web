﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace whatsopen.webapi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "GeoApi",
                routeTemplate: "api/{controller}/{action}/{geolocation}",
                defaults: new { geolocation = RouteParameter.Optional }
            );
        }
    }
}
