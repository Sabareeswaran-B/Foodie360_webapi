using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Foodie360.Models;
using System.IdentityModel.Tokens.Jwt;

namespace Foodie360.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly JwtSettings jwtSettings;
        private readonly foodieContext _context;

        public AccountController(JwtSettings jwtSettings, foodieContext context)
        {
            this.jwtSettings = jwtSettings;
            _context = context;
        }

        [HttpPost]
        public IActionResult Login(UserLogins userLogins)
        {
            try
            {
                var Token = new UserTokens();
                var query = from u in _context.Users select u;
                var Valid = query.Any(x => x.PhoneNo == userLogins.PhoneNo);
                if (Valid)
                {
                    var user = query.FirstOrDefault(x => x.PhoneNo == userLogins.PhoneNo);
                    if (BCrypt.Net.BCrypt.Verify(userLogins.Password, user!.PassWord))
                    {
                        Token = JwtHelpers.JwtHelpers.GenTokenkey(
                            new UserTokens()
                            {
                                PhoneNo = user!.PhoneNo,
                                GuidId = Guid.NewGuid(),
                                UserName = user.UserName,
                                Id = user.UserId,
                                UserRole = user.UserRole,
                            },
                            jwtSettings
                        );
                    }
                    else
                    {
                        return BadRequest("wrong password");
                    }
                }
                else
                {
                    return BadRequest("Invalid phone number");
                }
                return Ok(Token);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        /// <summary>
        /// Get List of UserAccounts
        /// </summary>
        /// <returns>List Of UserAccounts</returns>
        [HttpGet]
        [Authorize(
            AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme
        )]
        public IActionResult GetList()
        {
            var query = from u in _context.Users select u;
            return Ok(query);
        }

        [HttpGet]
        [Authorize(
            AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme
        )]
        public IActionResult Logout()
        {
            var authorization = Request.Headers.Authorization;
            var token = authorization[0].Split(" ")[1];
            var jwthandler = new JwtSecurityTokenHandler();
            var read = jwthandler.ReadJwtToken(token);
            return Ok(read);
        }
    }
}
