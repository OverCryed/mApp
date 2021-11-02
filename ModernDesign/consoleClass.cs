using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace mApp
{
    class consoleClass
    {
        [BsonId]
        public Guid Id { get; set; }
        public string text { get; set; }
    }
}

