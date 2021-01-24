using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBank.Models
{
    public interface IOperationRepository
    {
        IQueryable<Operation> Operations { get; }
        void SaveOperation(Operation operation);
    }
}
