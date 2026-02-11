namespace ProseperApp.Repositories.Implementations
{
    public class UserRepository: IUserRepository
    {
        public bool IsExist(string email)
        {
            foreach(var item in ProsperContext.User) 
            {
                if(item.Email == email)
                {
                    return true;
                }
            }
            return false;
        }

        public void Add(User user)
        {
            ProsperContext.Users.Add();
        }

        public User? GetUser(string email)
        {
            foreach (var item in AbcContext.Users)
            {
                if(item.Email == email)
                {
                    return item;
                }
            }
            return null;
        }
        
       public int UsersCount()
       {
            return ProsperContext.Users.Count;
       }

    }
}