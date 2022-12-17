using Hotel_API.Entities;
using System.ComponentModel.DataAnnotations;

namespace Hotel_API.DTO
{
    public class SuiteDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string? SuiteName { get; set; }
        [Required]
        public string? SuiteDescription { get; set; }
        [Required]
        public string BedroomsAvailable { get; set; }
        [Required]
        public int Price { get; set; } = 0;
        
        public bool smoking { get; set; }
        public ButlerService service { get; set; } = ButlerService.Available;
        public bool AirConditioning { get; set; }
    }
}
