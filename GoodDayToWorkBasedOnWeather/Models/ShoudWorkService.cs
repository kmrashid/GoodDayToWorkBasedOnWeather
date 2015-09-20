using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodDayToWorkBasedOnWeather.Models
{
    public class ShoudWorkService:IShouldWorkService
    {

      public  string IsItAGoodDayToWork(string zipCode)
        {
            string isGoodDayTowork=string.Empty;

            IWeatherRepositary weather = new WeatherRepositary();
            decimal temparature = weather.GetPercentageChanceOfRain(zipCode);
            if(Convert.ToDouble(temparature)>=80|| Convert.ToDouble(temparature)<=70)
            {
                isGoodDayTowork = "Today is a Good Day to work";
                if(Convert.ToDouble(temparature)>=90|| Convert.ToDouble(temparature)<=60)
                {
                    isGoodDayTowork = "Today is a Great Day to work";
                }
            }
            else
            {
                isGoodDayTowork = "Today is a Bad Day to work";
            }


            return isGoodDayTowork;
 
        }
    }
}