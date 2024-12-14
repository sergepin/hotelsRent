namespace HotelsRent.Models
{
    public class Guest
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public EmergencyContact EmergencyContact { get; set; }
    }

    public class EmergencyContact
    {
        public int Id { get; set; }  // Agregar una clave primaria
        public string FullName { get; set; }
        public string Phone { get; set; }
    }
}
