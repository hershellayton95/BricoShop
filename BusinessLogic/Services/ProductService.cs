using BusinessLogic.Services.Interfaces;
using Common.DTOs;
using DataAggregator.Models;
using DataAggregator.Services.interfaces;

namespace BusinessLogic.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<AllProductsDTO> GetAllAsync()
        {
            IEnumerable<Item> items = await _unitOfWork.ItemRepository.GetAllAsync();
            IEnumerable<Tool> tools = await _unitOfWork.ToolRepository.GetAllAsync();


            return new AllProductsDTO
            {
                Items = items.Select(x => new ItemDTO
                {
                    Id = x.Id,
                    Brand = x.Brand,
                    Price = x.Price,
                    ItemType = x.ItemType
                }).ToList(),
                Tools = tools.Select(x => new ToolDTO
                {
                    Id = x.Id,
                    Brand = x.Brand,
                    Price = x.Price,
                    ToolType = x.ToolType
                }).ToList()
            };
        }
    }
}
