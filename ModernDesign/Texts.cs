using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace mApp
{
    public class Texts
    {
        [BsonId]
        public Guid Id { get; set; }
        public string text { get; set; }
    }
}
