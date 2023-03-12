using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Util.Option;

namespace PSD_Project.Features.Users
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        private readonly Raamen _db = new Raamen();

        [Route]
        [HttpGet]
        public IEnumerable<User> GetAllUsers()
        {
            return _db.Users
                .Select(ConvertModel)
                .ToList();
        }
        
        [Route("{id}")]
        [HttpGet]
        public IHttpActionResult GetUser(int id)
        {
            return _db.Users
                .FirstOrDefault(u => u.Id == id)
                .ToOption()
                .Map(ConvertModel)
                .Map(Ok)
                .Cast<IHttpActionResult>()
                .OrElse(NotFound());
        }

        [HttpGet]
        public IEnumerable<User> GetUsersWithRole([FromUri] int roleId)
        {
            return _db.Roles
                .Where(role => role.id == roleId)
                .Join(_db.Users,
                    role => role.id,
                    user => user.Roleid,
                    (role, user) => user)
                .AsEnumerable()
                .Select(ConvertModel)
                .ToList();
        }

        private User ConvertModel(PSD_Project.User user) => new User(user.Id, user.Username, user.Email, user.Gender);
    }
}