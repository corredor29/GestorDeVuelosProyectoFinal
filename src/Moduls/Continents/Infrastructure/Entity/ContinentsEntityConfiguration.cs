using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GestorDeVuelosProyectoFinal.src.Moduls.Continents.Infrastructure.Entity;

public sealed class ContinentsEntityConfiguration : IEntityTypeConfiguration<ContinentsEntity>
{
    public void Configure(EntityTypeBuilder<ContinentsEntity> builder)
    {
        builder.ToTable("Continents");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("id");

        builder.Property(x => x.Name)
            .HasColumnName("name")
            .HasMaxLength(50)
            .IsRequired();

        builder.HasIndex(x => x.Name)
            .IsUnique();
    }

}
