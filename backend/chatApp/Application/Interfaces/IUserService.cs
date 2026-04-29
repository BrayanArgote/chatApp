using Application.DTOs;

namespace Application.Interfaces
{
    public interface IUserService
    {
        void Register(RegisterUserDto dto);
        string Login(LoginUserDto dto);
    }
}
