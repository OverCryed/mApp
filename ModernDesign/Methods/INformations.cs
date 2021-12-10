using System.Windows;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace mApp
{
    public class INformations
    {
        [BsonId]
        public Guid Id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
