namespace WeatherClient
{
    public class WeatherClientConfig
    {
        public bool IsEnabled { get; set; } = false;
        public string WeatherAPIUrl { get; set; }
        public string Timeout { get; set; }
    }
}
