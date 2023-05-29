using AutoMapper;
using MoviesApi.Data.Dtos;
using MoviesApi.Models;

namespace MoviesApi.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>()
                .ForMember(cinemaDto => cinemaDto.Endereco, opt => opt.MapFrom(cinema => cinema.Endereco));
            CreateMap<UpdateCinemaDto, Cinema>();
        }
    }
}
