using DataAggregator.Models;
using DataAggregator.Services.interfaces;

namespace DataAggregator.Services
{
    public class ItemRepository : IProductRepository<Item>
    {
        public async Task<IEnumerable<Item>> GetAllAsync()
        {
            return new List<Item>()
            {
                new Item()
                {
                    Id = 1,
                    Brand = "Bosh",
                    Price = 5,
                    ItemType = Common.Enums.ItemType.Nail
                }
            };
        }

        public Task<Item> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task DeleteAsync(Item product)
        {
            throw new NotImplementedException();
        }
    }
}
