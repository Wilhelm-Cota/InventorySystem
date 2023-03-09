using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Controllers
{
    public class ErongoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
