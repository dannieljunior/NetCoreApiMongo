namespace varegoApi.Interfaces
{
    public interface IMongoConnection
    {
        string ConnectionString { get; set; }
        string Database { get; set; }
        string UserName { get; set; }
        string PassWord { get; set; }
        string CollectionName { get; set; }
    }
}