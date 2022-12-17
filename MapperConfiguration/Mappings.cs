using AutoMapper;
using Hotel_API.DTO;
using Hotel_API.Entities;

namespace Hotel_API.Mappings
{
    public class Mappings:Profile
    {
        public Mappings()
        {
            CreateMap<Suite, SuiteDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
        }


    }
}
