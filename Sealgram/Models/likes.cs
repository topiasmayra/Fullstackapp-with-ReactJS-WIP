using Microsoft.VisualBasic;

namespace Sealgram.Models
{
    public class Likes
    {
        public int likeid { get; set; } // primary key



        public int user_id { get; set; } // foreign key

        public int postid { get; set; } // foreign key

        public DateTime?     created_at { get; set; } // timestamp
    }
}
