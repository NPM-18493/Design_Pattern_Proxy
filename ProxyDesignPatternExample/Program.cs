// See https://aka.ms/new-console-template for more information
using System.Text.Json;

#region Protection Proxy
Console.WriteLine("~~~~~~~~~Protection Proxy Example~~~~~~~~~");
//Valid password
IAccessProvisioner proxy = new AccessProvisionerProxy("Admin");
proxy.RequestAccess();

//Invalid password
proxy = new AccessProvisionerProxy("User");
proxy.RequestAccess();

#endregion

#region Virtual Proxy
Console.WriteLine("~~~~~~~~~Virtual Proxy Example~~~~~~~~~");
IAPIData aPIData = new ProxyAPIData();

Console.WriteLine("First time, this call will take 5 seconds to fetch data");
Console.WriteLine(aPIData.GetData());

Console.WriteLine("Second time, this call will be instant");
Console.WriteLine(aPIData.GetData());
#endregion

#region Remote Proxy
Console.WriteLine("~~~~~~~~~Remote Proxy Example~~~~~~~~~");
IRemoteWeatherService RemoteWeatherProxy = new RemoteWeatherServiceProxy();

var data = await RemoteWeatherProxy.GetWeatherData();
var jsonData = JsonSerializer.Deserialize<WeatherData>(data, new JsonSerializerOptions
{
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
});

Console.WriteLine(String.Format("Current temperature: {0}",jsonData?.Current?.Temperature_2m));
#endregion
