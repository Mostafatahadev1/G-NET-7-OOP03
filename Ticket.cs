using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_session_03
{
    public  class Ticket
    {
        public string MovieName;
        public TicketType Type;
        public Seat Seat;

        private double Price;


        public Ticket(string movieName, TicketType type, Seat seat, double price)
        {
            MovieName = movieName;
            Type = type;
            Seat = seat;
            Price = price;
        }


        public Ticket(string movieName)
            : this(movieName, TicketType.Standard, new Seat('A', 1), 50)
        {
        }

        public double CalcTotal(double taxPercent)
        {
            double total = Price + (Price * taxPercent / 100);
            return total;
        }


        public void ApplyDiscount(ref double discountAmount)
        {
            if (discountAmount > 0 && discountAmount <= Price)
            {
                Price -= discountAmount;
                discountAmount = 0;
            }
        }

  
        public void PrintTicket()
        {
            Console.WriteLine("===== Ticket Info =====");
            Console.WriteLine($"Movie  : {MovieName}");
            Console.WriteLine($"Type   : {Type}");
            Console.WriteLine($"Seat   : {Seat}");
            Console.WriteLine($"Price  : {Price:F2}");
        }
    }
}
