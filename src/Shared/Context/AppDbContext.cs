using System;
using Microsoft.EntityFrameworkCore;
using GestorDeVuelosProyectoFinal.src.Moduls.Continents.Infrastructure.Entity;
using GestorDeVuelosProyectoFinal.src.Moduls.Countries.Infrastructure.Entity;
using GestorDeVuelosProyectoFinal.src.Moduls.Regions.Infrastructure.Entity;
using GestorDeVuelosProyectoFinal.src.Moduls.DocumentTypes.Infrastructure.Entity;
using GestorDeVuelosProyectoFinal.src.Moduls.ViaTypes.Infrastructure.Entity;
using GestorDeVuelosProyectoFinal.src.Moduls.Addresses.Infrastructure.Entity;
using GestorDeVuelosProyectoFinal.src.Moduls.People.Infrastructure.Entity;

namespace GestorDeVuelosProyectoFinal.src.Shared.Context;

public class AppDbContext : DbContext
{
    public DbSet<ContinentsEntity> Continents { get; set; }
    public DbSet<CountriesEntity> Countries { get; set; }
    public DbSet<RegionsEntity> Regions { get; set; }
    public DbSet<DocumentTypesEntity> DocumentTypes { get; set; }
    public DbSet<ViaTypesEntity> ViaTypes { get; set; }
    public DbSet<AddressesEntity> Addresses { get; set; }
    public DbSet<PeopleEntity> People { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Aplica todas las configuraciones de la carpeta infrastructure/Entity
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }

}
