using System.Threading.Tasks;
using StackExchange.Redis;
using varegoApi.Interfaces;

namespace varegoApi.Services
{
    public class StringServiceCache : IServiceCache<string>
    {
        private readonly IConnectionMultiplexer _connection;

        public StringServiceCache(IConnectionMultiplexer pConnection)
        {
            _connection = pConnection;
        }

        public async Task<string> GetCacheValueAsync(string pKey)
        {
            var db = _connection.GetDatabase();
            return await db.StringGetAsync(pKey);
        }

        public async Task SetCacheValueAsync(string pKey, string pValue)
        {
            var db = _connection.GetDatabase();
            await db.StringSetAsync(pKey, pValue);
        }
    }
}