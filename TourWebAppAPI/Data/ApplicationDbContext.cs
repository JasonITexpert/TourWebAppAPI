using Microsoft.EntityFrameworkCore;
using TourWebAppAPI.Models;

namespace TourWebAppAPI.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Trip> Trips { get; set; }
    }
}
