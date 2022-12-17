using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_API.Entities
{
    public class User:Common
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Title title { get; set; } = Title.Mr;
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        public DateTime DOB { get; set; }

        public string Occupation { get; set; }

        public IEnumerable<ContactAddress> Contact { get; set; }
        public IEnumerable<BookingDetail>Bookingdetails { get; set; }

    }
}
