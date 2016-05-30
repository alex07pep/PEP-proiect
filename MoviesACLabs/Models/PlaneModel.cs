using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MoviesACLabs.Models
{
    public class PlaneModel 
    {
        public int Seats { get; set; }

        public string Model { get; set; }
    }
}
