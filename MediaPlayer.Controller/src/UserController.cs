using System.Text.Json;
using MediaPlayer.Service.src.UserManagement;
using static MediaPlayer.Service.src.DTO.UserDTO;

namespace MediaPlayer.Controller
{
    public class UserController
    {
        private IUserManagement _userManagement;

        public UserController(IUserManagement userManagement)
        {
            _userManagement = userManagement;
        }

        public UserGetDTO GetUserById(string id)
        {
            return _userManagement.GetUserById(id);
        }

        public UserGetDTO AddUser(string userJson)
        {
            var userAddDTO = JsonSerializer.Deserialize<UserAddDTO>(userJson);

            if (userAddDTO == null || string.IsNullOrEmpty(userAddDTO.Name))
            {
                throw new Exception("Failed to parse user data.");
            }

            return _userManagement.AddUser(userAddDTO);
        }

        public UserUpdateDTO UpdateUser(string id, string newUserJson)
        {
            if (_userManagement.GetUserById(id) == null)
            {
                throw new Exception("User not found.");
            }

            var userUpdateDTO = JsonSerializer.Deserialize<UserUpdateDTO>(newUserJson);

            if (userUpdateDTO == null || string.IsNullOrEmpty(userUpdateDTO.Name))
            {
                throw new Exception("Failed to parse user data.");
            }

            return _userManagement.UpdateUser(id, userUpdateDTO);
        }

        public bool DeleteUser(string id)
        {
            return _userManagement.DeleteUser(id);
        }
    }
}
