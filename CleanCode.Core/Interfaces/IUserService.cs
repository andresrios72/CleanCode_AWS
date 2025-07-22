using CleanCode.Core.Entities;

namespace CleanCode.Core.Interfaces
{
    public interface IUserService
    {
        Task<List<UserEntity>> GetAll();
    }
}
