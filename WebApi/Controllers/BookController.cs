using Application.Services;
using AutoMapper;
using Domain;
using Domain.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBookService _bookService;
        private readonly IMapper _mapper;
        public BookController(IUnitOfWork unitOfWork, IBookService bookService, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._bookService = bookService;
            this._mapper = mapper;
        }

        [HttpGet("GetBooksWithAuthor")]
        public IEnumerable<BookDto> GetBooksWithAuthor()
        {
            return _bookService.GetBooksWithAuthors();
        }

        [HttpGet("{id}")]
        public BookDto Get(int id)
        {
            return _bookService.Get(id);
        }

        [HttpPost]
        public void Post([FromBody] BookDto book)
        {
            _bookService.Add(book);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _bookService.Remove(id);
        }
    }
}
