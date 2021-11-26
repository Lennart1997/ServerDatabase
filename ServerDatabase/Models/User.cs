using System.ComponentModel.DataAnnotations;

namespace RestServer.Data
{
    public class User
    {
        [Key]
        public string username { get; set; }
        public string Domain { get; set; }
        public string City { get; set; }
        public int BirthYear { get; set; }
        public string Role { get; set; }
        public int SecurityLevel { get; set; }
        public string password { get; set; }
    }
}