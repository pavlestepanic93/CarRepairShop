using CarRepairShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRepairShop.Repository.Interfaces
{
    public interface IRepairServiceRepository
    {
        RepairService GetRepairServiceById(int id);
        IEnumerable<RepairService> GetRepairService();
        RepairService Add(RepairService repairService);
        RepairService Update(RepairService repairServiceChange);
        RepairService Delete(int id);
    }
}
