using System;
using System.Reflection.Metadata;
using GestorDeVuelosProyectoFinal.src.Moduls.Regions.Infrastructure.Entity;
using GestorDeVuelosProyectoFinal.src.Moduls.Continents.Infrastructure.Entity;
namespace GestorDeVuelosProyectoFinal.src.Moduls.Countries.Infrastructure.Entity;

public class CountriesEntity
{
    public Guid Id { get; set; } 
    public string Name { get; set; } = string.Empty;
    public string IsoCode { get; set; } = string.Empty;
    public Guid Continents_id { get; set; }
    public ContinentsEntity Continents { get; set; } = null!;
    public  ICollection<RegionsEntity> Regions { get; set; } = new List<RegionsEntity>();


}
