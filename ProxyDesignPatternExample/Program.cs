// See https://aka.ms/new-console-template for more information

//Valid password
IAccessProvisioner proxy = new AccessProvisionerProxy("Admin");
proxy.RequestAccess();

//Invalid password
proxy = new AccessProvisionerProxy("User");
proxy.RequestAccess();
