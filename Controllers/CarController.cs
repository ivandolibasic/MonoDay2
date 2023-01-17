using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VehicleTracking.WebAPI.Models;

namespace VehicleTracking.WebAPI.Controllers
{
    public class CarController : ApiController
    {
        private CarRepository carRepository = new CarRepository();

        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return carRepository.GetCars();
        }

        [HttpPost]
        public void Post([FromBody] Car car)
        {
            carRepository.AddCar(car);
        }

        [HttpPut]
        public void Put([FromBody] Car car)
        {
            carRepository.UpdateCar(car.Name, car);
        }

        [HttpDelete]
        public void Delete([FromBody] string name)
        {
            carRepository.DeleteCar(name);
        }
    }
}