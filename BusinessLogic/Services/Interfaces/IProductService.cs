using Common.DTOs;

namespace BusinessLogic.Services.Interfaces
{
    public interface IProductService
    {
        public Task<AllProductsDTO> GetAllAsync();
    }
}
