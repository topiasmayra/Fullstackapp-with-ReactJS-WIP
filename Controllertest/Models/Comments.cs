using Microsoft.VisualBasic;

namespace Sealgram.Models
{
    public class Comments
    {
        public int? CommentId { get; set; } // primary key
        public int? UserId { get; set; } // foreign key

        public int PostId { get; set; } // foreign key

        public string? Content { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
