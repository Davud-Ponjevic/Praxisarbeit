using System.ComponentModel.DataAnnotations;

namespace Praxisarbeit.Model
{
    public class RegistrationUser
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        
    }
}
