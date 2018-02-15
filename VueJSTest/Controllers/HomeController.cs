using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VueJSTest.Models;

namespace VueJSTest.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Product> products = Product.GetProducts().ToList();

            return View(products);
        }

        [HttpPost]
        public ActionResult AddProduct(Product prod)
        {
            prod.Id = Product.GetProducts().Count() + 1;

            Product.AddProduct(prod);

            return Json(prod.Id);
        }
    }
}