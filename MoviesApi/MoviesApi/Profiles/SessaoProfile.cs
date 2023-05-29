using AutoMapper;
using MoviesApi.Data.Dtos;
using MoviesApi.Models;

namespace MoviesApi.Profiles
{
    public class SessaoProfile : Profile
    {
        public SessaoProfile()
        {
            CreateMap<CreateSessaoDto, Sessao>();
            CreateMap<Sessao, ReadSessaoDto>();
        }
    }
}
