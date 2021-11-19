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
            var client = new MongoClient("mongodb+srv://OverCryed:matus123@cluster0.fxaf8.mongodb.net/mApp?retryWrites=true&w=majority");   //"mongodb+srv://OverCryed:matus123@cluster0.fxaf8.mongodb.net/sample?retryWrites=true&w=majority"
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

        internal object GetCollection<T>()
        {
            throw new NotImplementedException();
        }

        public T LoadRecordById<T>(string table, string email)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("email", email);

            return collection.Find(filter).First();
        }

        //public void UpsertRecord<T>(string table, string nadpi1, T record)
        //{
        //    var collection = db.GetCollection<T>(table);

        //    var result = collection.ReplaceOne(
        //        new BsonDocument("nadpi1", id),
        //        record,
        //        new UpdateOptions { IsUpsert = true });
        //}

        public void DeleteRecord<T>(string table, string nadpis)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Nadpi1", nadpis);
            collection.DeleteOne(filter);
        }


        //private IMongoDatabase db;


        //public MongoCRUD(string database)
        //{
        //    //var client = new MongoClient("mongodb+srv://OverCryed:matus123@cluster0.fxaf8.mongodb.net/sample?retryWrites=true&w=majority");    //toto je akoby  definovanie DB, keby som mal DB niekde na servery tak do () dam "connection string"
        //    //db = client.GetDatabase(database);

        //    var client = new MongoClient("mongodb+srv://OverCryed:matus123@cluster0.fxaf8.mongodb.net/mApp?retryWrites=true&w=majority");
        //    //Get sample_mflix Database  
        //    db = client.GetDatabase(database);
        //}

        //public void InsertRecord<T>(string table, T record)  //zapisem dokument do DB
        //{
        //    var collection = db.GetCollection<T>(table);
        //    collection.InsertOne(record);
        //}

        //public List<T> LoadRecords<T>(string table)    //najde databazu podla toho co dam dovnutra toho table
        //{
        //    var collection = db.GetCollection<T>(table);

        //    return collection.Find(new BsonDocument()).ToList();
        //}

    }
}
