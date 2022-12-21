using _2ndMVcRepository.AppDbContext;
using _2ndMVcRepository.Interface.Manager;
using _2ndMVcRepository.Models;
using _2ndMVcRepository.Repository;
using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;

namespace _2ndMVcRepository.Manager
{
    public class UserManager : CommonManager<User>, IUserManager
    {
        public UserManager(ApplicationDbContext dbContext) : base(new UserRepository(dbContext))
        {

        }

        public User GetById(int id)
        {
            return GetFirstOrDefault(x => x.Id == id);
        }
    }
}
