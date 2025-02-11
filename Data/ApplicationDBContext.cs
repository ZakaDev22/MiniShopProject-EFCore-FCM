
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MiniShopProject_EFCore_FCM.Entities;

namespace MiniShopProject_EFCore_FCM.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var config = new ConfigurationBuilder()
                .AddJsonFile("AppConfig.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetSection("ConnectionString").Value);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDBContext).Assembly);
        }
    }
}
