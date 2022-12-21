using _2ndMVcRepository.Interface.Repository;
using _2ndMVcRepository.Models;
using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore;

namespace _2ndMVcRepository.Repository
{
    public class UserRepository : CommonRepository<User>, IUserRepository
    {
        public UserRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
