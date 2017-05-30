using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Models;

namespace UI.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        [HttpGet]
        public ActionResult Index()
        {
            List<Product> products = new List<Product>{
                   new Product{Id= 1, Name = "Lamborghini", Price = 1000},
                   new Product{Id= 2, Name = "Ferrari", Price = 2000},
                   new Product{Id = 3,Name = "Masertai",Price = 3000 }
                   };
            
            return PartialView("Index",products);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            List<Product> products = new List<Product>();
            products.Add(product);
            return PartialView("Index", products);
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }
    }
}