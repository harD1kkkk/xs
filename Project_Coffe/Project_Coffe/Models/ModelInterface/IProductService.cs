using Project_Coffe.Entities;

namespace Project_Coffe.Models.ModelInterface
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task AddProductAsync(Product product);
    }
}
