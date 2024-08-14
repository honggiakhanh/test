using MediaPlayer.Domain.src.UserAggregate;
using static MediaPlayer.Service.src.DTO.UserDTO;

namespace MediaPlayer.Service.src.UserManagement
{
    public interface IUserManagement
    {
        public List<UserGetDTO> GetAllUsers();
        public UserGetDTO GetUserById(string id);
        public UserGetDTO AddUser(UserAddDTO user);
        public UserUpdateDTO UpdateUser(string id, UserUpdateDTO updatedUser);
        public bool DeleteUser(string id);
    }
}
