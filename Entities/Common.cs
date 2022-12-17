using System.ComponentModel.DataAnnotations;

namespace Hotel_API.Entities
{
    public class Common
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
