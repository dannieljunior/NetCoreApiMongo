using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using varegoApi.Classes;
using varegoApi.Interfaces;
using StackExchange.Redis;
using Microsoft.Extensions.Configuration;

namespace varegoApi.Ioc
{
    public class ConnectionsModule : Module
    {
        public ConnectionsModule(IServiceCollection pServices, IConfiguration pConfiguration = null) : base(pServices, pConfiguration) { }

        public override void Inject()
        {
            _services.AddSingleton<IMongoConnection>(sp =>
               sp.GetRequiredService<IOptions<MongoConnection>>().Value);

            _services.AddSingleton<IConnectionMultiplexer>(x =>
                ConnectionMultiplexer.Connect(_configuration.GetValue<string>("RedisConnection")));
        }
    }
}