using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketSystem
{
    public class TicketReservationSystem
    {

        private List<Ticket> tickets;

        public TicketReservationSystem()
        {
            tickets = new List<Ticket>();
        }

        public void AddTicket(Ticket ticket)
        {
            tickets.Add(ticket);
        }

        public void ReserveTicket(int seatNumber)
        {
            Ticket ticket = tickets.Find(t => t.SeatNumber == seatNumber && !t.IsReserved);

            if (ticket == null)
            {
                Console.WriteLine("Sorry, the selected seat is already reserved or does not exist.");
            }
            else
            {
                ticket.IsReserved = true;
                Console.WriteLine("Ticket for {0} to {1} on {2} has been reserved. Seat number: {3}",
                    ticket.Destination, ticket.DepartureDate.ToShortDateString(),
                    ticket.DepartureDate.ToShortTimeString(), ticket.SeatNumber);
            }
        }

        public void DisplayAvailableTickets()
        {
            Console.WriteLine("Available tickets:");
            foreach (Ticket ticket in tickets)
            {
                if (!ticket.IsReserved)
                {
                    Console.WriteLine("Seat number: {0}, Destination: {1}, Departure Date: {2}, Departure Time: {3}",
                        ticket.SeatNumber, ticket.Destination, ticket.DepartureDate.ToShortDateString(),
                        ticket.DepartureDate.ToShortTimeString());
                }
            }
        }
    }

}

