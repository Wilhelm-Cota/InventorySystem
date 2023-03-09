using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Controllers
{
    public class OshikotoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
