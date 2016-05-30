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
    public class PlanesController : ApiController
    {
        public static List<PlaneModel> PlaneList = new List<PlaneModel>();
        private MoviesContext db = new MoviesContext();

        public IHttpActionResult PostPlane(PlaneModel planeModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var plane = Mapper.Map<Plane>(planeModel);

            db.Planes.Add(plane);
            db.SaveChanges();

            return Ok(plane);
        }

        public IList<PlaneModel> GetPlaneList()
        {
            
            var planes = db.Planes;
            var planesModel = Mapper.Map<IList<PlaneModel>>(planes);
            return planesModel;
        }

       /* public IHttpActionResult DeletePlane(int id)
        {
            Plane plane = db.Planes.Find(id);
            if (plane == null)
            {
                return NotFound();
            }

            db.Planes.Remove(plane);
            db.SaveChanges();

            return Ok();

        }*/



    }
}
