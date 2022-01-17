using CarRepairShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRepairShop.Repository.Interfaces
{
    public interface ICarRepository
    {
        Car GetCar(int id);
        IEnumerable<Car> GetCars();
        Car Add(Car car);
        Car Update(Car carChanges);
        Car Delete(int id);
    }
}
