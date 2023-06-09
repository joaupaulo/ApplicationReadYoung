using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationReadYoung.Domain.Models
{
    public class Employess : Generic
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; private set; }

        public int CodeEmployee { get; private set; }
        public string DepartamentEmployee { get; private set; }

        public Employess(int codeEmployee, string departamentEmployee)
        {
            Id = ObjectId.GenerateNewId();
            CodeEmployee = codeEmployee;
            DepartamentEmployee = departamentEmployee;
        }
    }
}