using Microsoft.AspNetCore.SignalR.Protocol;

namespace RestaurantWebsite.Web.Models
{
    public class LoginResponseDto
    {
        public UserDto User { get; set; }
        public string Token { get; set; }
    }
}
