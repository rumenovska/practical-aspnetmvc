using SEDC.Lamazon.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.DataAccess.Interfaces
{
    public interface IUserRepository
    { 
        User GetByUsernme(string username);
        User GetById(string id);

    }
}
