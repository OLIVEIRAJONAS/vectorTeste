using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Text.Json.Serialization;

namespace VectorTest.API.Models
{
    public class Email
    {

        public Email()
        {
            UpdatedAt = DateTime.Now;
        }

        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        [JsonIgnore]
        public DateTime UpdatedAt { get; set; }

        [BsonElement]
        public string Name { get; set; }

        public string Avatar { get; set; }

     
        public string Mail { get; set; }

      
    }
}

