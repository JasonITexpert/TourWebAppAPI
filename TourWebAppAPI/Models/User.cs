using System.ComponentModel;
using System.Text.Json.Serialization;

namespace TourWebAppAPI.Models
{
    public class User
    {
        public enum Genders
        {
            Male, Female
        }
        public Guid Id { get; set; } = new Guid();
        [DisplayName("FirstName")]
        public string FirstName { get; set; }
        [DisplayName("LastName")]
        public string LastName { get; set; }
        public Genders Gender { get; set; }
        [JsonIgnore]
        public List<Booking> Bookings { get; set; }
        


    }
}
