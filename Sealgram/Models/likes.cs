using Microsoft.VisualBasic;

namespace Sealgram.Models
{
    public class Likes
    {
        public int LikeId { get; set; } // primary key

        public int UserId { get; set; } // foreign key

        public int PostId { get; set; } // foreign key

        public DateTime CreatedAt { get; set; } // timestamp
    }
}
