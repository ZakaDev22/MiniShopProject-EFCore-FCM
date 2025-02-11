using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniShopProject_EFCore_FCM.Entities;

namespace MiniShopProject_EFCore_FCM.Config
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();

            builder.ToTable("Customers");
            builder.HasData(LoadData());
        }

        private List<Customer> LoadData()
        {
            return new List<Customer>
            {
                new Customer(1,"zaka"),
                new Customer(2,"koko"),
                new Customer(3,"zika"),
                new Customer(4,"sss"),
                new Customer(5,"aaa"),
            };
        }
    }


}
