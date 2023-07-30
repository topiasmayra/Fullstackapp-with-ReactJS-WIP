using Microsoft.VisualBasic;

namespace Sealgram.Models
{
    public class Comments
    {
        public int comment_id { get; set; } // primary key
        public int user_id { get; set; } // foreign key

        public int post_id { get; set; } // foreign key

        public string content { get; set; }

        public DateAndTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
