using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Work.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View("Index", "_LayoutProducts");
        }

        public ActionResult Laptop()
        {
            ViewBag.Message = "This is a Laptop. ";
            return View();
        }

        public ActionResult TV()
        {
            ViewBag.Message = "This is a TV. ";
            return View();
        }


        public ActionResult Mobile()
        {
            ViewBag.Message = "This is a Mobile. ";
            return View();
        }

        public ActionResult Microwave()
        {
            ViewBag.Message = "This is a Microwave. ";
            return View();
        }
    }
}