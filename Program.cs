using System;
using System.Collections.Generic;

namespace AirlineSeatTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Seat> seats = new List<Seat>();

            for (int i = 1; i <= 10; i++)
            {
                seats.Add(new Seat(){SeatNumber = $"{i}A", SeatPosition = SeatPosition.Window, IsAvailable = true});
                seats.Add(new Seat(){SeatNumber = $"{i}B", SeatPosition = SeatPosition.Middle, IsAvailable = true});
                seats.Add(new Seat(){SeatNumber = $"{i}C", SeatPosition = SeatPosition.Aisle, IsAvailable = false});

                seats.Add(new Seat(){SeatNumber = $"{i}D", SeatPosition = SeatPosition.Aisle, IsAvailable = false});
                seats.Add(new Seat(){SeatNumber = $"{i}E", SeatPosition = SeatPosition.Middle, IsAvailable = true});
                seats.Add(new Seat(){SeatNumber = $"{i}F", SeatPosition = SeatPosition.Window, IsAvailable = true});
            }

            var Plane = new Plane()
            {
               FlightNumber = "420",
               TailNumber = "430",
               Seats = new Seat[]
               {
                   new Seat(){SeatNumber = "A1", SeatPosition = SeatPosition.Aisle, IsAvailable = false}
               }
            };
            
            foreach (var seat in seats)
            {
                Console.WriteLine(seat.SeatNumber);
            }
        }
    }
}
