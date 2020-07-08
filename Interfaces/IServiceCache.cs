using System;
using System.Threading.Tasks;
namespace varegoApi.Interfaces
{
    public interface IServiceCache<T>
    {
         Task<string> GetCacheValueAsync(string pKey);
         Task SetCacheValueAsync(string pKey, T pValue);

    }
}