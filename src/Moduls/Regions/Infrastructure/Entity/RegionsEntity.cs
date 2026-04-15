using System;
using GestorDeVuelosProyectoFinal.src.Moduls.Countries.Infrastructure.Entity;
using GestorDeVuelosProyectoFinal.src.Moduls.Cities.Infrastructure.Entity;

namespace GestorDeVuelosProyectoFinal.src.Moduls.Regions.Infrastructure.Entity;

public class RegionsEntity
{
    public Guid Id { get; set; } 
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public Guid Countries_id { get; set; }
    public CountriesEntity Countries { get; set; } = null!;
    public  ICollection<CitiesEntity> Cities { get; set; } = new List<CitiesEntity>();

}
