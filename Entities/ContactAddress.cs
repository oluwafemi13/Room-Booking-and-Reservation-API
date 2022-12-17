using System.ComponentModel.DataAnnotations;

namespace Hotel_API.Entities
{
    public class ContactAddress:Common
    {
        public Guid Id { get; set; }

        [Required]
        public string AddressLine1 { get; set; }

        [Required]
        public string AddressLine2 { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }
    }
}
