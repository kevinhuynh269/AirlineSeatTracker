using System;
using System.Collections.Generic;
using System.Linq;

namespace AirlineSeatTracker
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Seat> seats = new List<Seat>();
      List<Seat> availableSeats = new List<Seat>();

      for (int i = 1; i <= 10; i++)
      {
        seats.Add(new Seat() { SeatNumber = $"{i}A", SeatPosition = SeatPosition.Window, IsAvailable = true });
        seats.Add(new Seat() { SeatNumber = $"{i}B", SeatPosition = SeatPosition.Middle, IsAvailable = true });
        seats.Add(new Seat() { SeatNumber = $"{i}C", SeatPosition = SeatPosition.Aisle, IsAvailable = false });

        seats.Add(new Seat() { SeatNumber = $"{i}D", SeatPosition = SeatPosition.Aisle, IsAvailable = false });
        seats.Add(new Seat() { SeatNumber = $"{i}E", SeatPosition = SeatPosition.Middle, IsAvailable = true });
        seats.Add(new Seat() { SeatNumber = $"{i}F", SeatPosition = SeatPosition.Window, IsAvailable = true });
      }

      var Plane = new Plane()
      {
        FlightNumber = "420",
        TailNumber = "430",
        Seats = seats.ToArray()
      };

      availableSeats = Plane.Seats.ToList().FindAll(x => x.IsAvailable == true);

      // Prints available seats
      Console.WriteLine("These are the list of available seats");
      foreach (var seat in availableSeats)
      {
        Console.WriteLine($"Seat Number: {seat.SeatNumber} \t|\t Seat Position: {seat.SeatPosition}");
      }
    }
  }
}
