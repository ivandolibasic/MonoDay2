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

        // GET api/Car
        [HttpGet]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.OK, carRepository.ReadCars());
        }

        // POST api/Car
        [HttpPost]
        public HttpResponseMessage Post(HttpRequestMessage request, [FromBody] Car car)
        {
            carRepository.CreateCar(car);
            return request.CreateResponse(HttpStatusCode.OK);
        }

        // PUT api/Car?id=1
        [HttpPut]
        public HttpResponseMessage Put(HttpRequestMessage request, int id, [FromBody] Car car)
        {
            carRepository.UpdateCar(id, car);
            return request.CreateResponse(HttpStatusCode.OK);
        }

        // DELETE api/Car?id=1
        [HttpDelete]
        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            carRepository.DeleteCar(id);
            return request.CreateResponse(HttpStatusCode.OK);
        }
    }
}