using MediaPlayer.Domain.src.MediaAggregate;

namespace MediaPlayer.Domain.src.UserAggregate
{
    public class Admin : User
    {
        public void AddMediaFile(MediaFile mediaFile)
        {
            Console.WriteLine($"Added Media File ${mediaFile.Name} : ${mediaFile.Id}");
        }

        public void RemoveMediaFile(MediaFile mediaFile)
        {
            Console.WriteLine($"Removed Media File ${mediaFile.Name} : ${mediaFile.Id}");
        }

        public void AddUser(User user)
        {
            Console.WriteLine($"Added User ${user.Name} : ${user.Id}");
        }

        public void RemoveUser(User user)
        {
            Console.WriteLine($"Removed User ${user.Name} : ${user.Id}");
        }
    }
}
