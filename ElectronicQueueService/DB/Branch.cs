using System.ComponentModel.DataAnnotations;

namespace ElectronicQueueService.DB
{
    public class Branch
    {
        [Key]
        public Guid IdBranch { get; set; }
        public string Addres { get; set; }
        public string UniqueKey { get; set; }

        public Guid IdOrganization { get; set; }
        public virtual Organization Organization { get; set; }
    }
}