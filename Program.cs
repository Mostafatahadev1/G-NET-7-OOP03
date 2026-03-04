namespace Assignment_session_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1
            #region A
            // a =>  Composition
            // Reason: Department cannot exist independently without the University.
            // If the University is closed, all Departments are destroyed.
            #endregion

            #region B
            // b =>  Association
            // Reason: Driver uses a Car but does not own it.
            // There is no whole-part relationship between them.
            #endregion

            #region C
            // c => Inheritance
            // Reason: A Dog is an Animal, which represents an IS-A relationship.
            #endregion

            #region D
            // d =>  Aggregation
            // Reason: Players can exist independently of the Team.
            // If the Team is deleted, Players still exist.
            #endregion

            #region e
            // e =>  Dependency
            // Reason: Logger is used only as a method parameter temporarily
            // and is not stored as a field. This represents the weakest relationship.
            #endregion

            #endregion

            #region Part 2
            #region A
            /*
                
               A =>  Yes, a child class in a different assembly can access a protected field 
                because protected allows access through inheritance.
                
                However, it cannot be accessed through an object instance from outside 
                the class hierarchy. Protected members are only accessible inside the 
                class itself or inside derived classes.
           */
            #endregion

            #region B
            /*
                
               B => protected internal:
                Accessible either from the same assembly OR from derived classes (even if they are in a different assembly).
                
              private protected:

                Accessible only within the same assembly AND only through inheritance.
                

            */
            #endregion

            #region C
            /*
            c => Sealed is a modifier that can be applied to classes and methods in C#.
            When sealed is applied to a class:
            It prevents the class from being inherited.
            
            Example:
            sealed class MyClass { }
            
            When sealed is applied to a method:
            It prevents further overriding in derived classes.
            It must be used with an overridden method.
            
            So:
            sealed class → no inheritance
            sealed method → no further override
            */
            #endregion

            #region D
            /*
                d =>  Yes, you can create an object from a sealed class using new.
                
                The sealed keyword only prevents inheritance,
                but it does not prevent object instantiation.
                
            */

            #endregion

            #endregion

            #region Assignment 1 
            // Console.Write("Enter Movie Name: ");
            // string movieName = Console.ReadLine();
            //
            // Console.Write("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX): ");
            // int typeInput = int.Parse(Console.ReadLine());
            // TicketType type = (TicketType)typeInput;
            //
            // Console.Write("Enter Seat Row (A, B, C...): ");
            // char row = char.Parse(Console.ReadLine());
            //
            // Console.Write("Enter Seat Number: ");
            // int number = int.Parse(Console.ReadLine());
            //
            // Console.Write("Enter Price: ");
            // double price = double.Parse(Console.ReadLine());
            //
            // Console.Write("Enter Discount Amount: ");
            // double discount = double.Parse(Console.ReadLine());
            //
            // Seat seat = new Seat(row, number);
            // Ticket ticket = new Ticket(movieName, type, seat, price);
            //
            // Console.WriteLine();
            //
            // double total = ticket.CalcTotal(14);
            //
            // ticket.PrintTicket();
            // Console.WriteLine($"Total (14% tax) : {total:F2}");
            //
            // Console.WriteLine();
            // Console.WriteLine("===== After Discount =====");
            //
            // Console.WriteLine($"Discount Before : {discount:F2}");
            // ticket.ApplyDiscount(ref discount);
            // Console.WriteLine($"Discount After  : {discount:F2}");
            //
            // ticket.PrintTicket();
            #endregion

            #region Assignment 2
         //  Console.WriteLine("========= Ticket Booking =========\n");
         //
         //  List<Ticket> tickets = new List<Ticket>();
         //
         //  for (int i = 1; i <= 3; i++)
         //  {
         //      Console.WriteLine($"Enter data for Ticket {i}:");
         //
         //      Console.Write("Movie Name: ");
         //      string movieName = Console.ReadLine();
         //
         //      Console.Write("Ticket Type (0=Standard, 1=VIP, 2=IMAX): ");
         //      TicketType type = (TicketType)int.Parse(Console.ReadLine());
         //
         //      Console.Write("Seat Row (A-Z): ");
         //      char row = char.Parse(Console.ReadLine());
         //
         //      Console.Write("Seat Number: ");
         //      int number = int.Parse(Console.ReadLine());
         //
         //      Console.Write("Price: ");
         //      double price = double.Parse(Console.ReadLine());
         //
         //      Seat seat = new Seat(row, number);
         //      Ticket ticket = new Ticket(movieName, type, seat, price);
         //
         //      tickets.Add(ticket);
         //
         //      Console.WriteLine();
         //  }
         //
         //  Console.WriteLine("========= All Tickets =========\n");
         //
         //  int count = 1;
         //  foreach (var t in tickets)
         //  {
         //      Console.WriteLine(
         //          $"Ticket #{count} | {t.MovieName} | {t.Type} | Seat: {t.Seat} | Price: {t.Price} EGP | After Tax: {t.GetPriceAfterTax()} EGP"
         //      );
         //      count++;
         //  }
         //
         //  Console.WriteLine("\n========= Search by Movie =========");
         //  Console.Write("Enter movie name to search: ");
         //  string search = Console.ReadLine();
         //
         //  var found = tickets.FirstOrDefault(t => t.MovieName.ToLower() == search.ToLower());
         //
         //  if (found != null)
         //  {
         //      Console.WriteLine(
         //          $"Found: {found.MovieName} | {found.Type} | Seat: {found.Seat} | Price: {found.Price} EGP"
         //      );
         //  }
         //  else
         //  {
         //      Console.WriteLine("Movie not found.");
         //  }
            #endregion

            

        }
    }
}
