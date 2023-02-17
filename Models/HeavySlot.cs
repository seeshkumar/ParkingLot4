using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    class HeavySlot : Slot
    {
        public HeavySlot(string name) : base(name)
        {
            this.category = "HEAVY";
        }
    }
}
