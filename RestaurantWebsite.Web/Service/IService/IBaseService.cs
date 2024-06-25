using RestaurantWebsite.Web.Models;

namespace RestaurantWebsite.Web.Service.IService
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto requestDto, bool withBearer=true);
    }
}
