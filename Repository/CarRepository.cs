using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DhlSystem.Model;

namespace DhlSystem.Repository
{
    internal class CarRepository
    {
        private DhlSystemContext dhlContext;

        public CarRepository(DhlSystemContext context)
        {
            this.dhlContext = context;
        }
        public List<Car> GetCars()
        {
            return dhlContext.Cars.ToList();
        }
        public Car GetCarById(int id)
        {
            return dhlContext.Cars.Find(id);
        }
        public void InsertCar(Car car)
        {
            dhlContext.Cars.Add(car);
        }
        public void DeleteCar(int id)
        {
            dhlContext.Cars.Remove(dhlContext.Cars.Find(id));
        }
        public void UpdateCar(Car car) 
        {
            dhlContext.Cars.Find(car.Id).Brand = car.Brand;
            dhlContext.Cars.Find(car.Id).Type = car.Type;
            dhlContext.Cars.Find(car.Id).Plate = car.Plate;
            dhlContext.Cars.Find(car.Id).Km = car.Km;
        }
        public void Save()
        {
            dhlContext.SaveChanges();
        }
        public void Dispose()
        {
            dhlContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
