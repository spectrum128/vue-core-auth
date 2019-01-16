using AutoMapper;
using AppSkel.Dtos;
using AppSkel.Entities;

namespace AppSkel.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

        }
    }
}