using AutoMapper;
using Domain.Dtos;
using Domain.Models;

namespace Application.Mapping
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<Book, BookDto>()
              .ForMember(dest => dest.AuthorName, source => source.MapFrom(Book => Book.BookAuthor.FullName))
              .ReverseMap();
        }
    }
}
