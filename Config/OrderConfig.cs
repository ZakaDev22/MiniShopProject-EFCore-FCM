using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniShopProject_EFCore_FCM.Entities;


namespace MiniShopProject_EFCore_FCM.Config
{

    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.OrderId);
            builder.Property(x => x.OrderId).ValueGeneratedNever();

            builder.Property(x => x.Amount).HasPrecision(10, 2);
            builder.ToTable("Orders");
            builder.HasData(LoadData());


        }

        private List<Order> LoadData()
        {
            return new List<Order>
            {
                new Order(1,22,1),
                new Order(2,23,1),
                new Order(3,500,2),
                new Order(4,1400,5),
                new Order(5,420,3)
            };
        }
    }
}
