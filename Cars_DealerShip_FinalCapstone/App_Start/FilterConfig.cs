﻿using System.Web;
using System.Web.Mvc;

namespace Cars_DealerShip_FinalCapstone
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
