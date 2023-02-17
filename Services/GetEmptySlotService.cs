using ParkingLot.Injectors;
using ParkingLot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Services
{
    class GetEmptySlotService
    {
        public Slot getEmptySlot(Injector injector,string slotCategory, List<Slot> slots)
        {

            List<string> occupiedSlots = getOccupiedSlots(injector, slotCategory, slots);

            Slot freeSlot = null;


            foreach (Slot slot in slots)
            {
                if (slot.category == slotCategory && !occupiedSlots.Contains(slot.name))
                {
                    freeSlot = slot;
                    break;
                }
            }

            return freeSlot;
        }
        public List<string> getOccupiedSlots(Injector injector, string slotCategory, List<Slot> slots)
        {
            List<Ticket> tickets = injector.ReadTickets();

            List<string> occupiedSlots = new List<string>();
            foreach (Ticket ticket in tickets)
            {
                occupiedSlots.Add(ticket.slot.name);
            }
            return occupiedSlots;
        }
    }
}
