using System;
using System.Reflection.Metadata;
using GestorDeVuelosProyectoFinal.src.Moduls.Continents.Infrastructure.Entity;
namespace GestorDeVuelosProyectoFinal.src.Moduls.Countries.Infrastructure.Entity;

public class CountriesEntity
{
    public Guid Id { get; set; } 
    public string Name { get; set; } = string.Empty;
    public string IsoCode { get; set; } = string.Empty;
    public int Continents_id { get; set; }
    public ContinentsEntity Continents { get; set; } = null!;

}
