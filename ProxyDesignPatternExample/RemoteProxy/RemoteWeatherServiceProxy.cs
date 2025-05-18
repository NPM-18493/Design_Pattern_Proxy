public class RemoteWeatherServiceProxy : IRemoteWeatherService
{
    private RemoteWeatherService? _remoteWeatherService = null;

    public async Task<string> GetWeatherData()
    {
        if (_remoteWeatherService == null)
        {
            _remoteWeatherService = new RemoteWeatherService();
        }
        return await _remoteWeatherService.GetWeatherData();
    }
}