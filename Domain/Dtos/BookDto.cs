namespace Domain.Dtos
{
    public class BookDto
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? AuthorName { get; set; }
        public int AuthorId { get; set; }
    }
}
