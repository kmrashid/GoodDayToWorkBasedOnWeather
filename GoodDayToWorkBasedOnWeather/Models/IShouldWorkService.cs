﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodDayToWorkBasedOnWeather.Models
{
    interface IShouldWorkService
    {
        string IsItAGoodDayToWork(string zipCode);
        IWeatherRepositary isItAGoodDayTowork(string zipcode);
        //This is a test
    }
}
