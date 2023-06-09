using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationReadYoung.Domain.Models
{
    public class Books : Generic
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; private set; }

        public int BookKey { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public DateTime Year { get; private set; }
        public string Publisher { get; private set; }
        public string Description { get; private set; }
        public string ISBN { get; private set; }

        public List<ObjectId> StudentIds { get; set; }

        public Books(int bookKey, string title, string author, DateTime year, string publisher, string description, string isbn, string Name)

        {
            Id = ObjectId.GenerateNewId();
            BookKey = bookKey;
            Title = title;
            Author = author;
            Title = title;
            Publisher = publisher;
            Description = description;
            Year = year;
            ISBN = isbn;
        }
    }
}