using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MoviesACLabs.Data;
using AutoMapper;
using MoviesACLabs.Entities;
using MoviesACLabs.Models;

namespace MoviesACLabs.Controllers
{
    public class AirlinesController : ApiController
    {
        public static List<AirlineModel> AirlineList = new List<AirlineModel>();
        private MoviesContext db = new MoviesContext();

        public IHttpActionResult PostAirline(AirlineModel airlineModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var airline = Mapper.Map<Airline>(airlineModel);

            db.Airlines.Add(airline);
            db.SaveChanges();

            return Ok(airline);
        }

        public IList<AirlineModel> GetAirlineList()
        {

            var airlines = db.Airlines;
            var airlinesModel = Mapper.Map<IList<AirlineModel>>(airlines);
            return airlinesModel;
        }

        public IHttpActionResult DeleteAirline(string id)
        {
            Airline airline = db.Airlines.Find(id);
            if (airline == null)
            {
                return NotFound();
            }

            db.Airlines.Remove(airline);
            db.SaveChanges();

            return Ok();

        }


    }
}
