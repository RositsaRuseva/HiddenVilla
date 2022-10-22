using Models;

namespace HiddenVilla_Client.Service.IService
{
    public interface IAuthenticationService
    {
        Task<RegistrationResponseDto> RegisterUser(UserRequestDto userForRegistration);
        Task<AuthenticationResponseDto> Login(AuthenticationDto userFromAuthentication);
        Task Logout();
    }
}
