using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeorgianComputers.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeorgianComputers.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            //Make a list of mock products
            var products = new List<Product>();
            //use a for loop to populate the product list
            for(var i = 1; i <= 10; i++)
            {
                products.Add(new Product { Name = "Product " + i.ToString() });
            }
            //pass the product list to the view so it can be displayed to user.
            return View(products);
        }
        public IActionResult Details(string product)
        {
            //Store the selected product name in the ViewBag container
            //ViewBag is automatically passed back to the view that loads
            ViewBag.product = product;

            return View();
        }


    }
}