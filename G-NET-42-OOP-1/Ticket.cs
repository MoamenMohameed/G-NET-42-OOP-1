using System;

public class Ticket
{
	public string movieName;
	public Seat seat;
	public TicketType ticketType;
	private double price ;

	public Ticket(string movieName, Seat seat, TicketType ticketType, double price)
	{
		this.movieName = movieName;
		this.seat = seat;
		this.ticketType = ticketType;
		this.price = price;
	}
	public Ticket(string movieName) :this(movieName, new Seat('A',1), TicketType.Standard, 20)
	{
	}

	public double CalcTotal(double tax)
	{
		double total = price * (tax / 100);
		return total + price;
	}

	public void Disccount(ref int discount)
	{
		if (discount > 0 && discount <= price)
		{
			Console.WriteLine("------------- After Discount -------------");
			Console.WriteLine($"Discount Before : {price}");
			Console.WriteLine($"Discount After  :  {price -= discount}");
			Console.WriteLine($"Movie           : {movieName}");
			Console.WriteLine($"Seat            : {seat.row}{seat.number}");
			Console.WriteLine($"Type            : {ticketType}");
			Console.WriteLine($"Price           : {price}");
			Console.WriteLine($"Total (14% tax) : {CalcTotal(0.15)}");

		}
		else
		{
            Print();
        }
    }

	public void Print()
	{
		Console.WriteLine("------------- Ticket Info -------------");
        Console.WriteLine($"Movie        : {movieName}");
		Console.WriteLine($"Seat         : {seat.row}{seat.number}");
        Console.WriteLine($"Type         : {ticketType}");
		Console.WriteLine($"Price        : {price}");
		Console.WriteLine($"Total (14% tax) : {CalcTotal(0.15)}");

		
    }
}
