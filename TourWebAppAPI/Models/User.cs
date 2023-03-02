using System.ComponentModel;
using System.Text.Json.Serialization;

namespace TourWebAppAPI.Models
{
    public class User
    {
        
        public int Id { get; set; } 
        [DisplayName("FirstName")]
        public string FirstName { get; set; }
        [DisplayName("LastName")]
        public string LastName { get; set; }
        public List<Booking> Bookings { get; set; }
        


    }
}
