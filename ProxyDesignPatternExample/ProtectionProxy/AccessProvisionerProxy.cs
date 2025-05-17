public class AccessProvisionerProxy : IAccessProvisioner
{
    private AccessProvisioner _accessProvisioner;
    private string _password;

    public AccessProvisionerProxy(string password)
    {
        _password = password;
        _accessProvisioner = new AccessProvisioner();
    }

    public void RequestAccess()
    {
        if (_password == "Admin")
        {
            _accessProvisioner.RequestAccess();
        }
        else
        {
            Console.WriteLine("Access denied.");
        }
    }
}