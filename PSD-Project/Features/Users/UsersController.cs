using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Util.Option;

namespace PSD_Project.Features.Users
{
    public class UsersController : ApiController
    {
        private readonly List<User> _users = new List<User>
        {
            new User
            {
                Id = 0,
                Roleid = null,
                Role = null,
                Username = "test_1",
                Email = "hi@1",
                Gender = "",
                Password = ""
            },
            new User
            {
                Id = 1,
                Roleid = null,
                Role = null,
                Username = "test_2",
                Email = "hi@2",
                Gender = "",
                Password = ""
            }
        };

        public IEnumerable<User> GetAllUsers() => _users;

        public IHttpActionResult GetUser(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id)
                .ToOption()
                .Map(Ok)
                .Cast<IHttpActionResult>()
                .OrElse(NotFound());
        }
    }
}