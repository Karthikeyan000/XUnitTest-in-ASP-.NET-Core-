
using UnitTestApi.Data;
using UnitTestApi.Entity;
using UnitTestApi.Service;

namespace UnitTestMoqFinal.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductRepository _repository;

        public ProductService(ProductRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<Product> GetProductList()
        {
            return _repository.GetProductList().ToList();
        }
        public Product GetProductById(int id)
        {
            return _repository.GetProductById(id);
        }

        public Product AddProduct(Product product)
        {
            return _repository.AddProduct(product);
        }

        public Product UpdateProduct(Product product)
        {
            return _repository.UpdateProduct(product);
        }
        public bool DeleteProduct(int Id)
        {
            var result = _repository.DeleteProduct(Id);
            return result;
        }
    }
}