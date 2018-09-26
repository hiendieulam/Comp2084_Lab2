using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1_HienLam.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products of you
        public ActionResult Index()
        {
            return View();
        }

        // GET: Products/Product Details 
        public ActionResult Details(string ProductName)
        {
            ViewBag.ProductName = ProductName;
            return View(); 
        }
    }
}