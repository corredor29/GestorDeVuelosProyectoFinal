using System;
using GestorDeVuelosProyectoFinal.src.Moduls.Addresses.Infrastructure.Entity;
namespace GestorDeVuelosProyectoFinal.src.Moduls.ViaTypes.Infrastructure.Entity;

public class ViaTypesEntity
{
    public Guid Id { get; set; } 
    public string Name { get; set; } = string.Empty;
    public  ICollection<AddressesEntity> Addresses { get; set; } = new List<AddressesEntity>();
}
