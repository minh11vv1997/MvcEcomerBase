using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using EcommerceBase.Domain.Entities;
using EcommerceBase.Websites.Models;

namespace EcommerceBase.Websites.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMapFromEntitiesToViewModel();
            CreateMapFromViewModelToEntities();
        }

        private void CreateMapFromViewModelToEntities()
        {            
            CreateMap<CategoryViewModel, Category>()
                .ForMember(dest => dest.CreatedDate, src => src.Ignore())
                .ForMember(dest => dest.UpdatedDate, src => src.Ignore())
                .ForMember(dest => dest.UpdatedBy, src => src.Ignore())
                .ForMember(dest => dest.ParentId, src => src.Ignore())
                .ForMember(dest => dest.CreatedBy, src => src.Ignore());
            CreateMap<SupplierViewModel, Supplier>()
               .ForMember(dest => dest.CreatedDate, src => src.Ignore())
               .ForMember(dest => dest.UpdatedDate, src => src.Ignore())
               .ForMember(dest => dest.UpdatedBy, src => src.Ignore())
               .ForMember(dest => dest.CreatedBy, src => src.Ignore());

            CreateMap<ProductViewModel, Product>()
            .ForMember(dest => dest.CreatedDate, src => src.Ignore())
            .ForMember(dest => dest.UpdatedDate, src => src.Ignore())
            .ForMember(dest => dest.UpdatedBy, src => src.Ignore())
            //.ForMember(dest => dest.ParentId, src => src.Ignore())
            .ForMember(dest => dest.CreatedBy, src => src.Ignore());

        }

        private void CreateMapFromEntitiesToViewModel()
        {            
            CreateMap<Category, CategoryViewModel>();
            CreateMap<Supplier, SupplierViewModel>();
            CreateMap<Product , ProductViewModel>();



        }

    }
}