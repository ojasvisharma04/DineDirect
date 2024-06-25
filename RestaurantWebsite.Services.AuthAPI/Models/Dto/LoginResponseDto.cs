using Microsoft.AspNetCore.SignalR.Protocol;

namespace RestaurantWebsite.Services.AuthAPI.Models.Dto
{
    public class LoginResponseDto
    {
        public UserDto User { get; set; }
        public string Token { get; set; }
    }
}
