using System.Collections.Generic;
using System.Threading.Tasks;
using GestorDeVuelosProyectoFinal.Moduls.Addresses.Domain.Aggregate;
using GestorDeVuelosProyectoFinal.Moduls.Addresses.Domain.ValueObject;
using GestorDeVuelosProyectoFinal.Moduls.Cities.Domain.ValueObject;

namespace GestorDeVuelosProyectoFinal.Moduls.Addresses.Domain.Repositories;

public interface IAddressRepository
{
    Task<Address?> GetByIdAsync(AddressesId id);
    Task<IEnumerable<Address>> GetAllAsync();
    Task<IEnumerable<Address>> GetByCityAsync(CityId cityId);
    Task SaveAsync(Address address);
    Task DeleteAsync(AddressesId id);
}