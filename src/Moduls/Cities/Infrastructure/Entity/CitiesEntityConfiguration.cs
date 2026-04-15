using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestorDeVuelosProyectoFinal.src.Moduls.Cities.Infrastructure.Entity;

public class CitiesEntityConfiguration : IEntityTypeConfiguration<CitiesEntity>
{
    public void Configure(EntityTypeBuilder<CitiesEntity> builder)
    {
        builder.ToTable("cities");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("id");

        builder.Property(x => x.Name)
            .HasColumnName("name")
            .HasMaxLength(50)
            .IsRequired();

        builder.HasIndex(x => x.Name)
            .IsUnique();

        builder.Property(x => x.Regions_id)
        .HasColumnName("regions_id")
        .IsRequired();

        builder.HasOne(x => x.Regions)
            .WithMany(c => c.Cities)
            .HasForeignKey(x => x.Regions_id)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
