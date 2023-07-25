using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Numerics;
using System.Text.RegularExpressions;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        public static void WeatherMapAPI()
        {
            IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            //IConfigurationRoot configuration = builder.Build();
            string apiKey = config.GetSection("AppSettings")["ApiKey"];

            Console.WriteLine("Enter City");
            var cityInput = Console.ReadLine();

            string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={cityInput}&appid={apiKey}&units=imperial";

            var httpClient = new HttpClient();



            var response = httpClient.GetStringAsync(apiUrl).Result;
            var weatherData = JObject.Parse(response);

            Console.WriteLine($" Weather in {cityInput} is {weatherData["main"]["temp"] }");


        }
    }













}
