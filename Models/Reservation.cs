namespace HotelsRent.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }  // Relación con el modelo Room
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public Guest MainGuest { get; set; }  // Relación con el modelo Guest
        public List<Guest> Guests { get; set; } = new();  // Lista de otros huéspedes
    }
}
