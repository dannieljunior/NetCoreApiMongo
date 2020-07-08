using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using MongoDB.Driver;
using varegoApi.Interfaces;

namespace varegoApi.Classes
{
    public abstract class ServiceBase<T> : IService<T> where T : IModel
    {
        protected readonly IMongoCollection<T> _itens;

        public ServiceBase(IMongoConnection connection)
        {
            var client = new MongoClient(string.Format(connection.ConnectionString,
                                                        connection.UserName,
                                                        connection.PassWord,
                                                        connection.Database));

            var database = client.GetDatabase(connection.Database);
            _itens = database.GetCollection<T>(CollectionName);
        }

        public async virtual Task<T> CreateAsync(T pEntity)
        {
            await _itens.InsertOneAsync(pEntity);
            return await Task.FromResult(pEntity);
        }

        public async virtual Task<List<T>> GetAsync()
        {
            var task = await _itens.FindAsync(p => true);
            return await task.ToListAsync();
        }
        public async virtual Task<T> GetAsync(string id)
        {
            var task = await _itens.FindAsync<T>(p => p.Id == id);
            return await task.FirstOrDefaultAsync();
        }

        public async virtual Task RemoveAsync(T pEntity)
        {
            await _itens.DeleteOneAsync(p => p.Id == pEntity.Id);
        }

        public async virtual Task RemoveAsync(string id)
        {
            await _itens.DeleteOneAsync(p => p.Id == id);
        }

        public async virtual Task UpdateAsync(string id, T pEntity)
        {
            await _itens.ReplaceOneAsync(p => p.Id == id, pEntity);
        }

        protected abstract string CollectionName { get; }
    }
}