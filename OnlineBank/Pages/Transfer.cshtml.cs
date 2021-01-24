using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineBank.Infrastructure;
using OnlineBank.Models;

namespace OnlineBank.Pages
{
    public class TransferModel : PageModel
    {
        private IBankRepository repository;

        public TransferModel(IBankRepository repo, Transfer transferService)
        {
            repository = repo;
            Transfer = transferService;
        }

        public Transfer Transfer { get; set; }
        public string ReturnUrl { get; set; }


        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }



        public IActionResult OnPost(long accountNumber, string returnUrl)
        {
            Account account = repository.Accounts
                .FirstOrDefault(a => a.AccountNumber == accountNumber);
            Transfer.TransferAmount(account, 1);
            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long accountNumber, string returnUrl)
        {
            Transfer.RemoveLine(Transfer.Lines.First(tl =>
             tl.Account.AccountNumber == accountNumber).Account);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
