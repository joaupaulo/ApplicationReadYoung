using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ApplicationReadYoung.Domain
{
    public class Generic
    {
        public string Name { get; private set; }
        public string MiddleName { get; private set; }
        public string Adress { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }
        public string Email { get; private set; }
    }
}