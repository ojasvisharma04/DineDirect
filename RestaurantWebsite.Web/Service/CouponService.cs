using RestaurantWebsite.Web.Models;
using RestaurantWebsite.Web.Service.IService;
using RestaurantWebsite.Web.Utility;

namespace RestaurantWebsite.Web.Service
{
    public class CouponService:ICouponService
    {
        private readonly IBaseService _baseService;

        public CouponService(IBaseService baseSerice)
        {
            _baseService = baseSerice;
        }

        public async Task<ResponseDto?> CreateCouponAsync(CouponDto couponDto)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = StaticData.ApiType.POST,
                Data=couponDto,
                url = StaticData.CouponAPIBase + "/api/coupon"
            });
        }

        public async Task<ResponseDto?> DeleteCouponAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = StaticData.ApiType.DELETE,
                url = StaticData.CouponAPIBase + "/api/coupon/" + id
            });
        }

        public async Task<ResponseDto?> GetAllCouponAsync()
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType=StaticData.ApiType.GET,
                url=StaticData.CouponAPIBase + "/api/coupon"
            });
        }

        public async Task<ResponseDto?> GetCouponAsync(string couponCode)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = StaticData.ApiType.GET,
                url = StaticData.CouponAPIBase + "/api/coupon/GetByCode/" + couponCode
            });
        }

        public async Task<ResponseDto?> GetCouponByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = StaticData.ApiType.GET,
                url = StaticData.CouponAPIBase + "/api/coupon/" + id
            });
        }

        public async Task<ResponseDto?> UpdateCouponAsync(CouponDto couponDto)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = StaticData.ApiType.PUT,
                Data=couponDto,
                url = StaticData.CouponAPIBase + "/api/coupon"
            });
        }
    }
}
