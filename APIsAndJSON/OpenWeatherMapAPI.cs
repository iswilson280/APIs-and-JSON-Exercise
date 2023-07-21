using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    
    {
        static async Task Main(string[] args)
        {
            string apiKey = "4009242f8b913393abeec177a725f48b";
            string city = "London";

            string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q=London,uk&APPID=4009242f8b913393abeec177a725f48b";

            using var httpClient = new HttpClient();

            try
            {
                var response = await httpClient.GetStringAsync(apiUrl);
                var weatherData = JObject.Parse(response);

                var cityName = weatherData["London"];
                var description = weatherData["weather"][0]["description."];
                var temperature = weatherData["main"]["temp"];

                Console.WriteLine($"Current Weather in {cityName}:");
                Console.WriteLine($"Description: {description}");
                Console.WriteLine($"Temperature: {temperature} °F");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
    
}
