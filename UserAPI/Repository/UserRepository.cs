using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPI.Context;
using UserAPI.Model;

namespace UserAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _userContext;
        public UserRepository(UserContext userContext)
        {
             _userContext= userContext;
        }
        public async Task AddUserAsync(User user)
        {
           await _userContext.AddUserAsync(user);
        }

       
        public async Task<List<User>> GetUsersAsync()
        {
            return await _userContext.GetUserAsync();

        }
        public async Task<List<User>> GetUsersByIdAsync(int id)
        {
            return await _userContext.GetUsersByIdAsync(id);
            

        }
        public async Task UpdateUserAsync(int id)
        {
            await _userContext.UpdateUserAsync(id);
        }
        public async Task DeleteUserAsync(int id)
        {
            await _userContext.DeleteUserAsync(id);
        }
    }
}
