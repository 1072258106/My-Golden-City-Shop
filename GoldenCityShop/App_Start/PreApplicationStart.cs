using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GoldenCityShop;
using GoldenCityShop.Filters;
using GoldenCityShop.HtmlCleaner;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;

[assembly:WebActivator.PreApplicationStartMethod(typeof(PreApplicationStart),"Start")]
namespace GoldenCityShop
{
    public class PreApplicationStart
    {
        public static void Start()
        {
            //DynamicModuleUtility.RegisterModule(typeof(DosAttackModule));
            //DynamicModuleUtility.RegisterModule(typeof(AntiXssModule));
        }
    }
}