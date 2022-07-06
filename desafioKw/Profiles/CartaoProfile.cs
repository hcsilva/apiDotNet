using AutoMapper;
using desafioKw.Dtos;
using desafioKw.Models;

namespace desafioKw.Profiles
{
    public class CartaoProfile : Profile
    {
        public CartaoProfile()
        {
            CreateMap<CartaoDto, Cartao>();
        }
    }
}
