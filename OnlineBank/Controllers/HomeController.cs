using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineBank.Models;
using OnlineBank.Models.ViewModels;

namespace OnlineBank.Controllers
{
    public class HomeController : Controller
    {
        private IBankRepository repository;
        public int PageSize = 4;

        public HomeController(IBankRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index(string category, int accountPage = 1)
            => View(new AccountListViewModel
            {
                Accounts = repository.Accounts
                .Where(a => category == null || a.Category == category)
                .OrderBy(a => a.AccountName)
                .Skip((accountPage - 1) * accountPage)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = accountPage,
                    AccountsPerPage = PageSize,
                    TotalAccounts = category == null ?
                    repository.Accounts.Count() : 
                    repository.Accounts.Where(a => 
                    a.Category == category).Count()
                },
                CurrentCategory = category
            });

        // Controller for 'About' page
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}
