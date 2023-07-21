using Common.Enums;
using DataAggregator.Models.Interfaces;

namespace DataAggregator.Models
{
    public class Tool : IProduct
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public ToolType ToolType { get; set; }

    }
}
