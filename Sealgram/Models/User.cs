using Microsoft.VisualBasic;

namespace Sealgram.Models
{
    public class User
    {
        public int user_id { get; set; } //primary key
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public DateAndTime created_at { get; set; }
        public DateAndTime updated_at { get; set; }

    }
}
