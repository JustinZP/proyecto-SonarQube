﻿using System.Web.Mvc;

namespace SistemaEventos.Areas.Cliente
{
    public class ClienteAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Cliente";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            //context.MapRoute(
            //    "Cliente_default",
            //    "Cliente/{controller}/{action}/{id}",
            //    new { action = "Index", id = UrlParameter.Optional },
            //    namespaces: new[] { "SistemaEventos.Areas.Cliente.Controllers" }
            //);

            context.MapRoute(
            "Cliente_default",
            "Cliente/{controller}/{action}/{id}",
            new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            new[] { "SistemaEventos.Areas.Cliente.Controllers" }
        );
        }
    }
}