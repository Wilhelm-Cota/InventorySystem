using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Controllers
{
    public class KWestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
