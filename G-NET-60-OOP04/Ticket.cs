
namespace G_NET_60_OOP04;

internal class Ticket
{
    private static int ticketCounter = 0;
    public int TicketId { get; private set; }
    public string MovieName { get; set; }
    public decimal Price { get; protected set; }
    public decimal PriceAfterTax { get; protected set; }

    public Ticket(string movieName)
    {
        TicketId = ++ticketCounter;
        MovieName = movieName;
    }

    public void SetPrice(decimal price)
    {
        Price = price;
        PriceAfterTax = price * 1.14m; 
    }

    public void SetPrice(decimal basePrice, decimal multiplier)
    {
        Price = basePrice * multiplier;
        PriceAfterTax = Price * 1.14m;
    }

    public virtual void PrintTicket()
    {
        Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP");
    }


}
