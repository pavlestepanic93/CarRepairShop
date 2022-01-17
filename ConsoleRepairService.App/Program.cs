using CarRepairShop.Domain.Models;
using CarRepairShop.Repository;
using CarRepairShop.Repository.Implementations;
using CarRepairShop.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace ConsoleRepairService.App
{
    class Program
    {
        private RepairServiceContext _context;
        private ICarRepository _carRepo;
        private IClientUserRespository _clientUserRepo;
        private IMechanicmanRepository _mechanicmanRepo;
        private IMechanicmanRoleRepository _mechanicmanRoleRepo;
        private IRepairServiceRepository _repairServiceRepo;
        static void Main(string[] args)
        {
            Program p = new Program();
            p._context = new RepairServiceContext();

            p._carRepo = new CarRepository();
            p._clientUserRepo = new ClientUserRepository();
            p._mechanicmanRepo = new MechanicmanRepository();
            p._mechanicmanRoleRepo = new MechanicmanRoleRepository();
            p._repairServiceRepo = new RepairServiceRepository();

            var cars = p._carRepo.GetCars();
            var clients = p._clientUserRepo.GetClientusers();
            var clientUser = p._clientUserRepo.GetClientusers();
            var mechanicMans = p._mechanicmanRepo.GetMechanicmans();
            var mechanicmanRoles = p._mechanicmanRoleRepo.GetMechanicmansRole();
            var repairServices = p._repairServiceRepo.GetRepairService();

            //for(int i=0; i<3; i ++)
            //{
            //    for(int j=0; j<3; j++)
            //    {
            //        RepairService newService = new RepairService();
            //        newService.CarId = j + 2;
            //        newService.MechanicmanId = i + 2;
            //        newService.DateTimeOfService = DateTime.Now;
            //        newService.Description = $"Description chanaging and referencing counters i:{i} j:{j}";
            //        p._repairServiceRepo.Add(newService);
            //    }
            //}
            //Console.WriteLine(JsonConvert.SerializeObject(clientUserList));
            foreach(var man in mechanicMans)
            {
                int serviceCounter = p._context.RepairService.Where(x => x.MechanicmanId == man.MechanicmanId).Count();
                int carCounter = p._context.RepairService.Where(m => m.MechanicmanId == man.MechanicmanId).Select(x => x.CarId).Distinct().Count();

                Console.WriteLine($"Mechanicman {man.Name} has {serviceCounter} services, and done it for {carCounter} cars");
            }
            Console.ReadLine();

            //Direktno odavde treba dodati RepairService
            //Treba ubaciti RepairService preko koda

        }
    }
}