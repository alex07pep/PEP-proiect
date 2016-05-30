using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MoviesACLabs.Entities
{
    public class Airline
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public virtual IList<Plane> Planes { get; set; }
    }
}
