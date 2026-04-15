using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestorDeVuelosProyectoFinal.src.Moduls.Regions.Infrastructure.Entity;

public class RegionsEntityConfiguration : IEntityTypeConfiguration<RegionsEntity>
{
    public void Configure(EntityTypeBuilder<RegionsEntity> builder)
    {
        builder.ToTable("regions");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("id");

        builder.Property(x => x.Name)
            .HasColumnName("name")
            .HasMaxLength(100)
            .IsRequired();
        builder.Property(x => x.Type)
            .HasColumnName("type")
            .HasMaxLength(30)
            .IsRequired();

        builder.Property(x => x.Countries_id)
            .HasColumnName("countries_id")
            .IsRequired();

        builder.HasOne(x => x.Countries)
            .WithMany(c => c.Regions)
            .HasForeignKey(x => x.Countries_id)
            .OnDelete(DeleteBehavior.Restrict);
    }

}
