using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestorDeVuelosProyectoFinal.src.Moduls.DocumentTypes.Infrastructure.Entity;

public class DocumentTypesEntityConfiguration : IEntityTypeConfiguration<DocumentTypesEntity>
{
    public void Configure(EntityTypeBuilder<DocumentTypesEntity> builder)
    {
        builder.ToTable("document_types");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("id");

        builder.Property(x => x.Name)
            .HasColumnName("name")
            .HasMaxLength(50)
            .IsRequired();
        builder.Property(x => x.Code)
            .HasColumnName("code")
            .HasMaxLength(10)
            .IsRequired();

        builder.HasIndex(x => x.Code)
            .IsUnique();
    }
}
