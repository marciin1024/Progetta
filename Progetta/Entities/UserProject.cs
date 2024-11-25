﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Progetta.Entities
{
    public class UserProject
    {
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey(nameof(Project))]
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public UserProjectRole Role { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }

    public enum UserProjectRole
    {
        Owner,
        Collaborator
    }
}
