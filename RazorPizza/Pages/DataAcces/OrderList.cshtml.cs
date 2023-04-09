﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DLL;

namespace RazorPizza.Pages.DataAcces
{
	public class OrderListModel : PageModel
    {
        DataContext dataContext = new DataContext();
        public void OnGet()
        {
            List<Order> orders= dataContext.Orders.ToList();
        }
    }
}
