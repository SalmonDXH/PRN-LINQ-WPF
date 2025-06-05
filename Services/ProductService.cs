using BusinessObjects;
using Repositories;
using System.Collections.Generic;
namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductService iProductService;

        public ProductService()
        {
            iProductService = new ProductService();
        }

        public void DeleteProduct(Product p)
        {
            iProductService.DeleteProduct(p);
        }

        public Product GetProductById(int id)
        {
            return iProductService.GetProductById(id);
        }

        public List<Product> GetProducts() {
            return iProductService.GetProducts();
        }

        public void SaveProduct(Product p)
        {
            iProductService.SaveProduct(p);
        }

        public void UpdateProduct(Product p)
        {
            iProductService.UpdateProduct(p);
        }
    }
}
