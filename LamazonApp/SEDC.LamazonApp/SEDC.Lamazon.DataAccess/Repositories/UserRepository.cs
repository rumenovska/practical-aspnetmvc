﻿using SEDC.Lamazon.DataAccess.Interfaces;
using SEDC.Lamazon.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Lamazon.DataAccess.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(LamazonDbContext context): base(context) { }
       
        public IEnumerable<User> GetAll()
        {
            return _context.Users;

        }

        public User GetById(string id)
        {
            return _context.Users.SingleOrDefault(u => u.Id == id);
        }

        public User GetByUsernme(string username)
        {
            return _context.Users.SingleOrDefault(u => u.UserName == username);
        }

        public int Insert(User entity)
        {
            _context.Users.Add(entity);

            return _context.SaveChanges();
        }

        public int Update(User entity)
        {
            _context.Users.Update(entity);
            return _context.SaveChanges();
        }

        public int Delete(string id)
        {
            User user = _context.Users.SingleOrDefault(u => u.Id == id);
            if (user == null)
                return -1;
            _context.Users.Remove(user);

            return _context.SaveChanges();
        }

        
    }
}
