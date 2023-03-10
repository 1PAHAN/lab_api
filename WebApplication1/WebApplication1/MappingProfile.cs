using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyDto>()
                .ForMember(
                    c   => c.FullAddress,
                    opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country))
                );
            CreateMap<Employee, EmployeeDto>();
            CreateMap<Customer, CustomerDto>();
            CreateMap<Product, ProductDto>();

            CreateMap<CompanyForCreationDto, Company>();
            CreateMap<EmployeeForCreationDto, Employee>();
        }
    }
}
