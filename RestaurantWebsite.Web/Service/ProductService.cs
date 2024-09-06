using RestaurantWebsite.Web.Models;
using RestaurantWebsite.Web.Service.IService;
using RestaurantWebsite.Web.Utility;

namespace RestaurantWebsite.Web.Service
{
    public class ProductService:IProductService
    {
        private readonly IBaseService _baseService;

        public ProductService(IBaseService baseSerice)
        {
            _baseService = baseSerice;
        }

        public async Task<ResponseDto?> CreateProductAsync(ProductDto productDto)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = StaticData.ApiType.POST,
                Data=productDto,
                url = StaticData.ProductAPIBase + "/api/product"
            });
        }

        public async Task<ResponseDto?> DeleteProductAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = StaticData.ApiType.DELETE,
                url = StaticData.ProductAPIBase + "/api/product/" + id
            });
        }

        public async Task<ResponseDto?> GetAllProductAsync()
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType=StaticData.ApiType.GET,
                url=StaticData.ProductAPIBase + "/api/product"
            });
        }

        public async Task<ResponseDto?> GetProductByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = StaticData.ApiType.GET,
                url = StaticData.ProductAPIBase + "/api/product/" + id
            });
        }

        public async Task<ResponseDto?> UpdateProductAsync(ProductDto productDto)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = StaticData.ApiType.PUT,
                Data=productDto,
                url = StaticData.ProductAPIBase + "/api/product"
            });
        }
    }
}
