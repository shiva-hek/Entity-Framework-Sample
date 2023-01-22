using Domain.Models;

namespace Domain.Repositories
{
    public interface IBookRepository : IRepository<Book>
    {
        Book GetBookById(int id);
        List<Book> GetBooksWithAuthors();
    }
}
