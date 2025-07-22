using CleanCode.Core.Entities;
using CleanCode.Core.Interfaces;

namespace CleanCode.Core.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public Task<List<UserEntity>> GetAll()
        {
            return _userRepository.GetAll();
        }
    }
}
