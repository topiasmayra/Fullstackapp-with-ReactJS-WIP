using System;

namespace Sealgram.Models
{
    public class Post
    {
        public int? PostId { get; set; } // primary key

        public int? UserId { get; set; } // foreign key
        public string? Title { get; set; }

        public string? Content { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}