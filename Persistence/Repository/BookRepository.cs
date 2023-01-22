using Domain.Dtos;
using Domain.Models;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Persistence.Repository.Exceptions;

namespace Persistence.Repository
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private readonly ProjectContext _context;
        public BookRepository(ProjectContext context) : base(context)
        {
            _context = context;
        }

        public Book GetBookById(int id)
        {
            var result = _context.Books.Include(a => a.BookAuthor).SingleOrDefault(c => c.Id == id);

            if (result == null)
                throw new FailedToFindBookByIdException("The book is not found.", id);
            else
                return result;
        }

        public List<Book> GetBooksWithAuthors()
        {
            return _context.Books.Include(a => a.BookAuthor).ToList();
        }

    }
}
