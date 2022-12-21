using _2ndMVcRepository.Models;
using EF.Core.Repository.Interface.Repository;

namespace _2ndMVcRepository.Interface.Repository
{
    public interface IUserRepository:ICommonRepository<User>
    {
    }
}
