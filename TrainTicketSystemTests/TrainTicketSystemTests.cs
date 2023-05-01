using TrainTicketSystem;

namespace TrainTicketSystemTests
{
    public class TrainTicketSystemTests
    {
        private TrainTicketPrice Ticket { get; set; } = null!;
        private TicketReservationSystem TicketReservation { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
            Ticket = new TrainTicketPrice();
            TicketReservation = new TicketReservationSystem();
        }

        [Test]
        public void CalculatePriceForTwoWay_Test1()
        {
            decimal price = Ticket.CalculatePriceForTwoWay(100.0m, false);
            Assert.AreEqual(100.0m, price);
        }

        [Test]
        public void CalculatePriceForTwoWay_Test2()
        {
            decimal price = Ticket.CalculatePriceForTwoWay(100.0m, true);
            Assert.AreEqual(200.0m, price);
        }

        [Test]
        public void CalculatePrice_Test3()
        {
            decimal price = Ticket.CalculatePrice(1,100.0m, false,TimeSpan.FromHours(8),false,false,false);
            Assert.AreEqual(100.0m, price);
        }

        [Test]
        public void CalculatePrice_Test4()
        {
            decimal price = Ticket.CalculatePrice(1, 100.0m, false, TimeSpan.FromHours(11), false, false, false);
            Assert.AreEqual(95.0m, price);
        }

        [Test]
        public void CalculatePrice_Test5()
        {
            decimal price = Ticket.CalculatePrice(1, 100.0m, false, TimeSpan.FromHours(11), true, false, false);
            Assert.AreEqual(61.0m, price);
        }

        [Test]
        public void CalculatePrice_Test6()
        {
            decimal price = Ticket.CalculatePrice(2, 100.0m, false, TimeSpan.FromHours(11), false, true, false);
            Assert.AreEqual(170.0m, price);
        }

        [Test]
        public void CalculatePrice_Test7()
        {
            decimal price = Ticket.CalculatePrice(2, 100.0m, false, TimeSpan.FromHours(11), false, true, true);
            Assert.AreEqual(90.0m, price);
        }

        [Test]
        public void CalculatePrice_Test8()
        {
            decimal price = Ticket.CalculatePrice(2, 100.0m, false, TimeSpan.FromHours(11), true, true, false);
            Assert.AreEqual(102.0m, price);
        }

        [Test]
        public void CalculatePrice_Test9()
        {
            decimal price = Ticket.CalculatePrice(1, 100.0m, true, TimeSpan.FromHours(8), false, false, false);
            Assert.AreEqual(200.0m, price);
        }

        [Test]
        public void CalculatePrice_Test10()
        {
            decimal price = Ticket.CalculatePrice(2, 100.0m, true, TimeSpan.FromHours(11), false, true, true);
            Assert.AreEqual(180.0m, price);
        }

        [Test]
        public void CalculatePrice_Test11()
        {
            decimal price = Ticket.CalculatePrice(2, 100.0m, true, TimeSpan.FromHours(11), true, true, false);
            Assert.AreEqual(204.0m, price);
        }

        [Test]
        public void CalculatePrice_Test12()
        {
            decimal price = Ticket.CalculatePrice(1, 100.0m, false, TimeSpan.FromHours(20), false, false, false);
            Assert.AreEqual(95.0m, price);
        }

        [Test]
        public void ReserveTicket_Test13()
        {
            Ticket ticket1 = new Ticket { Destination = "New York", DepartureDate = new DateTime(2023, 4, 10, 10, 30, 0), SeatNumber = 1 };
            TicketReservation.AddTicket(ticket1);
            TicketReservation.ReserveTicket(1);
            Assert.IsTrue(ticket1.IsReserved);
        }

        [Test]
        public void ReserveTicket_Test14()
        {
            Ticket ticket1 = new Ticket { Destination = "New York", DepartureDate = new DateTime(2023, 4, 10, 10, 30, 0), SeatNumber = 1 };
            TicketReservation.AddTicket(ticket1);
            TicketReservation.ReserveTicket(1);
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            TicketReservation.ReserveTicket(1);
            Assert.AreEqual("Sorry, the selected seat is already reserved or does not exist.\r\n", stringWriter.ToString());
            Console.SetOut(Console.Out);
        }

        [Test]
        public void ReserveTicket_Test15()
        {
            Ticket ticket1 = new Ticket { Destination = "New York", DepartureDate = new DateTime(2023, 4, 10, 10, 30, 0), SeatNumber = 1 };
            TicketReservation.AddTicket(ticket1);
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            TicketReservation.ReserveTicket(2);
            Assert.AreEqual("Sorry, the selected seat is already reserved or does not exist.\r\n", stringWriter.ToString());
            Console.SetOut(Console.Out);
        }

    }
}