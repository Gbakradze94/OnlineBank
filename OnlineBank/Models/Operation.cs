using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using static OnlineBank.Models.Transfer;

namespace OnlineBank.Models
{
    

    public class Operation
    {


        [BindNever]
        public int OperationID { get; set; }
        [BindNever]
        public ICollection<TransferLine> Lines { get; set; }
       // [Required(ErrorMessage = "Please enter a name")]
        //public long AccountID { get; set; }
        [Required(ErrorMessage = "Please enter account name")]
        public string AccountName { get; set; }
        public int AccountNumber { get; set; }
        public double Amount { get; set; }
        public string Country { get; set; }
        public bool ConfirmOnPhone { get; set; }
        [BindNever]
        public bool Delivered { get; set; }
    }
}