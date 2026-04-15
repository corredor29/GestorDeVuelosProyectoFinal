using System.Collections.Generic;
using System.Threading.Tasks;
using GestorDeVuelosProyectoFinal.Moduls.AircraftModels.Domain.Aggregate;
using GestorDeVuelosProyectoFinal.Moduls.AircraftModels.Domain.ValueObject;
using GestorDeVuelosProyectoFinal.Moduls.Manufacturers.Domain.ValueObject;

namespace GestorDeVuelosProyectoFinal.Moduls.AircraftModels.Domain.Repositories;

public interface IAircraftModelsRepository
{
    Task<AircraftModel?> GetByIdAsync(AircraftModelId id);
    Task<IEnumerable<AircraftModel>> GetByManufacturerIdAsync(ManufacturerId manufacturerId);
    Task<IEnumerable<AircraftModel>> GetAllAsync();
    Task SaveAsync(AircraftModel model);
    Task DeleteAsync(AircraftModelId id);
}