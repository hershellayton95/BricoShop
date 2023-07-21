using BusinessLogic.Services;
using BusinessLogic.Services.Interfaces;
using DataAggregator.Services;
using DataAggregator.Services.interfaces;

IUnitOfWork unitOfWork = new UnitOfWork();
IProductService productService = new ProductService(unitOfWork);

var products = await productService.GetAllAsync();

foreach (var product in products.Tools)
{
    Console.WriteLine(product.ToolType.ToString());
}
foreach (var product in products.Items)
{
    Console.WriteLine(product.ItemType.ToString());
}