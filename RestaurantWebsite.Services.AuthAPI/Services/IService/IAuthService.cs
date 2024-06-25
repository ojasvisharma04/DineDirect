using RestaurantWebsite.Services.AuthAPI.Models.Dto;

namespace RestaurantWebsite.Services.AuthAPI.Services.IService
{
    public interface IAuthService
    {
        Task<string> Register(RegistrationRequestDto registrationRequestDto);
        Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);

        Task<bool> AssignRole(string email, string roleName);
    }
}
