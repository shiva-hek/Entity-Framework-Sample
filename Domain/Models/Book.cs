using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int AuthorId { get; set; }
        public bool IsActive { get; set; }
        [ForeignKey("AuthorId")]
        public virtual Author? BookAuthor { get; set; }
    }
}
