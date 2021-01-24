using System;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using OnlineBank.Infrastructure;

namespace OnlineBank.Models
{
    public class SessionTransfer : Transfer
    {
        public static Transfer GetTransfer(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
            .HttpContext.Session;
            SessionTransfer transfer = session?.GetJson<SessionTransfer>("Transfer")
            ?? new SessionTransfer();
            transfer.Session = session;
            return transfer;
        }
        [JsonIgnore]
         public ISession Session { get; set; }
         public override void TransferAmount(Account account, int quantity)
         {
             base.TransferAmount(account, quantity);
             Session.SetJson("Transfer", this);
         }

         public override void RemoveLine(Account account)
         {
            base.RemoveLine(account);
            Session.SetJson("Transfer", this);
         }
         public override void Clear()
         {
             base.Clear();
             Session.Remove("Transfer");
         }

    }
}
