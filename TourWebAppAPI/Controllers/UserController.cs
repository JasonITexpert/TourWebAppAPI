using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TourWebAppAPI.DTOs;
using TourWebAppAPI.Models;

namespace TourWebAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<User>> Get(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var user = await _db.Users.FindAsync(id);
            return user;
        }


        [HttpPost]
        public async Task<ActionResult<List<User>>> Add(UserDTO userobj)
        {
            User user = new User
            {
                FirstName = userobj.FirstName,
                LastName = userobj.LastName
            };
            await _db.Users.AddAsync(user);
            await _db.SaveChangesAsync();
            return _db.Users.ToList();
        }
    }
}
