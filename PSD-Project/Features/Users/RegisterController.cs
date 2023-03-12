using System;
using System.Linq;
using System.Net;
using System.Web.Http;
using Newtonsoft.Json;

namespace PSD_Project.Features.Users
{
    public class RegisterController : ApiController
    {
        public class RegistrationFormDetails
        {
            public string Username { get; set; }
            public string Email { get; set; }
            public string Gender { get; set; }
            public string Password { get; set; }

            public RegistrationFormDetails(string username, string email, string gender, string password)
            {
                Username = username;
                Email = email;
                Gender = gender;
                Password = password;
            }
        }
        
        private readonly Raamen _db = new Raamen();
        
        [Route("api/register")]
        [HttpPost]
        public IHttpActionResult RegisterNewUser([FromBody] RegistrationFormDetails form)
        {
            if (form == null) return BadRequest();

            if (_db.Users.Select(user => user.Email).Contains(form.Email)) return StatusCode(HttpStatusCode.Conflict);

            _db.Users.Add(new PSD_Project.User
            {
                Username = form.Username,
                Email = form.Email,
                Gender = form.Gender,
                Password = form.Password,
                Roleid = 0
            });

            try
            {
                _db.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return InternalServerError();
            }
        }
    }
}