using System.ComponentModel.DataAnnotations.Schema;

namespace Progetta.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }


        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey(nameof(Task))]
        public int? TaskId { get; set; }
        public Task Task { get; set; }

        [ForeignKey(nameof(Project))]
        public int? ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
