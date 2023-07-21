using Common.Enums;

namespace Common.DTOs
{
    public class ToolDTO
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public ToolType ToolType { get; set; }
    }
}
