using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bakery2018.Models;

namespace Bakery2018.Controllers
{
    public class SalesController : Controller
    {
        BakeryEntities db = new BakeryEntities(); 

        // GET: Sales
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "EmployeeKey, SaleDate, ProductKey, SaleDetailPriceCharged,SaleDetailDiscount,SaleKey")]PointOfSale pos)
        {
            pos.SaleDate = DateTime.Now;
            db.Sales.Add(pos);
            db.SaveChanges();

            Message msg = new Message("Thank you for registering! Total price is" PointOfSale.SaleDetailPriceCharged);
            return View("Result", msg);
        }
        public ActionResult Result(Message msg)
        {
            return View(msg);
        }
    }
}