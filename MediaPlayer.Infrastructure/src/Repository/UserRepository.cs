using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaPlayer.Domain.src.UserAggregate;
using MediaPlayer.Service.src.UserManagement;

namespace MediaPlayer.Infrastructure.src.Repository
{
    public class UserRepository : IUserRepository
    {
        private List<User> _users;

        public UserRepository(Database database)
        {
            _users = database.Users;
        }

        public User AddUser(User user)
        {
            _users.Add(user);
            return user;
        }

        public bool DeleteUser(string id)
        {
            var userToDelete = _users.FirstOrDefault(x => x.Id == new Guid(id));
            if (userToDelete != null)
            {
                throw new Exception("User not found");
            }
            _users.Remove(userToDelete);
            return true;
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }

        public User GetUserById(string id)
        {
            var userToGet = _users.FirstOrDefault(x => x.Id == new Guid(id));
            if (userToGet == null)
            {
                throw new Exception("User not found");
            }
            return userToGet;
        }

        public User UpdateUser(string id, User updatedUser)
        {
            var userToUpdate = _users.FirstOrDefault(x => x.Id == new Guid(id));
            if (userToUpdate == null)
            {
                throw new Exception("User not found");
            }
            userToUpdate.Name = updatedUser.Name;
            userToUpdate.Email = updatedUser.Email;
            userToUpdate.Password = updatedUser.Password;

            return userToUpdate;
        }
    }
}
