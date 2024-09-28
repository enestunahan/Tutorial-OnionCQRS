using AutoMapper;
using Tutorial_OnionCQRS.Application.Dtos;
using Tutorial_OnionCQRS.Application.Features.Commands.CreateProduct;
using Tutorial_OnionCQRS.Domain.Entities;

namespace Tutorial_OnionCQRS.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Product , ProductViewDto>().ReverseMap();

            CreateMap<Product , CreateProductCommand>().ReverseMap();
        }
    }
}
