﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SISCOA_API
{
    /// <summary>
    /// 
    /// </summary>
    public class RouteConfig
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="routes"></param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}/{rolUserActive}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, rolUserActive = UrlParameter.Optional }
            );
        }
    }
}
