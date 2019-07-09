using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPI.Model;

namespace UserAPI.Services
{
   public interface IUser
    {
        Task<List<User>> GetUsersAsync();
        Task<List<User>> GetUsersByIdAsync(int  id);
        Task UpdateUserAsync(int id);
        Task AddUserAsync( User user);
        Task DeleteUserAsync(int id);
        
    }
}
