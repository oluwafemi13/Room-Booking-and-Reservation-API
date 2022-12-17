using Hotel_API.Entities;
using System.ComponentModel.DataAnnotations;

namespace Hotel_API.DTO
{
    public class UserDTO
    {
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

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Occupation { get; set; }
    }
}
