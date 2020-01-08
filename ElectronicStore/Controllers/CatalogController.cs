using ElectronicStore.Models.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectronicStore.Controllers
{
    public class CatalogController : Controller
    {

        // GET: Catalog
        public ActionResult Index()
        {
            Product product1 = new Product {
                ID = 1,
                Name = "TTel",
                Img = "https://image.freepik.com/free-vector/_1412-16.jpg"
            };
            Product product2 = new Product { 
                ID = 2,
                Name = "Fridge",
                Img = "http://grigorov.pro/wp-content/uploads/2015/06/Holodil-nik.jpg"
            };
            List<Product> products = new List<Product> { product1, product2 };
            return View(products);
        }
    }
}