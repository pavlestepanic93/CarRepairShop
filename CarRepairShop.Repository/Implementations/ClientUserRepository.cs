using CarRepairShop.Domain.Models;
using CarRepairShop.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRepairShop.Repository.Implementations
{
    public class ClientUserRepository : IClientUserRespository
    {
        private readonly RepairServiceContext _context;
        public ClientUserRepository(RepairServiceContext context)
        {
            _context = context;
        }
        public ClientUserRepository()
        {
            _context = new RepairServiceContext();
        }
        public Clientuser Add(Clientuser clientUser)
        {
            _context.Clientusers.Add(clientUser);
            _context.SaveChanges();
            return clientUser;
        }

        public Clientuser Delete(int id)
        {
            Clientuser user = _context.Clientusers.Find(id);
            if(user != null)
            {
                _context.Clientusers.Remove(user);
                _context.SaveChanges();
            }
            return user;
        }

        public Clientuser GetClientuser(int id)
        {
            return _context.Clientusers.Find(id);
        }

        public IEnumerable<Clientuser> GetClientusers()
        {
            return _context.Clientusers;
        }

        public Clientuser Update(Clientuser clientUserChanges)
        {
            var user = _context.Clientusers.Attach(clientUserChanges);
            user.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return clientUserChanges;
        }
    }
}
