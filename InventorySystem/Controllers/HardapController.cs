using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Controllers
{
    public class HardapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
