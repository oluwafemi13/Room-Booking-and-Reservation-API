using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_API.Entities
{
    public class BookingDetail:Common
    {
        public string Id { get; set; }
        public string ArrivalTime { get; set; }
        public string Purpose { get; set; }
        [MaxLength(100)]
        public string AdditionalRequirements { get; set; }
        public string Duration { get; set; }
        public DateTime CheckIn { get; set; } = DateTime.Now;
        public DateTime CheckOut { get; set; }

        /*[ForeignKey("User")]
        public int UserId { get; set; }
        public int MyProperty { get; set; }*/
    }
}
