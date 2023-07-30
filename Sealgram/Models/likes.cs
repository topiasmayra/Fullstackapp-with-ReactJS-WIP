using Microsoft.VisualBasic;

namespace Sealgram.Models
{
    public class likes
    {
        public int like_id { get; set; } // primary key

        public int user_id { get; set; } // foreign key

        public int post_id { get; set; } // foreign key

        public DateAndTime created_at { get; set; } // timestamp
    }
}
