namespace Hotel_API.Entities
{
    public class PriceSummary
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string SuiteName { get; set; }
        public string Duration { get; set; }
        public string NumberOfRoomsCollected { get; set; }
    }
}
