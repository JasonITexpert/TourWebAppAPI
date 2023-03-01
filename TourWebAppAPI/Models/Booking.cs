using System.Text.Json.Serialization;

namespace TourWebAppAPI.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string Origin { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime DayBooked { get; set; } = DateTime.Now;
        public bool Individual { get; set; }
        public int GroupSize { get; set; }
        public bool HotelProvided { get; set; }
        public string? HotelName { get; set; }
        public float TotalBill { get; set; }
        public bool Cancelled { get; set; }
      
        public User User { get; set; }
        public Guid UserId { get; set; }
        
    }
}
