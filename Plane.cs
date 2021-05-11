using System.Collections;

namespace AirlineSeatTracker
{
    public class Plane 
    {
        public string TailNumber { get; set; }
        public string FlightNumber { get; set; }
        public Seat[] Seats { get; set; }
    }
}