using System;

namespace Sealgram.Models
{
    public class Post
    {
        public int? postid { get; set; } // primary key

        public int? user_id { get; set; } // foreign key
        public string? title { get; set; }

        public string? content { get; set; }

        public DateTime? createdat { get; set; }

        public DateTime? updatedat { get; set; }
    }
}