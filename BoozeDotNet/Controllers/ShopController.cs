using BoozeDotNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoozeDotNet.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Category(String CategoryName)
        {
            if (CategoryName == null)
            {
                // return View("Index");
                return RedirectToAction("Index");
            }
            // pass input into view
            ViewBag.CategoryName = CategoryName;

            // use product model to mock a list of products for display
            var products = new List<Product>();
            // make products with names of beer
            for (int i = 0; i < 10; i++)
            {
                products.Add(new Product { ProductId = i, Name = "product " + i });
            }


            return View(products);
        }
    }
}
