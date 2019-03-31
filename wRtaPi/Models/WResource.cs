using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wRtaPi.Models
{
    public class WResource : BaseModel
    {
        [JsonProperty("name")]
        [BsonElement("Name")]
        public string Name { get; set; }


        [JsonProperty("description")]
        [BsonElement("Description")]
        public string Description { get; set; }


        [JsonProperty("longitude")]
        [BsonElement("Longitude")]
        public string Longitude { get; set; }


        [JsonProperty("latitude")]
        [BsonElement("Latitude")]
        public string Latitude { get; set; }

        [JsonProperty("rating")]
        [BsonElement("Rating")]
        public string Rating { get; set; }
    }
}
