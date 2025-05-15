using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using Model;

namespace DataAccess.Configurations;

public class LodgingConfiguration : IEntityTypeConfiguration<Lodging>
{
    public void Configure(EntityTypeBuilder<Lodging> builder)
    {
        builder.Property(l => l.Name).IsRequired().HasMaxLength(200);
    }
}