using DataAggregator.Models;
using DataAggregator.Services.interfaces;

namespace DataAggregator.Services
{
    public class ToolRepository : IProductRepository<Tool>
    {
        public async Task<IEnumerable<Tool>> GetAllAsync()
        {
            return new List<Tool>()
            {
                new Tool()
                {
                    Id = 1,
                    Brand = "Bosh",
                    Price = 50,
                    ToolType = Common.Enums.ToolType.Hammer
                }
            };
        }

        public async Task<Tool> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Tool product)
        {
            throw new NotImplementedException();
        }
    }
}
