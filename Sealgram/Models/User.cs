using System; // Don't forget to import System namespace for data types.
using System.ComponentModel.DataAnnotations;

namespace Sealgram.Models
{
    public class User
    {
        
        [Key] // This attribute marks the property as the primary key
        public int user_id { get; set; }
        public string? username { get; set; }

        public string? email { get; set; }

        public string? password { get; set; }

        public DateTime? created_at { get; set; }

        public DateTime? updated_at { get; set; }
    }
}