﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Work.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index", "_myLayoutPage");
        }

        public ActionResult Home()
        {
            ViewBag.Message = "This is Home page.";
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Application contact page.";
            return View();
        }
    }
}