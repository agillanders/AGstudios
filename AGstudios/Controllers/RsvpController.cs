using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AGstudios.Controllers
{
    public class RsvpController : Controller
    {
        // GET: Rsvp
        [Authorize(Roles = "User, Admin")]
        public ActionResult Index()
        {
            return View();
        }
    }
}