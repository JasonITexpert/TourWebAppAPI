using Microsoft.AspNetCore.Mvc;
using TourWebAppAPI.DTOs;
using TourWebAppAPI.Models;

namespace TourWebAppAPI.Controllers
{
    [Route("api/[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public BookingController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult<List<Booking>>> Get(int? userId)
        {
            var Bookings = await _db.Bookings
                .Where(c => c.UserId == userId)
                .Include(c => c.Trip)
                .ToListAsync();
            return Bookings;
        }

        [HttpPost]
        public async Task<ActionResult<Booking>> AddBooking(BookingDto request)
        {
            var user = await _db.Users.FindAsync(request.UserId);
            if (user == null)
            {
                return NotFound();
            }
            var booking = new Booking
            {
                User = user,
                Origin = request.Origin,
                StartDate = request.StartDate,
                EndTime = request.EndTime,
                DayBooked = request.DayBooked,
                Individual = request.Individual,
                GroupSize = request.GroupSize,
                HotelProvided = request.HotelProvided,
                HotelName = request.HotelName,
                TotalBill = request.TotalBill,
                Cancelled = request.Cancelled

            };
            await _db.Bookings.AddAsync(booking);
            await _db.SaveChangesAsync();
            return booking;
        }
    }
}
