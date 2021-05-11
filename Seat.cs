namespace AirlineSeatTracker
{
    public struct Seat
    {
        public string SeatNumber { get; set; }
        public SeatPosition SeatPosition { get; set; }
        public static bool IsAvailable { get; set; } = false;
    }
}