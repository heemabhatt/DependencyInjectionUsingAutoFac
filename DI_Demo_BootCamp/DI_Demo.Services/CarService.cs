using DI_Demo_BootCamp.Core.Models;
using DI_Demo_BootCamp.Data.Interfaces;
using DI_Demo_BootCamp.Services.Interfaces;
using System.Collections.Generic;

namespace DI_Demo_BootCamp.Services
{
    public class CarService : ICarService
    {
        private ICarsRepository _carsRepository;

        public CarService(ICarsRepository carRepository)
        {
            _carsRepository = carRepository;
        }

        public List<Car> GetAllCars()
        {
            return _carsRepository.GetCollection();
        }

        public Car GetCarById(int id)
        {
            return _carsRepository.GetCarById(id);
        }
    }
}
