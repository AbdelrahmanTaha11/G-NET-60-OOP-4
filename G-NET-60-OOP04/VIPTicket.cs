
namespace G_NET_60_OOP04;

internal class VIPTicket:Ticket
{
    public bool LoungeAccess { get; set; }
    public decimal ServiceFee { get; set; }

    public VIPTicket(string movieName, bool loungeAccess, decimal serviceFee) : base(movieName)
    {
        LoungeAccess = loungeAccess;
        ServiceFee = serviceFee;
    }

    public override void PrintTicket()
    {
        base.PrintTicket();
        Console.WriteLine($"Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP");
    }
}




