using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantWebsite.Services.AuthAPI.Models.Dto;
using RestaurantWebsite.Services.AuthAPI.Services.IService;

namespace RestaurantWebsite.Services.AuthAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {

        private readonly IAuthService _authService;
        private readonly ResponseDto _response;

        public AuthAPIController(IAuthService authService)
        {
            _authService = authService;
            _response = new();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegistrationRequestDto registrationRequestDto)
        {
            var errorMessage = await _authService.Register(registrationRequestDto);
            if(!string.IsNullOrEmpty(errorMessage))
            {
                _response.Message = errorMessage;
                _response.IsSuccess = false;
                return BadRequest(_response);
            }
            return Ok(_response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto loginRequestDto)
        {
            var loginResponse = await _authService.Login(loginRequestDto);
            if(loginResponse==null)
            {
                _response.Message = "Username or Password is not found";
                _response.IsSuccess = false;
                return BadRequest(_response);
            }
            _response.Result = loginResponse;
            return Ok(_response);
        }

        [HttpPost("assignRole")]
        public async Task<IActionResult> AssignRole([FromBody] RegistrationRequestDto model)
        {
            var assignRoleSuccess = await _authService.AssignRole(model.Email, model.RoleName.ToUpper());
            if (!assignRoleSuccess)
            {
                _response.Message = "Error";
                _response.IsSuccess = false;
                return BadRequest(_response);
            }
            return Ok(_response);
        }
    }
}
