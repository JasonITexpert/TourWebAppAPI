using Microsoft.EntityFrameworkCore;

namespace TourWebAppAPI.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {

        }
    }
}
