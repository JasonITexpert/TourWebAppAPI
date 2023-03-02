namespace TourWebAppAPI.DTOs
{
    public class TripDto
    {
        public bool Completed { get; set; }
        public float Cost { get; set; }
        public DateTime DateCompleted { get; set; }
        public int BookingId { get; set; }
    }
}
