﻿using CleanArchitecture.SampleApi.Application.Features.Products.Commands.CreateProduct;
using CleanArchitecture.SampleApi.Application.Features.Products.Queries.GetAllProducts;
using AutoMapper;
using CleanArchitecture.SampleApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.SampleApi.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
        }
    }
}
