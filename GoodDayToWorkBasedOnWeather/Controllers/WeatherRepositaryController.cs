using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GoodDayToWorkBasedOnWeather.Controllers
{
    public class WeatherRepositaryController : ApiController
    {
        static readonly Models.IWeatherRepositary weatherRepositary = new Models.WeatherRepositary();

        public decimal GetPercentageOfRain(string zipcode)
        {
            decimal result = weatherRepositary.GetPercentageChanceOfRain(zipcode);
            return result;
        }
    }
}
