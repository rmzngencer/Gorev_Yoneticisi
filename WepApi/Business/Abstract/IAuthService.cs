
using Business.Dtos.Requests;
using Business.Dtos.Responses;
namespace Business.Abstracts
{
    public interface IAuthService
    {
        public Task<UserLoginResponse> LoginUserAsync(UserLoginRequest request);
    }
}