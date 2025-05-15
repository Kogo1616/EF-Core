using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace DataAccess.Configurations;

public class DestinationConfiguration : IEntityTypeConfiguration<Destination>
{
    public void Configure(EntityTypeBuilder<Destination> builder)
    {
        builder.Property(d => d.Name).IsRequired();
        builder.Property(d => d.Description).HasMaxLength(500);
        builder.Property(d => d.Photo).HasColumnType("image");
    }
}