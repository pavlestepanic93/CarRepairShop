using CarRepairShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRepairShop.Repository.Interfaces
{
    public interface IClientUserRespository
    {
        Clientuser GetClientuser(int id);
        IEnumerable<Clientuser> GetClientusers();
        Clientuser Add(Clientuser clientUser);
        Clientuser Update(Clientuser clientUserChanges);
        Clientuser Delete(int id);
    }
}
