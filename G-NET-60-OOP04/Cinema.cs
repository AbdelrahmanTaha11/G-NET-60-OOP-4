
namespace G_NET_60_OOP04;

internal class Cinema
{
    public string Name { get; set; }
    private Ticket[] tickets;
    private int ticketCount;

    public Cinema(string name, int capacity)
    {
        Name = name;
        tickets = new Ticket[capacity];
        ticketCount = 0;
    }

    public void Open()
    {
        Console.WriteLine("========== Cinema Opened ==========");
        Console.WriteLine("Projector started.");
    }

    public void Close()
    {
        Console.WriteLine("========== Cinema Closed ==========");
        Console.WriteLine("Projector stopped.");
    }

    public void AddTicket(Ticket ticket)
    {
        if (ticketCount < tickets.Length)
        {
            tickets[ticketCount++] = ticket;
        }
    }

    public void PrintAllTickets()
    {
        Console.WriteLine("========== All Tickets ==========");
        for (int i = 0; i < ticketCount; i++)
        {
            tickets[i].PrintTicket();
            Console.WriteLine();
        }
    }

    public static void ProcessTicket(Ticket t)
    {
        Console.WriteLine("========== Process Single Ticket ==========");
        t.PrintTicket();
    }


}
