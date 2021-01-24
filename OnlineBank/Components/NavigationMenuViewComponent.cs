using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineBank.Models;

namespace OnlineBank.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBankRepository repository;

        public NavigationMenuViewComponent(IBankRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            
            return View(repository.Accounts
                .Select(a => a.Category)
                .Distinct()
                .OrderBy(a => a));
        }

    }
}
