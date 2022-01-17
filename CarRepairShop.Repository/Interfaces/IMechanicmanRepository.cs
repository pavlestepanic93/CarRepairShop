using CarRepairShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRepairShop.Repository.Interfaces
{
    public interface IMechanicmanRepository
    {
        Mechanicman GetMechanicmanById(int id);
        IEnumerable<Mechanicman> GetMechanicmans();
        Mechanicman Add(Mechanicman mechanicman);
        Mechanicman Update(Mechanicman mechanicmanChange);
        Mechanicman Delete(int id);
    }
}
