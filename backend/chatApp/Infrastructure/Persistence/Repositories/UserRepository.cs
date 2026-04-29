using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _appDbContext;
        public UserRepository(AppDbContext appDbContext) {
            _appDbContext = appDbContext;
        }

        public bool UserNameExists(string username)
        {
            return _appDbContext.Users.Any(u => u.Username == username);
        }

        public bool EmailExists(string email)
        {
            return _appDbContext.Users.Any(u => u.Email == email);
        }

        public void Register(User user)
        {
            _appDbContext.Users.Add(user);
            _appDbContext.SaveChanges();
        }

        public User GetByEmail(string Email)
        {
           return _appDbContext.Users.FirstOrDefault(u => u.Email == Email);
        }
    }
}
