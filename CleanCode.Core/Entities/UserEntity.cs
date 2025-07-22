using MongoDB.Bson.Serialization.Attributes;

namespace CleanCode.Core.Entities
{
    [BsonIgnoreExtraElements]
    public class UserEntity
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Fullname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
