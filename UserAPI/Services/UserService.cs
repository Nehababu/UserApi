using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPI.Model;
using UserAPI.Repository;

namespace UserAPI.Services
{
    public class UserService : IUser
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

       
        public async Task AddUserAsync(User user)
        {
           await _userRepository.AddUserAsync(user);
        }

        public async Task DeleteUserAsync(int id)
        {
           await  _userRepository.DeleteUserAsync(id);
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _userRepository.GetUsersAsync();
        }
        public async Task<List<User>> GetUsersByIdAsync(int  id)
        {
            
            return await _userRepository.GetUsersByIdAsync(id);
        }

        public async Task UpdateUserAsync(int id)
        {
            await _userRepository.UpdateUserAsync(id);
        }

        public Task AddUserAsync()
        {
            throw new NotImplementedException();
        }
    }
}
