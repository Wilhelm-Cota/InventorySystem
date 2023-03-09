using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Controllers
{
    public class OmusatiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
