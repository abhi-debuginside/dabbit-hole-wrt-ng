using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wRtaPi.Models
{
    public class BaseModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.Int64)]
        [JsonProperty("name")]
        public long Id { get; set; }
    }
}
