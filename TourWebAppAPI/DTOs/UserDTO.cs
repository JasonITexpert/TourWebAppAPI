using System.ComponentModel;

namespace TourWebAppAPI.DTOs
{
    public class UserDTO
    {
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
    }
}
