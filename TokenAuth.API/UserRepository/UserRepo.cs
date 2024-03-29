﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokenAuth.API.Data;
using TokenAuth.API.Models;

namespace TokenAuth.API.UserRepository
{
    public class UserRepo : IDisposable
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();

        public User ValidateUser(String username, String password)
        {
            return dbContext.Users.FirstOrDefault(user => user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase) && user.Password == password);
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}