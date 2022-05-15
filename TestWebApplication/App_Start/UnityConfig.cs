using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TestWebApplication.Interfaces;
using TestWebApplication.Models;
using TestWebApplication.Repositories;
using Unity;
using Unity.Lifetime;
using Unity.WebApi;

namespace TestWebApplication.App_Start
{
    public static class UnityConfig
    {
        /// <summary>
        ///   HttpConfiguration
        /// </summary>
        /// <param name="configuration"> -API</param>
        public static void RegisterComponents(HttpConfiguration configuration)
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        private static void RegisterTypes(UnityContainer container)
        {
            container.RegisterType<IBaseRepository<Employees>, BaseRepository<Employees>>(new HierarchicalLifetimeManager());
        }
    }
}