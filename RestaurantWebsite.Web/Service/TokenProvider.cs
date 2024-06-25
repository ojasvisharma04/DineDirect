using Newtonsoft.Json.Linq;
using RestaurantWebsite.Web.Service.IService;
using RestaurantWebsite.Web.Utility;

namespace RestaurantWebsite.Web.Service
{
    public class TokenProvider : ITokenProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public TokenProvider(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;   
        }
        public void ClearToken()
        {
            _httpContextAccessor.HttpContext.Response?.Cookies.Delete(StaticData.TokenCookie);
        }

        public string? GetToken()
        {
            string? token = null;
            bool? hasToken = _httpContextAccessor.HttpContext?.Request.Cookies.TryGetValue(StaticData.TokenCookie, out token);

            return hasToken is true ? token : null;
        }

        public void SetToken(string token)
        {
            _httpContextAccessor.HttpContext?.Response.Cookies.Append(StaticData.TokenCookie, token);
        }


    }
}
