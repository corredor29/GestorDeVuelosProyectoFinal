using System;
using GestorDeVuelosProyectoFinal.src.Moduls.DocumentTypes.Infrastructure.Entity;
using GestorDeVuelosProyectoFinal.src.Moduls.Addresses.Infrastructure.Entity;
namespace GestorDeVuelosProyectoFinal.src.Moduls.People.Infrastructure.Entity;

public class PeopleEntity
{
    public Guid Id { get; set; } 
    public Guid DocumentTypes_Id  { get; set; } 
    public string Document_Number { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Surnames { get; set; } = string.Empty;
    public DateTime? DateBirth { get; set; }
    public string Gender {get; set; } = string.Empty;
    public Guid Addresses_Id { get; set; }
    public DateTime? Created_in { get; set; }
    public DateTime? updated_in { get; set; }
    public DocumentTypesEntity DocumentTypes { get; set; } = null!;
    public AddressesEntity Addresses { get; set; } = null!;

}
