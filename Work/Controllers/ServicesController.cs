using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Work.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Index()
        {
            return View("Index", "_LayoutServices");
        }

        public ActionResult LaptopServices()
        {
            return View();
        }

        public ActionResult TVServices()
        {
            return View();
        }


        public ActionResult MobileServices()
        {
            return View();
        }

        public ActionResult MicrowaveServices()
        {
            return View();
        }
    }
}