using Microsoft.EntityFrameworkCore;
using MyEF.Models;
namespace MyEF.Data{
    public class MyDBContext:DbContext{
        public DbSet<User> Users{get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=PMCLAP1271-1118;Database=Practice;User Id=sa;Password=India@123;TrustServerCertificate=True;");
        }
    }
}