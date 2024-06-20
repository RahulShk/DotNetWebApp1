using DotNetWebApp1.Models;
using Microsoft.EntityFrameworkCore;


namespace DotNetWebApp1
{
    public class UserManagerDbContext : DbContext
    {
        public UserManagerDbContext(DbContextOptions<UserManagerDbContext> options) : base(options)
        {

        }
        public DbSet<UserInfo> UserInfos { get; set; }
    }
}
