using CarRepairShop.Domain.Models;
using CarRepairShop.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRepairShop.Repository.Implementations
{
    public class MechanicmanRoleRepository : IMechanicmanRoleRepository
    {
        private readonly RepairServiceContext _context;
        public MechanicmanRoleRepository(RepairServiceContext context)
        {
            _context = context;
        }
        public MechanicmanRoleRepository()
        {
            _context = new RepairServiceContext();
        }
        public MechanicmanRole Add(MechanicmanRole MechanicmanRole)
        {
            _context.MechanicmanRole.Add(MechanicmanRole);
            _context.SaveChanges();
            return MechanicmanRole;
        }

        public MechanicmanRole Delete(int id)
        {
            MechanicmanRole MechanicmanRole = _context.MechanicmanRole.Find(id);
            if (MechanicmanRole != null)
            {
                _context.MechanicmanRole.Remove(MechanicmanRole);
                _context.SaveChanges();
            }
            return MechanicmanRole;
        }

        public MechanicmanRole GetMechanicmanRoleById(int id)
        {
            return _context.MechanicmanRole.Find(id);
        }

        public IEnumerable<MechanicmanRole> GetMechanicmansRole()
        {
            return _context.MechanicmanRole;
        }

        public MechanicmanRole Update(MechanicmanRole MechanicmanRoleChange)
        {
            var MechanicmanRole = _context.MechanicmanRole.Attach(MechanicmanRoleChange);
            MechanicmanRole.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return MechanicmanRoleChange;
        }
    }
}
