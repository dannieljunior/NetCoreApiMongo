using System.Collections.Generic;
using System.Threading.Tasks;

namespace varegoApi.Interfaces
{
    public interface IService<T> where T: IModel
    {
        Task<List<T>> GetAsync();
        Task<T> GetAsync(string id);
        Task<T> CreateAsync(T pEntity);
        Task UpdateAsync(string id, T pEntity);
        Task RemoveAsync(T pEntity);
        Task RemoveAsync(string id);
    }
}