using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestorDeVuelosProyectoFinal.src.Moduls.People.Infrastructure.Entity;

public class PeopleEntityConfiguration : IEntityTypeConfiguration<PeopleEntity>
{
    public void Configure(EntityTypeBuilder<PeopleEntity> builder)
    {
        builder.ToTable("people");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("id")
            .IsRequired();

        builder.Property(x => x.DocumentTypes_Id)
            .HasColumnName("documenttype_id")
            .IsRequired();

        builder.Property(x => x.Document_Number)
            .HasColumnName("document_number")
            .HasMaxLength(30)
            .IsRequired();

        builder.Property(x => x.Name)
            .HasColumnName("name")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.Surnames)
            .HasColumnName("surnames")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.DateBirth)
            .HasColumnName("date_birth")
            .HasColumnType("date")
            .IsRequired(false);

        builder.Property(x => x.Gender)
            .HasColumnName("gender")
            .HasMaxLength(10)
            .IsRequired();

        builder.Property(x => x.Addresses_Id)
            .HasColumnName("address_id")
            .IsRequired();

        builder.Property(x => x.Created_in)
            .HasColumnName("created_in")
            .HasColumnType("datetime")
            .IsRequired(false);

        builder.Property(x => x.updated_in)
            .HasColumnName("updated_in")
            .HasColumnType("datetime")
            .IsRequired(false);


        builder.HasOne(x => x.DocumentTypes)
            .WithMany()
            .HasForeignKey(x => x.DocumentTypes_Id)
            .OnDelete(DeleteBehavior.Restrict);


        builder.HasOne(x => x.Addresses)
            .WithMany()
            .HasForeignKey(x => x.Addresses_Id)
            .OnDelete(DeleteBehavior.Restrict);


        builder.HasIndex(x => x.Document_Number)
            .IsUnique();
    }
}



