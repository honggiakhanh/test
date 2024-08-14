using MediaPlayer.Domain.src.MediaAggregate;
using MediaPlayer.Domain.src.UserAggregate;

namespace MediaPlayer.Infrastructure.src
{
    public class Database
    {
        public List<User> Users;
        public List<MediaFile> MediaFiles;

        public Database()
        {
            Users = new List<User>();
            MediaFiles = new List<MediaFile>();
        }
    }
}
