using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestorDeVuelosProyectoFinal.src.Moduls.ViaTypes.Infrastructure.Entity;

public class ViaTypesEntityConfiguration : IEntityTypeConfiguration<ViaTypesEntity>
{
    public void Configure(EntityTypeBuilder<ViaTypesEntity> builder)
    {
        builder.ToTable("viatypes");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("id");

        builder.Property(x => x.Name)
            .HasColumnName("name")
            .HasMaxLength(50)
            .IsRequired();
    }
}
