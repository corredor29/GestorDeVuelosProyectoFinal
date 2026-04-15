using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestorDeVuelosProyectoFinal.src.Moduls.Countries.Infrastructure.Entity;

public class CountriesEntityConfiguration : IEntityTypeConfiguration<CountriesEntity>
{
    public void Configure(EntityTypeBuilder<CountriesEntity> builder)
    {
        builder.ToTable("countries");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("id");

        builder.Property(x => x.Name)
            .HasColumnName("name")
            .HasMaxLength(100)
            .IsRequired();
        builder.Property(x => x.IsoCode)
            .HasColumnName("iso_code")
            .HasMaxLength(3)
            .IsRequired();

        builder.HasIndex(x => x.IsoCode)
            .IsUnique();
        builder.Property(x => x.Continents_id)
        .HasColumnName("continente_id")
        .IsRequired();

        builder.HasOne(x => x.Continents)
            .WithMany(c => c.Countries)
            .HasForeignKey(x => x.Continents_id)
            .OnDelete(DeleteBehavior.Restrict);
    }

}
