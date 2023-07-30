using Microsoft.VisualBasic;

namespace Sealgram.Models
{
    public class Posts
    {
        public int post_id { get; set; } // primary key

        public int user_id { get; set; } // foreign key 
        public string title { get; set; }

        public string content { get; set; }

        public DateAndTime created_at { get; set; }

        public DateAndTime updated_at { get; set; }
    }
}
