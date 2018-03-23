using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bakery2018.Models;

namespace Bakery2018.Controllers
{
    public class ProductsController : Controller
    {
        BakeryEntities db = new BakeryEntities();


        // GET: Products
        public ActionResult Index()
        {
            BakeryEntities db = new BakeryEntities();
            return View(db.Products.ToList());
        }
        public ActionResult Register()
        {
            BakeryEntities db = new BakeryEntities();
            return View(db.Products.ToList());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "ProductName, ProductPrice, ProductKey")]Product pr)
        {
            db.Products.Add(pr);
            db.SaveChanges();

            Message msg = new Message("Thank you for registering!");
            return View("Result", msg);
        }
        public ActionResult Result(Message msg)
        {
            return View(msg);
        }
    }
}