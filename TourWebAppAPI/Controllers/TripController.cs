using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TourWebAppAPI.DTOs;
using TourWebAppAPI.Models;

namespace TourWebAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public TripController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Trip>>> Get(int? bookingId)
        {
            var Trips = await _db.Trips
                .Where(c => c.BookingId == bookingId)
                .Include(c => c.Booking)
                .ToListAsync();
            return Trips;
        }
        

        [HttpPost]
        public async Task<ActionResult<Trip>> Post(TripDto request)
        {
            var booking = await _db.Bookings.FindAsync(request.BookingId);
            if(booking == null)
            {
                return NotFound();
            }
            var trip = new Trip
            {
                Completed = request.Completed,
                Cost = request.Cost,
                DateCompleted = request.DateCompleted,
                Booking = booking
                
            };
            await _db.Trips.AddAsync(trip);
            await _db.SaveChangesAsync();
            return trip;

        }
    }
}
