using DataAggregator.Models;
using DataAggregator.Services.interfaces;

namespace DataAggregator.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private IProductRepository<Tool>? _toolRepository;
        private IProductRepository<Item>? _itemRepository;

        public IProductRepository<Tool> ToolRepository
        {
            get
            {
                _toolRepository ??= new ToolRepository();
                return _toolRepository;
            }
        }
        public IProductRepository<Item> ItemRepository
        {
            get
            {
                _itemRepository ??= new ItemRepository();
                return _itemRepository;
            }
        }

        public async Task SaveAsync()
        {
            
        }
    }
}
