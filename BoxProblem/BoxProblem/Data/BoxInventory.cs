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
        [DisplayName("WEIGHT")]
        public int Weight { get; set; }

        [Range(0,1000000)]
        [DisplayName("VOLUME")]
        public int Volume { get; set; }

        [DisplayName("CAN HOLD LIQUID")]
        public bool CanHoldLiquid { get; set; }

        [Range(0,1000000)]
        [DisplayName("COST")]
        public double Cost { get; set; }

        [Range(0,1000000)]
        [DisplayName("INVENTORY COUNT")]
        public int InventoryCount { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
