
namespace G_NET_60_OOP04;

internal class IMAXTicket:Ticket
{
    public bool Is3D { get; set; }

    public IMAXTicket(string movieName, bool is3D) : base(movieName)
    {
        Is3D = is3D;
    }

    public override void PrintTicket()
    {
        base.PrintTicket();
        Console.WriteLine($"IMAX 3D: {(Is3D ? "Yes" : "No")}");
    }


}
