using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_60_OOP04;

internal class StandardTicket:Ticket
{
    public string SeatNumber { get; set; }

    public StandardTicket(string movieName, string seatNumber) : base(movieName)
    {
        SeatNumber = seatNumber;
    }

    public override void PrintTicket()
    {
        base.PrintTicket();
        Console.WriteLine($"Seat: {SeatNumber}");
    }

}
