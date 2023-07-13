﻿using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();

        User GetById(int id);

        void InsertUser(User user);

        void UpdateUser(User user);
    }
}
