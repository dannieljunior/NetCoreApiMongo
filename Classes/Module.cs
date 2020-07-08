using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using varegoApi.Interfaces;

namespace varegoApi.Classes
{
    public abstract class Module : IModule
    {
        protected readonly IServiceCollection _services;
        protected readonly IConfiguration _configuration;
        public Module(IServiceCollection pServices, IConfiguration pConfiguration = null)
        {
            _services = pServices;
            _configuration = pConfiguration;
            
            Inject();
        }
        public abstract void Inject();
    }
}