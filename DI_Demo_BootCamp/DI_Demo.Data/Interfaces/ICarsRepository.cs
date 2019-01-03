using DI_Demo_BootCamp.Core.Models;
using System.Collections.Generic;

namespace DI_Demo_BootCamp.Data.Interfaces
{
    public interface ICarsRepository
    {
        List<Car> GetCollection();
        Car GetCarById(int id);
    }
}
