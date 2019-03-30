using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wRtaPi.Models
{
    public class WResource : BaseModel
    {
        [BsonElement("Name")]
        public string Name { get; set; }
        [BsonElement("Description")]
        public string Description { get; set; }
        [BsonElement("XAxis")]
        public string XAxis { get; set; }
        [BsonElement("YAxis")]
        public string YAxis { get; set; }
    }
}
