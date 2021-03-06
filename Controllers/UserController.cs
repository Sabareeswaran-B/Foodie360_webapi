#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Foodie360.Models;
using Foodie360.Services;
using Microsoft.AspNetCore.Authorization;

namespace Foodie360.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
     [Authorize(
            AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme
        )]
    public class UserController : ControllerBase
    {
        private readonly foodieContext _context;

        private readonly IMailService _mailService;

        public UserController(foodieContext context, IMailService mailService)
        {
            _context = context;
            _mailService = mailService;
        }

        // GET: api/User
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/User/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.UserId)
            {
                return BadRequest();
            }
            string password = user.PassWord;
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            user.PassWord = passwordHash;

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/User
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            var mail = new MailRequest();
            mail.ToEmail = user.Email;
            mail.Subject = "Welcome to Foodie360";
            mail.Body =
                $"<h3>Hello {user.UserName},</h3><br><p>Welcome to the India's favourite online food ordering service.</p><br>Enjoy the most delicious food being made in your own locality delivered at your door steps.</br>";
            await _mailService.SendEmailAsync(mail);
            string password = user.PassWord;
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            user.PassWord = passwordHash;
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.UserId }, user);
        }

        // DELETE: api/User/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.UserId == id);
        }
    }
}
