using HotelsRent.Models;

namespace HotelsRent.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public bool IsEnabled { get; set; }
        public List<Room> Rooms { get; set; } = new();
    }
}
