using RestaurantWebsite.Services.AuthAPI.Models;

namespace RestaurantWebsite.Services.AuthAPI.Services.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> role);
    }
}
