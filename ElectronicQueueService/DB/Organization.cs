using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace ElectronicQueueService.DB
{
    public class Organization
    {
        [Key]
        public Guid IdOrganization { get; set; }
        public string Title { get; set; }
        public byte[] Logo { get; set; }

        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}