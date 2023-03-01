using System.Text.Json.Serialization;

namespace TourWebAppAPI.Models
{
    public class Trips
    {
        public int Id { get; set; }
        public int TotalTripsCompleted { get; set; }
        public int TotalTripsPending { get; set; }
        public float TotalMoneySpent { get; set; }
        [JsonIgnore]
        public User User { get; set; }
        public Guid UserId { get; set; }

        public List<Booking> Bookings { get; set; }
    }
}
