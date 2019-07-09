using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPI.Model;
using UserAPI.Services;

namespace UserAPI.Controllers
{
    [Route("api/User")]
    public class UserController : Controller
    {
        private readonly IUser _user;
        public UserController(IUser user)
        {
            _user = user;
        }

       

        [HttpPost]
        public async Task<IActionResult> AddUserAsync([FromBody]User user)
        {
            await _user.AddUserAsync(user);
            return Ok("EmployeeData gets created");
        }
        [HttpGet]
        public async Task<List<User>> GetUserAsync()
        {
            return await _user.GetUsersAsync();
          

        }
        [HttpGet, Route("{id}")]
        public async Task<List<User>> GetUserByIdAsync(int id)
        {
            return await _user.GetUsersByIdAsync(id);


        }

        [HttpPut, Route("{id}")]
        public async Task<IActionResult> UpdateUserAsync(int id)
        {
            await _user.UpdateUserAsync(id);
            return Ok("Updated Successfully");
        }

        [HttpDelete, Route("{id}")]
        public async Task<IActionResult> DeleteUserAsync(int id)
        {
           await _user.DeleteUserAsync(id);
            return Ok("Deleted Successfully");
        }

    }

    }

