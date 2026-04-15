using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestorDeVuelosProyectoFinal.src.Moduls.Addresses.Infrastructure.Entity;

public class AddressesEntityConfiguration : IEntityTypeConfiguration<AddressesEntity>
{
    public void Configure(EntityTypeBuilder<AddressesEntity> builder)
    {
        builder.ToTable("addresses");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("id")
            .IsRequired();

        builder.Property(x => x.ViaType_id)
            .HasColumnName("viatype_id")
            .IsRequired();

        builder.Property(x => x.PathName)
            .HasColumnName("path_name")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.Number)
            .HasColumnName("number")
            .HasMaxLength(20)
            .IsRequired(false);

        builder.Property(x => x.Complement)
            .HasColumnName("complement")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.Cities_id)
            .HasColumnName("city_id")
            .IsRequired();

        builder.Property(x => x.Postal_code)
            .HasColumnName("postal_code")
            .HasMaxLength(20)
            .IsRequired();

        builder.HasOne(x => x.ViaTypes)
            .WithMany()
            .HasForeignKey(x => x.ViaType_id)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Cities)
            .WithMany()
            .HasForeignKey(x => x.Cities_id)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
