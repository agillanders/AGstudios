using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AGstudios.Models
{
    [Table("Person")]
    public class Person
    {
        public int PersonID { get; set; }

        [DisplayName("Name")]
        public string FirstName { get; set; }

        public string Surname { get; set; }

        [DisplayName("User")]
        public string User { get; set; }

        public string Email { get; set; }

        [DisplayName("Phone")]
        public int PhoneNumber { get; set; }

        [DisplayName("Name|No.")]
        public string HouseNameNumber { get; set; }

        [DisplayName("Street")]
        public string StreetName { get; set; }

        public string Town { get; set; }

        public string County { get; set; }

        [DisplayName("Post Code")]
        public string PostCode { get; set; }
    }
}