using CarRepairShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRepairShop.Repository.Interfaces
{
    public interface IMechanicmanRoleRepository
    {
        MechanicmanRole GetMechanicmanRoleById(int id);
        IEnumerable<MechanicmanRole> GetMechanicmansRole();
        MechanicmanRole Add(MechanicmanRole mechanicman);
        MechanicmanRole Update(MechanicmanRole mechanicmanChange);
        MechanicmanRole Delete(int id);
    }
}
