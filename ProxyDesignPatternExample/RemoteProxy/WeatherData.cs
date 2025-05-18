public class WeatherData
{
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
    public double GenerationTime_Ms { get; set; }
    public int Utc_Offset_Seconds { get; set; }
    public string Timezone { get; set; }
    public string Timezone_Abbreviation { get; set; }
    public double Elevation { get; set; }

    public CurrentWeather Current { get; set; }
    public Units Current_Units { get; set; }
    public HourlyWeather Hourly { get; set; }
    public Units Hourly_Units { get; set; }

    public class CurrentWeather
    {
        public string Time { get; set; }
        public int Interval { get; set; }
        public double Temperature_2m { get; set; }
        public double Wind_Speed_10m { get; set; }
    }

    public class Units
    {
        public string Time { get; set; }
        public string Interval { get; set; }
        public string Temperature_2m { get; set; }
        public string Wind_Speed_10m { get; set; }
        public string RelativeHumidity2m { get; set; }
    }

    public class HourlyWeather
    {
        public List<string> Time { get; set; }
        public List<double> Temperature_2m { get; set; }
        public List<int> Relative_Humidity_2m { get; set; }
        public List<double> Wind_Speed_10m { get; set; }
    }
}