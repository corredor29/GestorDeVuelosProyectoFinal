using System;

namespace GestorDeVuelosProyectoFinal.src.Moduls.DocumentTypes.Infrastructure.Entity;

public class DocumentTypesEntity
{
    public Guid Id { get; set; } 
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;

}
