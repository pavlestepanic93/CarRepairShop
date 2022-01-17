using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRepairShop.Domain.Models
{
    public class RepairServiceContext : DbContext
    {
        public RepairServiceContext(DbContextOptions<RepairServiceContext> options)
        : base(options) { }
        public RepairServiceContext()
        {

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Clientuser> Clientusers { get; set; }
        public DbSet<Mechanicman> Mechanicmans { get; set; }
        public DbSet<MechanicmanRole> MechanicmanRole { get; set; }
        public DbSet<RepairService> RepairService { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=RepairService;Trusted_Connection=True;");
        }
    }
}
