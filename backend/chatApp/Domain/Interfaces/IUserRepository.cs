using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IUserRepository
    {
        bool UserNameExists(string username);
        bool EmailExists(string email);
        void Register(User user);
        User GetByEmail(string email);
    }
}
