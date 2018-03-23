using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bakery2018.Models;

namespace Bakery2018.Controllers
{
    public class RegistrationController : Controller
    {
        BakeryEntities db = new BakeryEntities();

        // GET: Registration
        public ActionResult Index()
        {
            return View(db.People.ToList());

        }
        public ActionResult PeopleList()
        {
            return View(db.People.ToList());

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "PersonFirstName, PersonLastName, PersonEmail,PersonPhone,Personkey")]Person p)
        {
            p.PersonDateAdded = DateTime.Now;
            db.People.Add(p);
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