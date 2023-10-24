using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WeatherPredictionPortfolio.Models;
using Newtonsoft.Json;
using System.Net;

namespace WeatherPredictionPortfolio.Controllers
{
    public class Weather_Application
    {

        string APIKey = "d3edb7f69b9e7be928e7351323884fea";

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q=Joinville,BR&appid={1}", APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root> (json);
            }
        }
    }
}