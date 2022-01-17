using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarRepairShop.Domain.Models
{
    public class Clientuser
    {
        [Key]
        public int ClientuserId { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
        public string Email { get; set; }
        public string Jmbg { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
