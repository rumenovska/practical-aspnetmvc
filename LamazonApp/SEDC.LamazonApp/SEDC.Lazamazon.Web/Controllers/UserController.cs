using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.ViewModels;

namespace SEDC.Lazamazon.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userSrvice;
        public UserController(IUserService userSrvice)
        {
            _userSrvice = userSrvice;
        }

        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            _userSrvice.Login(model);
            return RedirectToAction("index", "product");
        }

        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            _userSrvice.Register(model);
            return RedirectToAction("index", "product");
        }

        
        public IActionResult Logout()
        {
            _userSrvice.Logout();
            return RedirectToAction("index","home");
        }
    }
}