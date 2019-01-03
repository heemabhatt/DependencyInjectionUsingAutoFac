using DI_Demo_BootCamp.Core.Models;
using System.Collections.Generic;

namespace DI_Demo_BootCamp.Services.Interfaces
{
    public interface ICarService
    {
        List<Car> GetAllCars();
        Car GetCarById(int id);
    }
}
