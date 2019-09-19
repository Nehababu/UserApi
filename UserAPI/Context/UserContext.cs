using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPI.Model;


namespace UserAPI.Context
{
    public class UserContext : DbContext
    {
        public IConfiguration configuration;



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionDb = configuration.GetConnectionString("MyConnection");
            optionsBuilder.UseSqlServer(@"Server=BLR-7033-WIN;Database=Userinfodb;Trusted_Connection=true");
        }
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public UserContext()
        {
        }

        DbSet<User> Users { get; set; }
        public async Task AddUserAsync(User user)
        {
            var context = new UserContext();
             context.Users.Add(user);
            await context.SaveChangesAsync();
        }
        public async Task<List<User>> GetUserAsync()
        {
            var context = new UserContext();
            return await context.Users.ToListAsync();

        }
        public async Task<List<User>> GetUsersByIdAsync(int id)
        {
            var context = new UserContext();
            var a = context.Users.FirstOrDefaultAsync(x=>x.Id==id);
            
            return await context.Users.Where(s=>s.Id==id).ToListAsync();
             

        }

        public async Task UpdateUserAsync(int id)
        {
            var context = new UserContext();

            var entity = await context.Users.FindAsync(id);
            
            if (entity != null)
            {
                entity.Name = "AAA";
                context.Users.Update(entity);
                await context.SaveChangesAsync();
             

            }
        }
        public async Task DeleteUserAsync(int id)
        {
            var context = new UserContext();
            var entity = await context.Users.FindAsync(id);
            if (entity != null)
            {

                context.Users.Remove(entity);
                await context.SaveChangesAsync();
            }
        }

    
        }
    }

