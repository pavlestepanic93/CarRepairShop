using CarRepairShop.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarRepairShop.Domain.Models
{
    public class MechanicmanRole
    {
        [Key]
        public int MechanicmanRoleId { get; set; }
        public MechanicmanRoleName MechanicManRoleName { get; set; }
        public int MechanicmanId { get; set; }
        public Mechanicman Mechanicman { get; set; }
    }
}
