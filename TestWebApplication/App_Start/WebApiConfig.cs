using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TestWebApplication.App_Start;

namespace TestWebApplication
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Регистрация типов зависимостей
            UnityConfig.RegisterComponents(config);
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
