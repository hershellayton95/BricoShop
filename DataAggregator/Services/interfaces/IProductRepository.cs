namespace DataAggregator.Services.interfaces
{
    public interface IProductRepository<T>
    {
        public Task<T> GetAsync(int id);
        public Task<IEnumerable<T>> GetAllAsync();
        public Task DeleteAsync(T product);

    }
}
