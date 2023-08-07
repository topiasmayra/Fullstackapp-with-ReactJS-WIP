using Microsoft.VisualBasic;

namespace Sealgram.Models
{
    public class Comments
    {
        public int? comment_id { get; set; } // primary key
        public int? user_id { get; set; } // foreign key

        public int? comment_likes { get; set; } 
        public string? comments { get; set; }


        public int post_id { get; set; } // foreign key

        public string? content { get; set; }

        public DateTime? createdat { get; set; }
        public DateTime? updatedat { get; set; }
    }
}
