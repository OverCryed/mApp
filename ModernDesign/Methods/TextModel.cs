using mApp.Core;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace mApp
{
    public class TextModel : ObeservableObject
    {

        [BsonId]
        public Guid Id { get; set; }
        public string nadpi1 { get; set; }
        public string nadpis2 { get; set; }
        public string nadpis3 { get; set; }
        public string nadpis4 { get; set; }
    }
}
