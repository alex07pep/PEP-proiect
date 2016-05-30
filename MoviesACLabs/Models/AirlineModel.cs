using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MoviesACLabs.Models
{
    public class AirlineModel 
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public virtual IList<PlaneModel> Planes { get; set; }

    }
}
