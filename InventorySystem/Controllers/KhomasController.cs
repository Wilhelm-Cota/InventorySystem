using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Controllers
{
    public class KhomasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
