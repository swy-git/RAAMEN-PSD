using System.Runtime.Serialization;

namespace PSD_Project.Features.Users
{
    [DataContract]
    public class User
    {
        [DataMember]
        public readonly int Id;
        [DataMember]
        public readonly string Username;
        [DataMember]
        public readonly string Email;
        [DataMember]
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