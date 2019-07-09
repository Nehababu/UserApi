//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;
//using UserAPI.Services;
//using Xunit;
//using UserAPI.Model;
//using UserAPI.Repository;
//using UserAPI.Context;
//using Microsoft.EntityFrameworkCore;
//using Moq;

//namespace XUnitTestProject3.Repository
//{

//    public class UserRepositoryTest
//    {
//        //private readonly UserRepository _repo;
//        //private readonly UserContext _userContext;
//        private IUserRepository GetInMemoryPersonRepository()
//        {
//            DbContextOptions<UserContext> options;
//            var builder = new DbContextOptionsBuilder<UserContext>();
//            builder.UseInMemoryDatabase();
//            options = builder.Options;
//            UserContext UserDatacontext = new UserContext(options);
//            UserDatacontext.Database.EnsureDeleted();
//            UserDatacontext.Database.EnsureCreated();
//            return new UserRepository(UserDatacontext);
//        }

//        [Fact]
//        public async Task adduserrepositoryTest()
//        {
//            IUserRepository sut = GetInMemoryPersonRepository();
//            User person = new User()
//            {

//                Name = "fred",
//                City = "Blogs"
//            };

//            await sut.AddUserAsync(person);


//        }
//    }
//}
