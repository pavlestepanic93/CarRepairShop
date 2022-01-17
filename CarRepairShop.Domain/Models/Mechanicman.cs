using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarRepairShop.Domain.Models
{
    public class Mechanicman
    {
        [Key]
        public int MechanicmanId { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
        public string Jmbg { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual MechanicmanRole MechanicmanRole { get; set; }
        public virtual ICollection<RepairService> RepairServices { get; set; }
    }
}
