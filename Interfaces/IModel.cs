using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace varegoApi.Interfaces
{
    public interface IModel
    {
        string Id { get; set; }
    }
}