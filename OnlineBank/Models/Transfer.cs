using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBank.Models
{
    public class Transfer
    {
        public List<TransferLine> Lines { get; set; } = new List<TransferLine>();

        public virtual void TransferAmount(Account account, int amount)
        {
            TransferLine line = Lines
            .Where(a => a.Account.AccountNumber == account.AccountNumber)
            .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new TransferLine
                {
                    Account = account,
                    
                });
            }
            else
            {
                line.Amount = amount;
            }

        }

        

        public virtual void RemoveLine(Account account) =>
        Lines.RemoveAll(n => n.Account.AccountNumber == account.AccountNumber);

        public decimal ComputeTotalValue() =>
        Lines.Sum(a => a.Account.Balance);  //Must be checked for logic
        public virtual void Clear() => Lines.Clear();

        public class TransferLine
        {
            public int TransferLineID { get; set; }
            public Account Account { get; set; }
            public int Amount { get; set; } = 0;
            public double UsdExchangeRate { get; set; } = 3.25;
        }
    }
}
