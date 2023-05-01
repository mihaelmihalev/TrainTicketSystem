using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketSystem
{
    public class Ticket
    {
            public string Destination { get; set; }
            public DateTime DepartureDate { get; set; }
            public int SeatNumber { get; set; }
            public bool IsReserved { get; set; }

    }
}
