using System.Text.Json.Serialization;

namespace TourWebAppAPI.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public bool Completed { get; set; }
        public float Cost { get; set; }
        public DateTime DateCompleted { get; set; }
        [JsonIgnore]
        public Booking Booking { get; set; }
        public int BookingId { get; set; }
       
    }
}
