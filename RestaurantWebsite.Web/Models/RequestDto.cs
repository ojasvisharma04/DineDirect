using System.Security.AccessControl;
using static RestaurantWebsite.Web.Utility.StaticData;

namespace RestaurantWebsite.Web.Models
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }
}
