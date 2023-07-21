﻿using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var quote = new QuoteGenerator(client);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Kanye: {quote.Kanye()}");

                Console.WriteLine($"Ron Swanson: {quote.RonSwanson()}");
            }







            Console.WriteLine();



            
                static async Task Main(string[] args)
                {
                    string apiKey = "0c11fa9e259068decee4c0b60db0b2d3";
                    string city = "Houston"; // Change this to your desired city

                    string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=imperial";

                    using var httpClient = new HttpClient();

                    try
                    {
                        var response = await httpClient.GetStringAsync(apiUrl);
                        var weatherData = JObject.Parse(response);

                        var cityName = weatherData["name"];
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






}
