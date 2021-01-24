using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace OnlineBank.Models
{
    public class EFOperationRepository : IOperationRepository
    {
        private BankDbContext context;
        public EFOperationRepository(BankDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Operation> Operations => context.Operations
            .Include(o => o.Lines)
            .ThenInclude(t => t.Account);

        public void SaveOperation(Operation operation)
        {
            context.AttachRange(operation.Lines.Select(t => t.Account));
            if (operation.OperationID == 0)
            {
                context.Operations.Add(operation);
            }
            context.SaveChanges();
        }
    }
}
