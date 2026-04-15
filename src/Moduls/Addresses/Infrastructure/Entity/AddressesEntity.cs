using System;
using GestorDeVuelosProyectoFinal.src.Moduls.Cities.Infrastructure.Entity;
using GestorDeVuelosProyectoFinal.src.Moduls.ViaTypes.Infrastructure.Entity;
using GestorDeVuelosProyectoFinal.src.Moduls.People.Infrastructure.Entity;
namespace GestorDeVuelosProyectoFinal.src.Moduls.Addresses.Infrastructure.Entity;

public class AddressesEntity
{
    public Guid Id { get; set; } 
    public Guid ViaType_id { get; set; }
    public string PathName { get; set; } = string.Empty;
    public string? Number { get; set; } 
    public string Complement {get; set;} = string.Empty;
    public Guid Cities_id { get; set; }
    public string Postal_code {get; set;} = string.Empty;
    public ViaTypesEntity ViaTypes {get; set;} = null!;
    public CitiesEntity Cities {get; set;} = null!;
    public  ICollection<PeopleEntity> People { get; set; } = new List<PeopleEntity>();

}
