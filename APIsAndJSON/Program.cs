using Newtonsoft.Json.Linq;

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

            OpenWeatherMapAPI.WeatherMapAPI();
        }


        
        

    }






}
