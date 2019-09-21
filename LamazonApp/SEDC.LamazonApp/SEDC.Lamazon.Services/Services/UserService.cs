using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SEDC.Lamazon.DataAccess.Interfaces;
using SEDC.Lamazon.Domain.Models;
using SEDC.Lamazon.Domain.Models.Enums;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Lamazon.Services.Services
{
    public class UserService : IUserService
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepo;

        public UserService(SignInManager<User> signInManager, UserManager<User> userManager, IMapper mapper, IUserRepository userRepo)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _mapper = mapper;
            _userRepo = userRepo;
        }
        public UserViewModel GetCurrentUser(string username)
        {
            User user= _userRepo.GetByUsernme(username);

            return new UserViewModel()
            {
                Username = user.UserName,
                Id= user.Id,
                FullName= user.FullName
            };
        }

        public void Login(LoginViewModel loginModel)
        {
            var result = _signInManager.PasswordSignInAsync(loginModel.Username, loginModel.Password, false, false).Result;
            if (result.IsNotAllowed)
            {
                throw new Exception("Username or Password is not correct!");
            }
        }

        public void Logout()
        {
            _signInManager.SignOutAsync();
        }

        public void Register(RegisterViewModel registerModel)
        {
            User user = new User()
            {
                UserName = registerModel.Username,
                FullName= $"{registerModel.FirstName} {registerModel.LastName}",
                Email= registerModel.Email,
                Orders= new List<Order>() { new Order() { Status= StatusType.Init} }
                
            };

            var result = _userManager.CreateAsync(user, registerModel.Password).Result;
            if (result.Succeeded)
            {
                var currentUser = _userManager.FindByNameAsync(user.UserName).Result;
                _userManager.AddToRoleAsync(user, "user");

                Login(new LoginViewModel() { Username = registerModel.Username, Password = registerModel.Password });
            }
            else
            {
                throw new Exception($"Register failed!, {result.Errors.First().Description}");
            }

        }
    }
}
