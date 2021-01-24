using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBank.Models
{
    public class SeedData
    {
         public static void EnsurePopulated(IApplicationBuilder app)
         {
            BankDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<BankDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Accounts.Any())
            {
                context.Accounts.AddRange(
                    new Account
                    {
                        AccountName = "Giorgi Bakradze",
                        AccountNumber = 00012,
                        Currency = "GEL",
                        Balance = 100,
                        Category = "CurrentAccount"
                    },
                    new Account
                    {
                        AccountName = "Thomas Wayne",
                        AccountNumber = 000000002,
                        Currency = "EUR",
                        Balance = 600,
                        Category = "CurrentAccount"
                    },
                    new Account
                    {
                        AccountName = "Thomas Wayne",
                        AccountNumber = 000000003,
                        Currency = "USD",
                        Balance = 1200.45m,
                        Category = "CurrentAccount"
                    },
                    new Account
                    {
                        AccountName = "Thomas Wayne",
                        AccountNumber = 000000004,
                        Currency = "GEL",
                        Balance = 850.5m,
                        Category = "CurrentAccount"
                    },
                    new Account
                    {
                        AccountName = "Vladislav Dashtu",
                        AccountNumber = 000000005,
                        Currency = "GEL",
                        Balance = 650.2m,
                        Category = "SavingsAccount"
                    }
                 );
                context.SaveChanges();
            }
         }
    }
}
