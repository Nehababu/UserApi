using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPI.Model;

namespace UserAPI.Repository
{
   public interface IUserRepository
    {
        Task<List<User>> GetUsersAsync();
        Task<List<User>> GetUsersByIdAsync(int id);
        Task UpdateUserAsync(int id);
       Task AddUserAsync(User user);
       Task DeleteUserAsync(int id);

    }   
    
}
