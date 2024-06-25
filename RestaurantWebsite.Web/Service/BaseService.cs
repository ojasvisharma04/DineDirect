using Newtonsoft.Json;
using RestaurantWebsite.Web.Models;
using RestaurantWebsite.Web.Service.IService;
using System.Text;
using System.Net;

namespace RestaurantWebsite.Web.Service
{
    public class BaseService:IBaseService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ITokenProvider _tokenProvider;
		public BaseService(IHttpClientFactory httpClientFactory, ITokenProvider tokenProvider)
        {
            _httpClientFactory = httpClientFactory;
            _tokenProvider = tokenProvider;
        }

        public async Task<ResponseDto?> SendAsync(RequestDto requestDto, bool withBearer = true)
        {
            HttpClient client = _httpClientFactory.CreateClient("RestaurantAPI");
            HttpRequestMessage message = new();
            message.Headers.Add("accept", "application/json");
            //token
            if (withBearer)
            {
                var token = _tokenProvider.GetToken();
                message.Headers.Add("Authorization", $"Bearer {token}");
            }

            message.RequestUri = new Uri(requestDto.url);
            if (requestDto.Data != null)
            {
                message.Content = new StringContent(JsonConvert.SerializeObject(requestDto.Data),Encoding.UTF8, "application/json");
            }

            HttpResponseMessage apiResponse = null;

            switch (requestDto.ApiType)
            {
                case Utility.StaticData.ApiType.POST:
                    message.Method = HttpMethod.Post;
                    break;
                case Utility.StaticData.ApiType.PUT:
                    message.Method = HttpMethod.Put;
                    break;
                case Utility.StaticData.ApiType.DELETE:
                    message.Method = HttpMethod.Delete;
                    break;
                default:
                    message.Method = HttpMethod.Get;
                    break;
            }
            apiResponse = await client.SendAsync(message);

            switch(apiResponse.StatusCode)
            {
                case HttpStatusCode.NotFound:
                    return new() { IsSuccess = false, Message = "NotFound" };
                case HttpStatusCode.Forbidden:
                    return new() { IsSuccess = false, Message = "Access Denied" };
                case HttpStatusCode.Unauthorized:
                    return new() { IsSuccess = false, Message = "Unauthorized access" };
                case HttpStatusCode.InternalServerError:
                    return new() { IsSuccess = false, Message = "500 Internal Server" };
                default:
                    var apiContent = await apiResponse.Content.ReadAsStringAsync();
                    var apiResponseDto = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
                    return apiResponseDto;

            }

        }


    }
}
