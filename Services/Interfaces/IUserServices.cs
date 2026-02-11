namespace ProseperApp.Services.Interfaces
{
    public interface IUserServices
    {
        User? Login(string email, string password);
    }   
}