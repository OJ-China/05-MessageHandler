﻿using System.Web;
using System.Web.Mvc;

namespace _05_MessageHandler
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
