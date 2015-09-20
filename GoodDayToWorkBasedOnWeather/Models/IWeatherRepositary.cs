using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodDayToWorkBasedOnWeather.Models
{
    interface IWeatherRepositary
    {
        decimal GetPercentageChanceOfRain(string zipCode);
    }
}
