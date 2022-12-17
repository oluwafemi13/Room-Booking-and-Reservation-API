namespace Hotel_API.Entities
{
    public class Suite
    {
        public int Id { get; set; }
        public string? SuiteName { get; set; }
        public string? SuiteDescription { get; set; }
        public string BedroomsAvailable { get; set; }
        public int Price { get; set; } = 0;
        public bool smoking { get; set; } 
        public ButlerService Butlerservice { get; set; } = ButlerService.Available;
        public bool AirConditioning { get; set; } 
    }
}
