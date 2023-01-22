﻿namespace Domain.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public virtual ICollection<Book>? Books { get; }
    }
}
