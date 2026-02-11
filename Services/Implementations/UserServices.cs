namespace ProseperApp.Services.Implementations
{
    public class UserServices
    {
        IUserRepository userRepository = new IUserRepository();

        public User? Login(string email, string password)
        {
            var user = userRepository.GetUser(email);
            
            if(user == null)
            {
                return null;
            }
            if(user.Password != password)
            {
                return null;
            }

            return user;
        }   
    }
}