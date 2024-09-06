using AutoMapper;
using RestaurantWebsite.Services.ProductAPI.Models;
using RestaurantWebsite.Services.ProductAPI.Models.Dto;

namespace RestaurantWebsite.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config=>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
                

            });
            return mappingConfig;
        }
    }
}
