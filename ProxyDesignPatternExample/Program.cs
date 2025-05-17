// See https://aka.ms/new-console-template for more information

#region Protection Proxy
//Valid password
IAccessProvisioner proxy = new AccessProvisionerProxy("Admin");
proxy.RequestAccess();

//Invalid password
proxy = new AccessProvisionerProxy("User");
proxy.RequestAccess();

#endregion

#region Virtual Proxy
IAPIData aPIData = new ProxyAPIData();

Console.WriteLine("First time, this call will take 5 seconds to fetch data");
Console.WriteLine(aPIData.GetData());

Console.WriteLine("Second time, this call will be instant");
Console.WriteLine(aPIData.GetData());
#endregion
