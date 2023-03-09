using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Controllers
{
    public class OmahekeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
