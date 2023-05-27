using AutoMapper;
using Domain;

namespace Application.Core
{
    public class MappingProfiles : Profile
    {

        MappingProfiles()
        {         
            CreateMap<Product, Product>();
        }
    }
}
