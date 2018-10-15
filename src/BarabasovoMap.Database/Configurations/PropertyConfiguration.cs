using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BarabasovoMap.Database.Models;

namespace BarabasovoMap.Database.Configurations
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasAlternateKey(x => new { x.OwnerId, x.PointId });

            builder.HasOne(x => x.Owner)
                .WithMany(x => x.Properties)
                .HasForeignKey(x => x.OwnerId);

            builder.HasOne(x => x.Point)
                .WithMany(x => x.Properties)
                .HasForeignKey(x => x.PointId);
        }
    }
}