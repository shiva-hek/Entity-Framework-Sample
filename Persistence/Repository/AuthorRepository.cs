using Domain.Models;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repository
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        private readonly ProjectContext _context;
        public AuthorRepository(ProjectContext context) : base(context)
        {
            context = _context;
        }

        public Author GetAuthorWithBooks(int id)
        {
            return _context.Authors.Include(a => a.Books).SingleOrDefault(a => a.Id == id);
        }

    }
}
