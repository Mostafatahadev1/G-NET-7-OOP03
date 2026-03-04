namespace Assignment_session_03
{
    public abstract class Ticket
    {
        private static int ticketCounter = 0;
        private static int bookingCounter = 0;

        public int TicketId { get; }
        public string BookingReference { get; }
        public string MovieName { get; set; }

        private decimal price;
        public decimal Price
        {
            get => price;
            set
            {
                if (value <= 0)
                    throw new Exception("Price must be > 0");
                price = value;
            }
        }

        public decimal PriceAfterTax => Price * 1.14m;

        public Ticket(string movieName, decimal price)
        {
            ticketCounter++;
            TicketId = ticketCounter;

            bookingCounter++;
            BookingReference = $"BK-{bookingCounter}";

            MovieName = movieName;
            Price = price;
        }

        public static int GetTotalTickets()
        {
            return ticketCounter;
        }

        public override string ToString()
        {
            return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP";
        }
    }
}