using AutoMapper;
using RestaurantWebsite.Services.CouponAPI.Models;
using RestaurantWebsite.Services.CouponAPI.Models.Dto;

namespace RestaurantWebsite.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config=>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();

            });
            return mappingConfig;
        }
    }
}
