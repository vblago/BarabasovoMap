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

            builder.HasOne(x => x.Point)
                .WithMany(x => x.Sellers)
                .HasForeignKey(x => x.PointId);
        }
    }
}