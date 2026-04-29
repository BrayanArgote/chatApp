using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtService _jwtService;
        public UserService (IUserRepository userRepository, IJwtService jwtService)
        {
            _userRepository = userRepository;
            _jwtService = jwtService;
        }
        public void Register(RegisterUserDto dto)
        {
            if (_userRepository.UserNameExists(dto.Username))
                throw new Exception("Username already exists");

            if (_userRepository.EmailExists(dto.Email))
                throw new Exception("Email already exists");

            var user = new User
            {
                Username = dto.Username,
                PasswordHash = dto.Password,
                Age = dto.Age,
                Email = dto.Email,
            };

            _userRepository.Register(user);
        }

        public string Login(LoginUserDto dto)
        {
            var user = _userRepository.GetByEmail(dto.Email);

            if (user == null || user.PasswordHash != dto.Password)
                throw new Exception("User or password is incorrect");

            return _jwtService.GenerateToken(user);
        }
    }
}
