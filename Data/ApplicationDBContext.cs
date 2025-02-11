
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MiniShopProject_EFCore_FCM.Data
{
    public class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var config = new ConfigurationBuilder()
                .AddJsonFile("AppConfig.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetSection("ConnectionString").Value);
        }
    }
}
