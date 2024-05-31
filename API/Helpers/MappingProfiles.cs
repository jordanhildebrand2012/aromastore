using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(t => t.ProductType, o => o.MapFrom(n => n.ProductType.Name))
                .ForMember(b => b.ProductBrand, o => o.MapFrom(n => n.ProductBrand.Name));
        }
    }
}