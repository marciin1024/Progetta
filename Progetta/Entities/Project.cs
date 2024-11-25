using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Progetta.Entities
{
    public class Project
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        [ForeignKey(nameof(Owner))]
        public int OwnerId { get; set; }
        public User Owner { get; set; }
        public ICollection<Task> Tasks { get; set;}
        public ICollection<Comment> Comments { get; set; }
        public ICollection<UserProject> UserProjects { get; set; }
        
    }
}
