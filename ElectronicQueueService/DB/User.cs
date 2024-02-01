using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ElectronicQueueService.DB
{
    public class User : IdentityUser
    {
        [Key]
        public Guid IdUser { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
    
        public Guid IdOrganization { get; set; }
        public virtual Organization Organization { get; set; }
    }
}