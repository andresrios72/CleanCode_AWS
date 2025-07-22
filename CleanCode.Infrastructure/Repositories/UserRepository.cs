using CleanCode.Core.Entities;
using CleanCode.Core.Interfaces;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CleanCode.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<UserEntity> _users;

        public UserRepository(IOptions<MongoDbSettingsEntity> options) {
            var mongoclient = new MongoClient(options.Value.ConnectionString);
            _users = mongoclient.GetDatabase(options.Value.DataBaseName).GetCollection<UserEntity>("users");
        }
        public async Task<List<UserEntity>> GetAll() => await _users.Find(_ => true).ToListAsync();
    }
}
