using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WeatherPredictionPortfolio.Models;

namespace WeatherPredictionPortfolio.Controllers
{
    public class WeatherInfo
    {
        public class Name
        {
            public string name { get; set;}
        }

        public class weather
        {
            public string main { get; set;}
            public string description { get; set;}
        }

        public class main
        {
            public double temp { get; set;}
            public double feels_like { get; set;}
            public double temp_min { get; set;}
            public double temp_max { get; set;}
            public double humidity { get; set;}
        }

        public class wind
        {
            public double speed { get; set;}
        }

        public class sys
        {
            public string country { get; set;}
        }

        public class precipitation
        {
            public double value { get; set;}
        }

        public class Dt
        {
            public long dt { get; set;}
        }

        public class root
        {
            public Name name { get; set;}
            public List <weather> weather { get; set;}
            public main main { get; set;}
            public wind wind { get; set;}
            public sys sys { get; set;}
            public precipitation precipitation { get; set;}
            public Dt dt { get; set;}
        }
    }
}