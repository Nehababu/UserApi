using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserAPI.Services;
using Xunit;
using UserAPI.Model;
using UserAPI.Repository;
using UserAPI.Context;
using Microsoft.EntityFrameworkCore;

namespace XUnitTestProject3.Repository
{
 public   class UserRepositryInMemoryTest
    {
        [Fact]
        public async Task RespositortTest()
        {
            var options = new DbContextOptionsBuilder<UserContext>()
                .UseInMemoryDatabase("UserDbconnection").Options;

            using (var contet = new UserContext(options))
            {
                
            }





        }



    }
}
