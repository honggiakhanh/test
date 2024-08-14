using MediaPlayer.Controller;
using MediaPlayer.Infrastructure.src;
using MediaPlayer.Infrastructure.src.Repository;
using MediaPlayer.Service.src.UserManagement;

class Program
{
    public static void main(String[] args)
    {
        var database = new Database();
        var userRepository = new UserRepository(database);
        var userManagement = new UserManagementImplementation(userRepository);
        var userController = new UserController(userManagement);
    }
}
