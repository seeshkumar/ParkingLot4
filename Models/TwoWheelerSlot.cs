using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    class TwoWheelerSlot : Slot
    {
        public TwoWheelerSlot(string name) : base(name)
        {
            this.category = "TWOWHEELER";
        }
    }
}
