namespace HotelsRent.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomType { get; set; }
        public decimal BasePrice { get; set; }
        public decimal Tax { get; set; }
        public string Location { get; set; }
        public bool IsEnabled { get; set; }
    }
}
