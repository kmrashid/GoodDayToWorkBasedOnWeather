using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GoodDayToWorkBasedOnWeather.Controllers
{
    public class IsGoodDayToWorkController : ApiController
    {
        public string Get()
        {
            return "Please enter a valid zip code";
        }

      public Models.WorkStatus Get(int id)
        {
            Models.IShouldWorkService shouldWorkSvc = new Models.ShoudWorkService();
            Models.WorkStatus workStatus = new Models.WorkStatus();
            
            workStatus.goodDayTowWork= shouldWorkSvc.IsItAGoodDayToWork(id.ToString());

            return workStatus;
        }


    }
}
