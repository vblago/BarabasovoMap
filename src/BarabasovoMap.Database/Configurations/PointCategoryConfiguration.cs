using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BarabasovoMap.Database.Models;

namespace BarabasovoMap.Database.Configurations
{
    public class PointCategoryConfiguration : IEntityTypeConfiguration<PointCategory>
    {
        public void Configure(EntityTypeBuilder<PointCategory> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasAlternateKey(x => new { x.PointId, x.CategoryId });

            builder.HasOne(x => x.Point)
                .WithMany(x => x.PointCategories)
                .HasForeignKey(x => x.PointId);

            builder.HasOne(x => x.Category)
                .WithMany(x => x.PointCategories)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}