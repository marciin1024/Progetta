﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Progetta.Entities
{
    public class Task
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
        public string? Description { get; set; }
        public TaskStatus Status { get; set; } = TaskStatus.ToDo;
        public TaskPriority Priority { get; set; } = TaskPriority.Medium;
        public DateTime? DueDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        [ForeignKey(nameof(Project))]
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        [ForeignKey(nameof(AssignedTo))]
        public int? AssignedToId { get; set; }
        public User AssignedTo { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<TaskTag> TaskTags { get; set; }

    }

    public enum TaskStatus
    {
        ToDo,
        InProgress,
        Done
    }

    public enum TaskPriority
    {
        Low,
        Medium,
        High
    }
}
