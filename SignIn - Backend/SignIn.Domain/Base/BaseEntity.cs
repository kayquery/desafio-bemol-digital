using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SignIn.Domain.Base
{
    public abstract class BaseEntity
    {

        public BaseEntity()
        {
        }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString();
        
        [BsonElement("createdAt")]
        public DateTime CreatedAt { get;  } = DateTime.UtcNow;
        
        [BsonElement("updatedAt")]
        public DateTime? UpdatedAt { get; protected set; }
    }
}