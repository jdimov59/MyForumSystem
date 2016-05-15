using MyForumSystem.Data.Common.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace MyForumSystem.Data.Models
{
    public class Post: AuditInfo, IDeletableEntity
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
