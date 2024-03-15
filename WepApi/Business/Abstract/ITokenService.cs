using Business.Dtos.Requests;
using Business.Dtos.Responses;

namespace Business.Abstracts
{
    public interface ITokenService
    {
       public Task<GenerateTokenResponse> GenerateToken(GenerateTokenRequest request);
    }
}