﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bakery2018.Models;

namespace Bakery2018.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BakeryEntities db = new BakeryEntities();
            return View(db.Products.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "About the Bakery";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Bakery contact page.";

            return View();
        }
    }
}