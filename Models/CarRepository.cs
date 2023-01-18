using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleTracking.WebAPI.Models
{
    public class CarRepository
    {
        private List<Car> cars;

        public CarRepository()
        {
            cars = new List<Car>
            {
                new Car { Id = 1, Name = "Ford" },
                new Car { Id = 2, Name = "Chevrolet" },
                new Car { Id = 3, Name = "Dodge" }
            };
        }

        public List<Car> ReadCars()
        {
            return cars;
        }

        public void CreateCar(Car newCar)
        {
            cars.Add(newCar);
        }

        public void UpdateCar(int id, Car updatedCar)
        {
            var car = cars.Find(c => c.Id == id);
            car.Name = updatedCar.Name;
        }

        public void DeleteCar(int id)
        {
            var car = cars.Find(c => c.Id == id);
            cars.Remove(car);
        }
    }
}