using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using AppSkel.Entities;

namespace AppSkel.Helpers
{
    public class DataContext : DbContext
    {
        
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<User> AppSkelUsers { get; set; }
        
    }
}