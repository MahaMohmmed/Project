using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public int ResortId { get; set; }
        public Resort CommentedAt { get; set; }
        public int UserId { get; set; }
        public User CommentedBy { get; set; }
        public int CommentId { get; set; }
        public Comment Com { get; set; }

    }
}