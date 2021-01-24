using Microsoft.AspNetCore.Mvc;
using OnlineBank.Models;
namespace SportsStore.Components
{
    public class TransferSummaryViewComponent : ViewComponent
    {
        private Transfer transfer;
        public TransferSummaryViewComponent(Transfer transferService)
        {
            transfer = transferService;
        }
        public IViewComponentResult Invoke()
        {
            return View(transfer);
        }
    }
}