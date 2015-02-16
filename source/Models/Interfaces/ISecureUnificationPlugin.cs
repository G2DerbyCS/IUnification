namespace IUnification.Models.Interfaces
{
    interface ISecureUnificationPlugin : IUnificationPlugin
    {
        // impliment dictionary like structure for required fields and feild types
        bool AuthenticateUser(string[] FieldValues);
    }
}
