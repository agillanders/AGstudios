using AGstudios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AGstudios.Controllers
{
    public class RsvpController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Rsvp
        [Authorize(Roles = "User, Admin")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetPeople()
        {
            
            return Json(db.People.ToList(), JsonRequestBehavior.AllowGet);
        }

        //[HttpPost]
        //public void Confirmed(Person person)
        //{
        //    db.People.Add(person);
        //    db.SaveChanges();
        //}
    }
}