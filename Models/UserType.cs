using System.ComponentModel.DataAnnotations;

namespace Authorization.Models
{
    public class UserType
    {
        [Key]
        public int UserTypeId { get; set; } 
        [Required]
        public string UserTypeName { get; set; } // e.g., Admin, User, Guest
    }
}
