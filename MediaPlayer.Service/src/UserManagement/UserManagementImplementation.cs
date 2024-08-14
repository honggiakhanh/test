using MediaPlayer.Domain.src.UserAggregate;
using static MediaPlayer.Service.src.DTO.UserDTO;

namespace MediaPlayer.Service.src.UserManagement
{
    public class UserManagementImplementation : IUserManagement
    {
        private IUserRepository _userRepository;

        public UserManagementImplementation(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserGetDTO AddUser(UserAddDTO user)
        {
            var newUser = user.ConvertToUser();

            _userRepository.AddUser(newUser);

            var userGetDTO = new UserGetDTO(newUser);

            return userGetDTO;
        }

        public bool DeleteUser(string id)
        {
            var userToDelete = _userRepository.GetUserById(id);
            if (userToDelete == null)
            {
                throw new Exception("User not found");
            }

            _userRepository.DeleteUser(id);
            return true;
        }

        public List<UserGetDTO> GetAllUsers()
        {
            var allUserGetDTO = _userRepository
                .GetAllUsers()
                .Select(x => new UserGetDTO(x))
                .ToList();
            return allUserGetDTO;
        }

        public UserGetDTO GetUserById(string id)
        {
            var userGetDTO = new UserGetDTO(_userRepository.GetUserById(id));
            return userGetDTO;
        }

        public UserUpdateDTO UpdateUser(string id, UserUpdateDTO updatedUser)
        {
            var userToUpdate = _userRepository.GetUserById(id);
            if (userToUpdate == null)
            {
                throw new Exception("User not found");
            }

            userToUpdate.Name = updatedUser.Name;
            userToUpdate.Password = updatedUser.Password;
            userToUpdate.Playlists = updatedUser.Playlists;

            return new UserUpdateDTO(userToUpdate);
        }
    }
}
