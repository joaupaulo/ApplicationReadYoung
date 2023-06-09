using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationReadYoung.Domain.Models
{
    public class StudentBookRelation
    {
        public ObjectId StudentId { get; set; }
        public ObjectId BookId { get; set; }
    }
}