using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;

namespace GoodDayToWorkBasedOnWeather.Models
{
    public class WeatherRepositary:IWeatherRepositary
    {
        // These code snippets use an open-source library. http://unirest.io/net
        //Task<HttpResponse<MyClass>> response = Unirest.get("https://weather2020-weather-v1.p.mashape.com/zip/e8ecee8ff60c478f8a36280fea0524fe/66214")
        //.header("X-Mashape-Key", "7gnMV0Y8R4mshZXzPJarNhyk4cKVp1aNBbVjsnLk8miipGhcgf")
        //.header("Accept", "application/json")
        //.asJson();

        //GEThttps://weather2020-weather-v1.p.mashape.com/zip/e8ecee8ff60c478f8a36280fea0524fe/{zip}
        //readonly static WeatherRepositary weatherRepositary = new WeatherRepositary();


        decimal IWeatherRepositary.GetPercentageChanceOfRain(string zipCode)
        {
            var client = new RestSharp.RestClient("https://weather2020-weather-v1.p.mashape.com/zip/e8ecee8ff60c478f8a36280fea0524fe/"+zipCode);
            var request = new RestRequest( Method.GET) { RequestFormat = DataFormat.Json };
            request.AddHeader("X-Mashape-Key", "7gnMV0Y8R4mshZXzPJarNhyk4cKVp1aNBbVjsnLk8miipGhcgf");
            var response = client.Execute<List<WeatherData>>(request);

            WeatherData todayWeather = (WeatherData)response.Data.First();

            return Convert.ToDecimal(todayWeather.temperatureHigh);


            
            //throw new NotImplementedException();
        }
    }
}