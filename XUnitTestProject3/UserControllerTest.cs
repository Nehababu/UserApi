using System;
using System.Collections.Generic;
using System.Text;
using UserAPI.Controllers;
using UserAPI.Services;
using UserAPI.Repository;
using UserAPI.Context;
using UserAPI.Model;
using Moq;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace XUnitTestProject3
{
    public class UserControllerTest
    {
[Fact]
        public async Task TestUserById()
        {
            var controller = new UserController();

           
            //List<User> details = new List<User>()
            //{ new User(){Id=1,Name="ankita",City="Bagalore"}

     
                
            //};
          
          var testResult =await  controller.GetUserByIdAsync(1);
         Assert.IsType<OkObjectResult>(testResult);
        }

    }
}

