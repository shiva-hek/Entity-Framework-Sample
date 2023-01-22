using Domain.Dtos;
using System.Linq.Expressions;


namespace Application.Services
{
    public interface IBookService
    {
        BookDto Get(int id);
        List<BookDto> GetBooksWithAuthors();
        void Add(BookDto book);
        void Remove(int id);
    }
}
