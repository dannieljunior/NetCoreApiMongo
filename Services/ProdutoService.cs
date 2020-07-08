using System.Collections.Generic;
using varegoApi.Classes;
using varegoApi.Interfaces;
using varegoApi.Models;

namespace varegoApi.Services
{
    public class ProdutoService : ServiceBase<Produto>
    {
        protected override string CollectionName => "Produtos";

        public ProdutoService(IMongoConnection connection) : base(connection) { }
    }
}