using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MoviesACLabs.Entities
{
    public class Award
    {


        public int Id { get; set; }

        public string Name { get; set; }

        public string Info { get; set; }

        public string ActorName { get; set; }

        public virtual IList<Actor> Actors { get; set; }

        // public ActorModel ActorId { get; set; }

    }
}
