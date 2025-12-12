using AutoMapper;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /*Mapping profile is a class used in Automapper like how object should be converted (Mapped) into another object (product=>productCreateDTO)
     and (productcreateDTO => product)
    */
    public class MappingProfile : Profile 
    {
        public MappingProfile() 
        {
            //This is for GetAll(product,productReadDTO)
            CreateMap<Product, ProductReadDTO>().ReverseMap();

            //This is for ProductAddDTO
            CreateMap<ProductCreateDTO, Product>().ReverseMap();

            //This is for UpdateDTO
            CreateMap<ProductUpdateDTO, Product>().ReverseMap();
        }
    }
}
