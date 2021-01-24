using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBank.Models
{
    public interface IBankRepository
    {
        IQueryable<Account> Accounts { get; }
        void SaveAccount(Account a);
        void CreateAccount(Account a);
        void DeleteAccount(Account a);
    }
}
