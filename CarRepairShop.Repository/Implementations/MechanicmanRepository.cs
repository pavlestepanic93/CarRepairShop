using CarRepairShop.Domain.Models;
using CarRepairShop.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRepairShop.Repository.Implementations
{
    public class MechanicmanRepository : IMechanicmanRepository
    {
        private readonly RepairServiceContext _context;
        public MechanicmanRepository(RepairServiceContext context)
        {
            _context = context;
        }
        public MechanicmanRepository()
        {
            _context = new RepairServiceContext();
        }
        public Mechanicman Add(Mechanicman mechanicman)
        {
            _context.Mechanicmans.Add(mechanicman);
            _context.SaveChanges();
            return mechanicman;
        }

        public Mechanicman Delete(int id)
        {
            Mechanicman mechanicman = _context.Mechanicmans.Find(id);
            if (mechanicman != null)
            {
                _context.Mechanicmans.Remove(mechanicman);
                _context.SaveChanges();
            }
            return mechanicman;
        }

        public Mechanicman GetMechanicmanById(int id)
        {
            return _context.Mechanicmans.Find(id);
        }

        public IEnumerable<Mechanicman> GetMechanicmans()
        {
            return _context.Mechanicmans;
        }

        public Mechanicman Update(Mechanicman mechanicmanChange)
        {
            var mechanicman = _context.Mechanicmans.Attach(mechanicmanChange);
            mechanicman.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return mechanicmanChange;
        }
    }
}
