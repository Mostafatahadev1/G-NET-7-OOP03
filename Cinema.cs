namespace Assignment_session_03
{
    public class Cinema
    {
        private Ticket[] tickets = new Ticket[20];
        private Projector projector = new Projector();

        public void OpenCinema()
        {
            Console.WriteLine("========= Cinema Opened =========");
            projector.Start();
        }

        public void CloseCinema()
        {
            projector.Stop();
        }

        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("\n========= All Tickets =========");

            foreach (var t in tickets)
            {
                if (t != null)
                    Console.WriteLine(t);
            }

            Console.WriteLine("\n========= Statistics =========");
            Console.WriteLine($"Total Tickets Created: {Ticket.GetTotalTickets()}");
        }
    }
}