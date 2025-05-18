public interface IRemoteWeatherService
{
    Task<string> GetWeatherData();
}