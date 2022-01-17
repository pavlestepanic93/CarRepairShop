using CarRepairShop.Domain.Models;
using CarRepairShop.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRepairShop.Repository.Implementations
{
    public class CarRepository : ICarRepository
    {
        private readonly RepairServiceContext _context;
        public CarRepository(RepairServiceContext context)
        {
            _context = context;
        }
        public CarRepository()
        {
            _context = new RepairServiceContext();
        }
        public Car Add(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
            return car;
        }

        public Car Delete(int id)
        {
            Car car = _context.Cars.Find(id);
            if(car != null)
            {
                _context.Cars.Remove(car);
                _context.SaveChanges();
            }
            return car;
        }

        public Car GetCar(int id)
        {
            return _context.Cars.Find(id);
        }

        public IEnumerable<Car> GetCars()
        {
            return _context.Cars;
        }

        public Car Update(Car carChanges)
        {
            var car = _context.Cars.Attach(carChanges);
            car.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return carChanges;
        }
    }
}
