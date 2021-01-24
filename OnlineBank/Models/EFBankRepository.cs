using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBank.Models
{
    public class EFBankRepository : IBankRepository
    {
        private BankDbContext context;

        public EFBankRepository(BankDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Account> Accounts => context.Accounts;

        public void CreateAccount(Account a)
        {
            context.Add(a);
            context.SaveChanges();
        }
        public void DeleteAccount(Account a)
        {
            context.Remove(a);
            context.SaveChanges();
        }
        public void SaveAccount(Account a)
        {
            context.SaveChanges();
        }
    }
}
