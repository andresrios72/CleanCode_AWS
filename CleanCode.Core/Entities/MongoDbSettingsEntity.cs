namespace CleanCode.Core.Entities
{
    public class MongoDbSettingsEntity
    {
        public string ConnectionString { get; set; } = string.Empty;
        public string DataBaseName { get; set; } = string.Empty;
    }
}
