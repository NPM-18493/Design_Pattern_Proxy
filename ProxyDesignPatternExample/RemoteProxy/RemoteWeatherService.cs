using System.Net.Http;
public class RemoteWeatherService : IRemoteWeatherService
{
    private readonly HttpClient _httpClient= new HttpClient();
    public async Task<string> GetWeatherData()
    {
        string apiUrl = "https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&current=temperature_2m,wind_speed_10m&hourly=temperature_2m,relative_humidity_2m,wind_speed_10m";

        return await _httpClient.GetStringAsync(apiUrl);
    }
}