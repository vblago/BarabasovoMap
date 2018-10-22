using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BarabasovoMap.Database.Models;

namespace BarabasovoMap.Database.Configurations
{
    public class PointServiceConfiguration : IEntityTypeConfiguration<PointService>
    {
        public void Configure(EntityTypeBuilder<PointService> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasAlternateKey(x => new { x.PointId, x.ServiceId });

            builder.HasOne(x => x.Point)
                .WithMany(x => x.PointServices)
                .HasForeignKey(x => x.PointId);

            builder.HasOne(x => x.Service)
                .WithMany(x => x.PointServices)
                .HasForeignKey(x => x.ServiceId);
        }
    }
}