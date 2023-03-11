namespace PSD_Project.Features.Users
{
    public class User
    {
        public readonly int Id;
        public readonly string Username;
        public readonly string Email;
        public readonly string Gender;

        public User(int id, string username, string email, string gender)
        {
            Id = id;
            Username = username;
            Email = email;
            Gender = gender;
        }
    }
}