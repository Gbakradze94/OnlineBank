using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using OnlineBank.Models;

namespace OnlineBank.Controllers
{
    public class OperationController : Controller
    {
        private IOperationRepository repository;
        private Transfer transfer;
        private BankDbContext ctx;


        public OperationController(IOperationRepository repoService, Transfer transferService, BankDbContext context)
        {
            repository = repoService;
            transfer = transferService;
            ctx = context;
        }
        public ViewResult Confirm() => View(new Operation());
        
        [HttpPost]
        public IActionResult Confirm(Operation operation)
        {
            if(transfer.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Transfer form is empty");
            }
            if (ModelState.IsValid)
            {
                operation.Lines = transfer.Lines.ToArray();
                repository.SaveOperation(operation);


                // Input account number gets matched to existing object
                var obj = ctx.Accounts.FirstOrDefault(x => x.AccountNumber == operation.AccountNumber);
                if (obj != null) obj.Balance +=  (decimal)operation.Amount;

                    

                ctx.SaveChanges();



                //// This operations adds the new account according to input the user gives
                //ctx.AddRange(new Account
                //{
                //    AccountName = operation.AccountName,
                //    AccountNumber = operation.AccountNumber,
                //    Currency = "GEL",
                //    Balance = (decimal)operation.Amount,
                //    Category = "CurrentAccount"
                //});
                //ctx.SaveChanges();

                transfer.Clear();   
                return RedirectToPage("/Completed", new { operationId = operation.OperationID });
            }
            else
            {
                return View();
            }
        }


    }
}
