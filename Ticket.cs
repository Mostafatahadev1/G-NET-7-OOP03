using System;

namespace Assignment_session_03
{
    public class Ticket
    {
        private string movieName;
        private double price; 

        public int TicketId { get; }

        private static int ticketCounter = 0;

    
        public Ticket(string movieName, TicketType type, Seat seat, double price)
        {
            ticketCounter++;
            TicketId = ticketCounter;

            MovieName = movieName;
            Type = type;
            Seat = seat;
            Price = price; 
        }

        // Constructor افتراضي
        public Ticket(string movieName)
            : this(movieName, TicketType.Standard, new Seat('A', 1), 50)
        {
        }

        // Properties
        public string MovieName
        {
            get => movieName;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    movieName = value;
            }
        }

        public double Price
        {
            get => price;
            set
            {
                if (value > 0)
                    price = value;
            }
        }

        public double PriceAfterTax
        {
            get => price * 1.14;
        }

        public TicketType Type { get; set; }

        public Seat Seat { get; set; }

        
        public double CalcTotal(double taxPercent)
        {
            return Price + (Price * taxPercent / 100);
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

        public static int GetTotalTicketsSold()
        {
            return ticketCounter;
        }

        public double GetPriceAfterTax()
        {
            return Price * 1.14; // 14% tax
        }
    }



    }
