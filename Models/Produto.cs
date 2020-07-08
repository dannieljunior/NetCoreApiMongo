using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using varegoApi.Interfaces;

namespace varegoApi.Models
{
    public class Produto: IModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Descricao { get; set; }
        public decimal VlrUnitario { get; set; }
        public int Tipo { get; set; }
        public string Categoria { get; set; }
    }
}