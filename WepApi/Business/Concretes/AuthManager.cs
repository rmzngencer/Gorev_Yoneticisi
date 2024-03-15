using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
namespace Business.Concretes
{
    
    public class AuthManager : IAuthService
    {
        readonly ITokenService tokenService;

        public AuthManager(ITokenService tokenService)
        {
            this.tokenService = tokenService;
        }
        
        public async Task<UserLoginResponse> LoginUserAsync(UserLoginRequest request)
        {
            UserLoginResponse response = new();

            if (string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Password))
            {
                throw new ArgumentNullException(nameof(request));
            }

            if (request.Username == "onur" && request.Password == "123456")
            {
                var generatedTokenInformation = await tokenService.GenerateToken(new GenerateTokenRequest { Username = request.Username });

                response.AuthenticateResult = true;
                response.AuthToken = generatedTokenInformation.Token;
                response.AccessTokenExpireDate = generatedTokenInformation.TokenExpireDate;           
            }

            return response;
        }
    }
}