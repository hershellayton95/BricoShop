using Common.Enums;

namespace Common.DTOs
{
    public class ItemDTO
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public ItemType ItemType { get; set; }
    }
}
