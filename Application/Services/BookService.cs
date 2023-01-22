using AutoMapper;
using Domain;
using Domain.Dtos;
using Domain.Models;

namespace Application.Services
{
    public class BookService : IBookService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public BookService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
        }

        /// <exception cref="InvalidOperationException"></exception>
        public void Add(BookDto book)
        {
            try
            {
                Book mappedBook = _mapper.Map<Book>(book);

                Author author = _unitOfWork.Authors.Get(book.AuthorId);
                mappedBook.BookAuthor = author;
                _unitOfWork.Books.Add(mappedBook);
                _unitOfWork.Complete();
            }
            catch (Exception)
            {
                throw new InvalidOperationException();
            }
        }

        public BookDto Get(int id)
        {
            Book book = _unitOfWork.Books.GetBookById(id);
            if (book != null)
            {
                BookDto mappedBook = _mapper.Map<BookDto>(book);
                return mappedBook;
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public List<BookDto> GetBooksWithAuthors()
        {
            IEnumerable<Book> books = _unitOfWork.Books.GetBooksWithAuthors();
            List<BookDto> mappedBooks = _mapper.Map<IEnumerable<BookDto>>(books).ToList();
            return mappedBooks;
        }

        public void Remove(int id)
        {
            Book book = _unitOfWork.Books.Get(id);
            Book mappedBook = _mapper.Map<Book>(book);
            _unitOfWork.Books.Remove(mappedBook);
            _unitOfWork.Complete();
        }




    }
}
