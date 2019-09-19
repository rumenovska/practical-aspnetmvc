using AutoMapper;
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
        private readonly IMapper _mapper;

        public ProductService(IRepository<Product> productRepo, IMapper mapper)
        {
            _productRepo = productRepo;
            _mapper = mapper;
        }
           
        public IEnumerable<ProductViewModel> GetAllProducts()
        {
            //var products = _productRepo.GetAll().ToList();
            //ProductViewModel model = new ProductViewModel();
            //List<ProductViewModel> mappedproducts = new List<ProductViewModel>();
            //foreach (var product in products)
            //{
            //    model.Id = product.Id;
            //    model.Name = product.Name;
            //    model.Description = product.Description;
            //    model.Category = (CategoryTypeViewModel)product.Category;
            //    model.Price = product.Price;

            //    mappedproducts.Add(model);

            //}
            return _mapper.Map<List<ProductViewModel>>(_productRepo.GetAll());
        }

        public ProductViewModel GetProductById(int id)
        {
            //Product product = _productRepo.GetById(id);
            //ProductViewModel productModel = new ProductViewModel{
            //    Id = product.Id,
            //    Name = product.Name,
            //    Description = product.Description,
            //    Category = (CategoryTypeViewModel)product.Category,
            //    Price = product.Price

            // };

            return _mapper.Map<ProductViewModel>(_productRepo.GetById(id));
        }

        public int CreateProduct(ProductViewModel product)
        {
            Product mappedProduct = _mapper.Map<Product>(product);
            return _productRepo.Insert(mappedProduct);
        }

        public int UpdateProduct(ProductViewModel product)
        {
            Product mappedProduct = _mapper.Map<Product>(product);
            return _productRepo.Update(mappedProduct);
        }

        public int RemoveProduct(int id)
        {
            Product product = _productRepo.GetById(id);
            if (product == null)
                return -1;
            return _productRepo.Delete(product.Id);
        }

        
    }
}
