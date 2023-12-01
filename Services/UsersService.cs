using BOOK_SYSTEM.Models;
using BOOK_SYSTEM.Services.Iservices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOK_SYSTEM.Services
{
    internal class UsersService : Iuser
    {
        public Task<List<Users>> GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
