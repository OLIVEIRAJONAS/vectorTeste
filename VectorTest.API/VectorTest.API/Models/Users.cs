using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VectorTest.API.Models
{
    public class Users
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonIgnore]
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
       
        [JsonIgnore]
        public string Audience { get; set; }
        [JsonIgnore]
        public string Issuer { get; set; }

        [JsonIgnore]
        public Guid key { get; set; }

    }
}
