﻿using System.Web.Mvc;

namespace SiteBD.Areas.Painel
{
    public class PainelAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Painel";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Painel_default",
                "Painel/{controller}/{action}/{id}",
                new { action = "Index", controller = "Inicio", id = UrlParameter.Optional }
            );
        }
    }
}