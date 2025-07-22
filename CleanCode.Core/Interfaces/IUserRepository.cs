using CleanCode.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<List<UserEntity>> GetAll();
    }
}
