using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationReadYoung.Domain.Models
{
    public class Student : Generic
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId StudentId { get; set; }

        public int CodeStudent { get; private set; }
        public string ClassStudent { get; private set; }
        public List<ObjectId> BooksId { get; set; }

        public Student(int codeStudent, string classStudent)
        {
            StudentId = ObjectId.GenerateNewId();
            CodeStudent = codeStudent;
            ClassStudent = classStudent;
        }
    }
}