using CarRepairShop.Domain.Models;
using CarRepairShop.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRepairShop.Repository.Implementations
{
    public class RepairServiceRepository : IRepairServiceRepository
    {
        private readonly RepairServiceContext _context;
        public RepairServiceRepository(RepairServiceContext context)
        {
            _context = context;
        }
        public RepairServiceRepository()
        {
            _context = new RepairServiceContext();
        }
        public RepairService Add(RepairService repairService)
        {
            _context.RepairService.Add(repairService);
            _context.SaveChanges();
            return repairService;
        }

        public RepairService Delete(int id)
        {
            RepairService repairService = _context.RepairService.Find(id);
            if (repairService != null)
            {
                _context.RepairService.Remove(repairService);
                _context.SaveChanges();
            }
            return repairService;
        }

        public IEnumerable<RepairService> GetRepairService()
        {
            return _context.RepairService;
        }

        public RepairService GetRepairServiceById(int id)
        {
            return _context.RepairService.Find(id);
        }

        public RepairService Update(RepairService repairServiceChange)
        {
            var repairService = _context.RepairService.Attach(repairServiceChange);
            repairService.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return repairServiceChange;
        }
    }
}
