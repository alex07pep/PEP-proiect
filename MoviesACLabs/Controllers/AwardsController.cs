using MoviesACLabs.Models;
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

namespace MoviesACLabs.Controllers
{
    [RoutePrefix("api/myAward")]
    public class AwardsController : ApiController
    {
        private static int idtemp=1;
        private static int nrElemente = 0;
        public static List<AwardModel> AwardList = new List<AwardModel>();
        private MoviesContext db = new MoviesContext();

        [Route("")]
        [ResponseType(typeof(AwardModel))]
        public IHttpActionResult PostAward(AwardModel awardModel)
        {
           /* idtemp++;
            nrElemente++;
            awardModel = new AwardModel { Id = idtemp, Name = "Award1", Info = "info1" };
            AwardList.Add(awardModel);
            */
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var award = Mapper.Map<Award>(awardModel);

            db.Awards.Add(award);
            db.SaveChanges();

            return Ok(award) ;
        }
         
       

       /* public AwardModel GetAward()
       {
            idtemp++;
           return new AwardModel { Id = idtemp, Name = "Award1", Info = "info1" };
        }*/

         public IList<AwardModel> GetAwardsList()
         {
            // AwardModel Award = AwardList.find(id);
            //ListAward.add(new AwardModel { Id = 1, Name = "Award1", Info = "info1" } )
            //return AwardList;
            var awards = db.Awards;
            var awardsModel = Mapper.Map<IList<AwardModel>>(awards);
            return awardsModel;
        }
         public IHttpActionResult GetAwardById(int id)
         {

             Award award = db.Awards.Find(id);
             if (award == null)
             {
                 return NotFound();
             }

             var awardModel = Mapper.Map<AwardModel>(award);

             return Ok(awardModel);

         }
        [Route("Filter")]
        public IList<AwardModel> GetAward(string idm)
        {
            var awards = db.Awards;
            var awardsModel = Mapper.Map<IList<AwardModel>>(awards);
            //return awardsModel;
           // foreach (var v in from p in awardsModel where p.Id > idm select new { p.Name, p.Info })
                //return Ok(v);
            var result= awardsModel.Where(x => x.ActorName==idm).ToList();
            return result;
        }
        //Get all awards for all actors
        [Route("act")]
        public void GetAwardActors()
        {
            var actors = db.Actors;
            var actorsModel = Mapper.Map<IList<ActorModel>>(actors);
            //return actorsModel;
            foreach (ActorModel item in actorsModel)
            {
                //return item.Name;
                GetAward(item.Name);
            }
        }

        public IHttpActionResult DeleteAward(int id)
        {
            Award award = db.Awards.Find(id);
            if (award == null)
            {
                return NotFound();
            }

            db.Awards.Remove(award);
            db.SaveChanges();

            return Ok();

        }



    }

}
