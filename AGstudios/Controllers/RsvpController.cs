﻿using AGstudios.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        [HttpPost]
        public void Confirmed(Person person)
        {
            var model = db.People.FirstOrDefault(x => x.PersonID == person.PersonID);
            if (model != null)
            {
                model.PersonID = person.PersonID;
                model.Confirmed = person.Confirmed;
                db.SaveChanges();
            }else
            {
                ViewBag.ErrorMessage = "Error, you have not confirmed!";
            }
        }
        
        [HttpPost]
        public void Reset(List<Person> person)
        {
            if (person != null)
            {
                foreach (var p in person)
                {
                    var reset = db.People.FirstOrDefault(x => x.Confirmed == true && x.PersonID == p.PersonID);
                    if (p.Confirmed == true)
                    {
                        reset.Confirmed = false;
                    }
                }
                db.SaveChanges();
            }
            else
            {
                ViewBag.ErrorMessage = "Error, Invitees not deselected!";
            }
        }
    }
}