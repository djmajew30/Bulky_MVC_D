using BulkyWebD.Data;
using BulkyWebD.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWebD.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        //ctor
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
    }
}
