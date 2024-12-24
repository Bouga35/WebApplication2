using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Books
    {
        public int Id { get; set; } // Primary Key

        [Required]
        public string? Title { get; set; } // Not nullable

        public string? Author { get; set; } // Nullable reference type

        public DateTime? PublishedDate { get; set; } // Nullable value type

        public decimal? Price { get; set; } // Nullable value type

        public int? Pages { get; set; } // Nullable value type

        public string? Description { get; set; } // Nullable reference type
    }
}
