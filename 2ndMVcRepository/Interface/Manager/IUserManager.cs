using _2ndMVcRepository.Models;
using EF.Core.Repository.Interface.Manager;

namespace _2ndMVcRepository.Interface.Manager
{
    public interface IUserManager:ICommonManager<User>
    {
        User GetById(int id);

    }
}
