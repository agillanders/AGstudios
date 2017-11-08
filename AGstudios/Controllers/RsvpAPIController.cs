using AGstudios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AGstudios.Controllers
{
    public class RsvpAPIController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetPeople(Person person)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            return Ok(db.People.ToList());
        }
    }
}
