using System; // Don't forget to import System namespace for data types.

namespace Sealgram.Models
{
    public class User
    {
        public int UserId { get; set; } // primary key

        public string? Username { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}