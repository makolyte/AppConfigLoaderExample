using System;
using System.Configuration;

namespace WeatherClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = (WeatherClientConfig)ConfigurationManager.GetSection(nameof(WeatherClientConfig));

            Console.WriteLine(config.WeatherAPIUrl);
            Console.WriteLine(config.IsEnabled);
            Console.WriteLine(config.Timeout);
        }
    }
}
