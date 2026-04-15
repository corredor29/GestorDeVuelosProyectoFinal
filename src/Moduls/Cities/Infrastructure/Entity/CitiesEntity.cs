using System;
using GestorDeVuelosProyectoFinal.src.Moduls.Regions.Infrastructure.Entity;
namespace GestorDeVuelosProyectoFinal.src.Moduls.Cities.Infrastructure.Entity;

public class CitiesEntity
{
    public Guid Id { get; set; } 
    public string Name { get; set; } = string.Empty;
    public Guid Regions_id { get; set; }
    public RegionsEntity Regions { get; set; } = null!;

}
