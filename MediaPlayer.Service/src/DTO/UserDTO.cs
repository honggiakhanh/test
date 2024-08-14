using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaPlayer.Domain.src.UserAggregate;

namespace MediaPlayer.Service.src.DTO
{
    public class UserDTO
    {
        public class UserGetDTO
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public List<Playlist> Playlists { get; set; }

            public UserGetDTO(User user)
            {
                Id = user.Id;
                Name = user.Name;
                Email = user.Email;
                Playlists = user.Playlists;
            }
        }

        public class UserAddDTO
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public List<Playlist> Playlists { get; set; }

            public User ConvertToUser()
            {
                return new User
                {
                    Id = new Guid(),
                    Name = Name,
                    Email = Email,
                    Password = Password,
                    Playlists = Playlists
                };
            }
        }

        public class UserUpdateDTO
        {
            private UserUpdateDTO updatedUser;

            public string Name { get; set; }
            public string Password { get; set; }
            public List<Playlist> Playlists { get; set; }

            public UserUpdateDTO(User user)
            {
                Name = user.Name;
                Password = user.Password;
                Playlists = user.Playlists;
            }
        }
    }
}
