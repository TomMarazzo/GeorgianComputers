using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GeorgianComputers.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
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