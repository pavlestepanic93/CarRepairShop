using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarRepairShop.Domain.Models
{
    public class RepairService
    {
        [Key]
        public int RepairServiceId { get; set; }
        public string Description { get; set; }
        public DateTime DateTimeOfService { get; set; }
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
        public int MechanicmanId { get; set; }
        public virtual Mechanicman Mechanicman { get; set; }

    }
}
