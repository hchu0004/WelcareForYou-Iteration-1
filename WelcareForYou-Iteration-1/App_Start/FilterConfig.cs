﻿using System.Web;
using System.Web.Mvc;

namespace WelcareForYou_Iteration_1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
