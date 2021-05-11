using System;
using System.Collections.Generic;

namespace AirlineSeatTracker
{
    class Program
    {
        static void Main(string[] args)
        {


            var seatsArray = new Plane()
            {
               FlightNumber = "420",
               TailNumber = "430",
               Seats = new Seat[]
               {
                   new Seat(){}
               }
            };
            
            Console.WriteLine(seatsArray);
        }
    }
}
