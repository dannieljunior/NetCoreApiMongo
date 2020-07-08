using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using varegoApi.Classes;
using varegoApi.Services;

namespace varegoApi.Ioc
{
    public class ServicesModule : Module
    {
        public ServicesModule(IServiceCollection pServices, IConfiguration pConfiguration = null) : base(pServices, pConfiguration) { }

        public override void Inject()
        {
            _services.AddScoped<ProdutoService>();
            _services.AddScoped<StringServiceCache>();
        }
    }
}