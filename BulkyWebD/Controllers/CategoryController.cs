using Microsoft.AspNetCore.Mvc;

namespace BulkyWebD.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
