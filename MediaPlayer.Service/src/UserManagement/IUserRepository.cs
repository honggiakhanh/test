using MediaPlayer.Domain.src.UserAggregate;

namespace MediaPlayer.Service.src.UserManagement
{
    public interface IUserRepository
    {
        public List<User> GetAllUsers();
        public User GetUserById(string id);
        public User AddUser(User user);
        public User UpdateUser(string id, User updatedUser);
        public bool DeleteUser(string id);
    }
}
