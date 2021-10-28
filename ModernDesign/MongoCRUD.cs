using System.Windows;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace mApp
{
    public class MongoCRUD
    {
        private IMongoDatabase db;


        public MongoCRUD(string database)
        {
            var client = new MongoClient();    //toto je akoby  definovanie DB, keby som mal DB niekde na servery tak do () dam "connection string"
            db = client.GetDatabase(database);
        }

        public void InsertRecord<T>(string table, T record)  //zapisem dokument do DB
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        public List<T> LoadRecords<T>(string table)    //najde databazu podla toho co dam dovnutra toho table
        {
            var collection = db.GetCollection<T>(table);

            return collection.Find(new BsonDocument()).ToList();
        }


    }
}
