using RestaurantWebsite.Web.Models;
using RestaurantWebsite.Web.Service.IService;
using RestaurantWebsite.Web.Utility;
using static RestaurantWebsite.Web.Utility.StaticData;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace RestaurantWebsite.Web.Service
{
    public class AuthService : IAuthService
    {
        private readonly IBaseService _baseService;

        public AuthService(IBaseService baseService)
        {
            _baseService = baseService;
        }
        public async Task<ResponseDto> AssignRoleAsync(RegistrationRequestDto registrationRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = StaticData.ApiType.POST,
                Data = registrationRequestDto,
                url = StaticData.AuthAPIBase + "/api/auth/assignRole"
            }, withBearer:false);
        }

        public async Task<ResponseDto> LoginAsync(LoginRequestDto loginRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = StaticData.ApiType.POST,
                Data = loginRequestDto,
                url = StaticData.AuthAPIBase + "/api/auth/login"
            });
        }

        public async Task<ResponseDto> RegisterAsync(RegistrationRequestDto registrationRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = StaticData.ApiType.POST,
                Data = registrationRequestDto,
                url = StaticData.AuthAPIBase + "/api/auth/register"
            }, withBearer:false);
        }
    }
}
