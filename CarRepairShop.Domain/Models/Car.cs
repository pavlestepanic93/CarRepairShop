using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarRepairShop.Domain.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string CarModel { get; set; }
        public string CarChassis { get; set; }
        public string CarYear { get; set; }
        public int ClientuserId { get; set; }
        public virtual Clientuser Clientuser { get; set; }
        public virtual ICollection<RepairService> RepairServices { get; set; }
    }
}
