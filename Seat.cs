namespace AirlineSeatTracker
{
    public struct Seat
    {
        public string SeatNumber { get; set; }
        public SeatPosition SeatPosition { get; set; }
        public bool IsAvailable { get; set; }
    }
}