using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserAPI.Services;
using Xunit;
using UserAPI.Model;
using UserAPI.Repository;

namespace XUnitTestProject3.Service
{
    public class UserServiceTest
    {
       private UserService _userService;

       
        public UserServiceTest()
        {
            _userService = new UserService(new UserRepository(new UserAPI.Context.UserContext()));
        }

        [Fact]
        public async Task GetUserDetailsById()
        {
            //Arrange
            var details = new Mock<UserAPI.Repository.IUserRepository>();

            details.Setup(c => c.GetUsersByIdAsync(1)).ReturnsAsync(new List<User>
            {
                new User
                {
                    Name = "Ankita",
                    City = "Hyderabad"
                }
            });
           
            //Act
            var result = await _userService.GetUsersByIdAsync(1);
            //Assert
            Assert.Single(result);

            Assert.Equal("Ankita", result[0].Name);
            Assert.Equal("Hyderabad", result[1].City);




        }
        [Fact]
        public async Task AddUserTest()
        {
            var userCallBack = new User();
            var userdata = new User()
            {
                Name = "Ankita",
                City = "Hyderabad"
            };

            Mock<UserAPI.Repository.IUserRepository> _mockadduser = new Mock<UserAPI.Repository.IUserRepository>();
            _mockadduser.Setup(c => c.AddUserAsync(It.IsAny<User>()))

                .Callback<User>((user) =>
                {
                    userCallBack.Name = userdata.Name;
                });


            await _userService.AddUserAsync(userdata);


            Assert.




        }
    }
}
