using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketSystem
{
    public class Train
    {
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }

        public override string ToString()
        {
            return string.Format("Vlak {0}, trugvasht na {1}", Destination, DepartureTime);
        }
    }
}

