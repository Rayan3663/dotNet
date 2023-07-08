using FirstApp.Data;
using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace FirstApp.Controllers
{
    public class CategoryController : Controller
    {

        private ApplicationDbContext _context1;

        public CategoryController(ApplicationDbContext context1)
        {
            _context1 = context1;
        }


        public IActionResult Index()

        {

            //IEnumerable<Category> categories = _context1.Categories;
            List<Category> categories = _context1.Categories.ToList();
            return View(categories);
        }

       //[HttpPost]

        public IActionResult Create()

        {
            return View();
        }




        [HttpPost]
        public IActionResult Update(Category category) {

            _context1.Categories.Add(category);
            _context1.SaveChanges();
            return RedirectToAction("Index");


           
           
          
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Category category)

        {
            //var names = name1;
            _context1.Categories.Add(category);
            _context1.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
