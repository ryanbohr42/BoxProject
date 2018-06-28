using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoxProblem.Data
{
    public class BoxInventory
    { 
        [Key]
        public int Id { get; set; }

        [Range(0,1000000)]
        public int Weight { get; set; }

        [Range(0,1000000)]
        public int Volume { get; set; }

        [DisplayName("Can Hold Liquid?")]
        public bool CanHoldLiquid { get; set; }

        [Range(0,1000000)]
        public double Cost { get; set; }

        [Range(0,1000000)]
        [DisplayName("Inventory Count")]
        public int InventoryCount { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
