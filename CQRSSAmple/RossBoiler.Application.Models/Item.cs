namespace RossBoiler.Application.Models
{
    public class Item
    {
        public int ID { get; set; }
        public required string? Name { get; set; }
        public Decimal Price { get; set; }

    }
}
