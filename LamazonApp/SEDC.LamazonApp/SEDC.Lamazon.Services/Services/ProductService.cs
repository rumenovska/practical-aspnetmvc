using SEDC.Lamazon.DataAccess.Interfaces;
using SEDC.Lamazon.Domain.Models;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.Enums;
using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Lamazon.Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepo;
        public ProductService(IRepository<Product> productRepo)
        {
            _productRepo = productRepo;
        }
           
        public IEnumerable<ProductViewModel> GetAllProducts()
        {
            var products = _productRepo.GetAll().ToList();
            ProductViewModel model = new ProductViewModel();
            List<ProductViewModel> mappedproducts = new List<ProductViewModel>();
            foreach (var product in products)
            {
                model.Id = product.Id;
                model.Name = product.Name;
                model.Description = product.Description;
                model.Category = (CategoryTypeViewModel)product.Category;
                model.Price = product.Price;

                mappedproducts.Add(model);

            }
            return mappedproducts;
        }

        public ProductViewModel GetProductById(int id)
        {
            Product product = _productRepo.GetById(id);
            ProductViewModel productModel = new ProductViewModel{
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Category = (CategoryTypeViewModel)product.Category,
                Price = product.Price

             };

            return productModel;
        }

        public int CreateProduct(ProductViewModel product)
        {
            throw new NotImplementedException();
        }

        public int UpdateProduct(ProductViewModel product)
        {
            throw new NotImplementedException();
        }

        public int RemoveProduct(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
