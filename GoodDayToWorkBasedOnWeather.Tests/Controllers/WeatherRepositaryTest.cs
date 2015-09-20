using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoodDayToWorkBasedOnWeather;
using GoodDayToWorkBasedOnWeather.Controllers;
namespace GoodDayToWorkBasedOnWeather.Tests.Controllers
{
    [TestClass]
    public class WeatherRepositaryTest
    {
        [TestMethod]
        public void GetPercentageOfRain()
        {
            string zipCode ="33417";
            WeatherRepositaryController controller = new WeatherRepositaryController();
            decimal result = controller.GetPercentageOfRain(zipCode);
            Assert.AreEqual(Convert.ToDecimal(80), result);
        }
    }
}
