using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bakery2018.Models;

namespace Bakery2018.Models
{
    public class NewPerson
    {
        public IEnumerable<Models.Person> Person { get; set; }
        public string PersonKey { get; set; }
        public string PersonFirstName { get; set; }
        public string PersonLastName { get; set; }
        public string PersonEmail { get; set; }
        public string PersonPhone { get; set; }
        public string PersonDateAdded { get; set; }





    }
}