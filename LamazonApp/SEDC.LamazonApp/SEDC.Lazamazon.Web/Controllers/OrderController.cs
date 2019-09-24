using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.Enums;
using SEDC.Lamazon.WebModels.ViewModels;

namespace SEDC.Lazamazon.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;
        private readonly IProductService _productService;
        private readonly IInvoiceService _invoiceService;
        public OrderController(IOrderService orderService, IUserService userService, IProductService productService, IInvoiceService invoiceService)
        {
            _orderService = orderService;
            _userService = userService;
            _productService = productService;
            _invoiceService = invoiceService;
        }

        [Authorize(Roles = "user")]
        public IActionResult Order()
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);

            return View(_orderService.GetCurrentOrder(user.Id));
        }

        [Authorize(Roles = "user")]
        public IActionResult OrderDetails(int orderId)
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            OrderViewModel order = _orderService.GetOrderById(orderId, user.Id);

            return View("order", order);
        }

        [Authorize(Roles = "user")]
        public int AddProduct(int productId)
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            OrderViewModel order = _orderService.GetCurrentOrder(user.Id);

            return _orderService.AddProduct(productId, order.Id, user.Id);

        }

        [Authorize(Roles = "user")]
        public IActionResult ListOrders()
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);

            List<OrderViewModel> userOrders = _orderService.GetAllOrders().Where(x => x.User.Id == user.Id).ToList();

            return View(userOrders);
        }

        [Authorize(Roles = "user")]
        public IActionResult ChangeStatus(int orderId, int statusId)
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);

            _orderService.ChangeStatus(orderId, user.Id, (StatusTypeViewModel)statusId);

            return RedirectToAction("products", "product");
        }

        [Authorize(Roles = "admin")]
        public IActionResult ListAllOrders()
        {
            List<OrderViewModel> orders = _orderService.GetAllOrders().ToList();
            return View(orders);
        }

        [Authorize(Roles = "admin")]
        public IActionResult ConfirmOrder( int orderId)
        {
            OrderViewModel order = _orderService.GetOrderById(orderId);
            _orderService.ChangeStatus(orderId, order.User.Id, StatusTypeViewModel.Confirmed);

            return RedirectToAction("listallorders");
        }
    }
}