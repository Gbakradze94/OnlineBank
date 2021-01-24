using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBank.Models
{
    public class Account
    {
        public long AccountID { get; set; }
        public string AccountName { get; set; }
        public string Currency { get; set; }
        public int AccountNumber { get; set; }
       
        [Column(TypeName="decimal(8,2)")]
        public decimal Balance { get; set; }
        public string Category { get; set; }
      
    }
}
