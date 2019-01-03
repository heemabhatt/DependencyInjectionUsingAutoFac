using DI_Demo_BootCamp.Core.Models;
using DI_Demo_BootCamp.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DI_Demo_BootCamp.Data
{
    public class CarsRepository : ICarsRepository
    {
        private readonly DI_Demo_BootCampWebContext _db;
        private List<Car> _cars;
        public CarsRepository(DI_Demo_BootCampWebContext db)
        {
            _db = db;
            //_cars = new List<Car>() { new Car {Id=1,Name="Honda" }, new Car { Id = 2, Name = "Toyota" } };

            _cars = _db.Cars.ToList();
        }
        public List<Car> GetCollection()
        {
            return _cars;
        }

        public Car GetCarById(int id)
        {
            return _cars.Find(c => c.Id == id);
        }
    }
}
