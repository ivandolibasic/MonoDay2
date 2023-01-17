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
                new Car { Name = "Ford", HorsePower = 450 },
                new Car { Name = "Chevrolet", HorsePower = 550 },
                new Car { Name = "Dodge", HorsePower = 300 }
            };
        }

        public List<Car> GetCars()
        {
            return cars;
        }

        public void AddCar(Car newCar)
        {
            cars.Add(newCar);
        }

        public void UpdateCar(string name, Car updatedCar)
        {
            var carToUpdate = cars.FirstOrDefault(c => c.Name == name);
            if (carToUpdate != null)
            {
                carToUpdate.Name = updatedCar.Name;
                carToUpdate.HorsePower = updatedCar.HorsePower;
            }
        }


        public void DeleteCar(string name)
        {
            var carToDelete = cars.FirstOrDefault(c => c.Name == name);
            if (carToDelete != null)
            {
                cars.Remove(carToDelete);
            }
        }
    }
}