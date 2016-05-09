using MoviesACLabs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace MoviesACLabs.Controllers
{
    [RoutePrefix("api/myAward")]
    public class AwardsController : ApiController
    {
        private static int idtemp=1;
        private static int nrElemente = 0;
        public static List<AwardModel> AwardList = new List<AwardModel>();


        [Route("")]
        [ResponseType(typeof(AwardModel))]
        public void PostAward(AwardModel awardModel)
        {
            idtemp++;
            nrElemente++;
            awardModel = new AwardModel { Id = idtemp, Name = "Award1", Info = "info1" };
            AwardList.Add(awardModel);
        }
         
       

       /* public AwardModel GetAward()
       {
            idtemp++;
           return new AwardModel { Id = idtemp, Name = "Award1", Info = "info1" };
        }*/

         public List<AwardModel> GetAwardsList()
         {
            // AwardModel Award = AwardList.find(id);
             //ListAward.add(new AwardModel { Id = 1, Name = "Award1", Info = "info1" } )
             return AwardList;
         }
        public AwardModel GetAwardById(int id)
        {
            for(int i=0;i<nrElemente;i++)
            {
                if (AwardList[i].Id == id)
                {
                    return AwardList[i];
                }
                

            }
            return null;
            
        }

        public void DeleteAward(int id)
        {
            for (int i = 0; i < nrElemente; i++)
            {
                if (AwardList[i].Id == id)
                {
                    AwardList.Remove(AwardList[i]);
                }

            }

        }



    }

}
