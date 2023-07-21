using Common.Enums;
using DataAggregator.Models.Interfaces;

namespace DataAggregator.Models
{
    public class Item : IProduct
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public ItemType ItemType { get; set; }
    }
}
