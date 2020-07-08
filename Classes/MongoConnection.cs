using varegoApi.Interfaces;

namespace varegoApi.Classes
{
    public class MongoConnection : IMongoConnection
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string CollectionName { get; set; }
    }
}