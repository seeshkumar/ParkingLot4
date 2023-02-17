using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    class FourWheelerSlot : Slot
    {
        public FourWheelerSlot(string name) : base(name)
        {
            this.category = "FOURWHEELER";
        }
    }
}
