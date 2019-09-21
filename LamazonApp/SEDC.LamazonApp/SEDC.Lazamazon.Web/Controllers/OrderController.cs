using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.Lamazon.Services.Interfaces;
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

        public IActionResult Order()
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);

            return View(_orderService.GetCurrentOrder(user.Id));
        }
    }
}