namespace DataAggregator.Models.Interfaces
{
    public interface IProduct
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
    }
}
