using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BarabasovoMap.Database.Models;

namespace BarabasovoMap.Database.Configurations
{
    public class SellerConfiguration : IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName).IsRequired();

            builder.Property(x => x.LastName).IsRequired();

            builder.Property(x => x.Email).IsRequired();

            builder.Property(x => x.PhoneNumber).IsRequired();

            builder.HasOne(x => x.Point)
                .WithMany(x => x.Sellers)
                .HasForeignKey(x => x.PointId);
        }
    }
}