using DI_Demo_BootCamp.Core.Models;
using DI_Demo_BootCamp.Services.Interfaces;
using System.Collections.Generic;
using System.Web.Http;

namespace DI_Demo_BootCamp.Web.Controllers
{
    public class CarsController : ApiController
    {
        private  ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        // GET: Cars
        public IEnumerable<Car> Get()
        {
            var cars = _carService.GetAllCars();
            return cars;
        }

        //private readonly DI_Demo_BootCampWebContext _db;
        //public CarsController(DI_Demo_BootCampWebContext db)
        //{
        //    _db = db;
        //}

        //// GET: Cars
        //public IEnumerable<Car> Get()
        //{
        //    var cars = _db.Cars.ToList();
        //    return cars;
        //}
    }
}
