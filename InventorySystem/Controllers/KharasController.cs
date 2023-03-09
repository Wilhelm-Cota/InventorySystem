using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Controllers
{
    public class KharasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
