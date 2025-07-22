using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;

namespace CleanCode.Core.Entities
{
    [CollectionName("roles")]
    public class ApplicationRoleEntity : MongoIdentityRole<Guid>
    {

    }
}
