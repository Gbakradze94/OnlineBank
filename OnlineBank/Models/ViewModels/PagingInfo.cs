using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBank.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalAccounts { get; set; }
        public int AccountsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages =>
        (int)Math.Ceiling((decimal)TotalAccounts / AccountsPerPage);
    }
}
