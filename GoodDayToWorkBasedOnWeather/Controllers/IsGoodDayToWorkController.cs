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
         [HttpGet]
      public  Models.WorkStatus IsItAGoodDayToWork(int zipCode)
        {
            Models.IShouldWorkService shouldWorkSvc = new Models.ShoudWorkService();
            Models.WorkStatus workStatus = new Models.WorkStatus();
            
            workStatus.goodDayTowWork= shouldWorkSvc.IsItAGoodDayToWork(zipCode.ToString());

            return workStatus;
        }
    }
}
