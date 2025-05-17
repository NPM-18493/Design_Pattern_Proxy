public class ProxyAPIData : IAPIData
{
    private string? _data = null;

    public string GetData()
    {
        if (_data == null)
        {
            System.Threading.Thread.Sleep(5000);
            _data = "Fetched data from API"; //This will be replaced by actual API call
        }
        return _data;
    }
}