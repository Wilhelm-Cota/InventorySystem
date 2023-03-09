using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Controllers
{
    public class KuneneController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
