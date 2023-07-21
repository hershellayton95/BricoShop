using DataAggregator.Models;

namespace DataAggregator.Services.interfaces
{
    public interface IUnitOfWork
    {
        public IProductRepository<Tool> ToolRepository { get; }
        public IProductRepository<Item> ItemRepository { get; }
        public Task SaveAsync();
    }
}
