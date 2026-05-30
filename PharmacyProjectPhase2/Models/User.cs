using System.ComponentModel.DataAnnotations;

namespace PharmacyProjectPhase2.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }

        [Required,MaxLength(10)]
        public string Password { get; set; }
    }
}
