using AutoMapper;
using SEDC.Lamazon.DataAccess.Interfaces;
using SEDC.Lamazon.Domain.Models;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.Enums;
using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Services.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Product> _productRepo;
        private readonly IRepository<Order> _orderRepo;
        private readonly IUserRepository _userRepo;
        private readonly IMapper _mapper;
        public OrderService(IRepository<Product> productRepo, IRepository<Order> orderRepo, IUserRepository userRepo, IMapper mapper)
        {
            _productRepo = productRepo;
            _orderRepo = orderRepo;
            _userRepo = userRepo;
            _mapper = mapper;
        }


        public IEnumerable<OrderViewModel> GetAllOrders()
        {
            return _mapper.Map<List<OrderViewModel>>(_orderRepo.GetAll());
        }

        public OrderViewModel GetOrderById(int id)
        {
            return _mapper.Map<OrderViewModel>(_orderRepo.GetById(id));
        }

        public int CreateOrder(OrderViewModel order, string userId)
        {
            User user = _userRepo.GetById(userId);
            Order mappedOrder = _mapper.Map<Order>(order);

            mappedOrder.User = user;

            return _orderRepo.Insert(mappedOrder);
        }

        public int ChangeStatus(int orderId, StatusTypeViewModel status)
        {
            throw new NotImplementedException();
        }

        public int AddProduct(int orderId, int productId)
        {
            throw new NotImplementedException();
        }

        public int RemoveProduct(int orderId, int productId)
        {
            throw new NotImplementedException();
        }
    }
}
