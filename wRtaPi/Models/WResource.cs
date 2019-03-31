using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wRtaPi.Models
{
    public class WResource
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        [BsonElement("Name")]
        public string Name { get; set; }


        [JsonProperty("description")]
        [BsonElement("Description")]
        [BsonIgnoreIfNull]
        public string Description { get; set; }


        [JsonProperty("longitude")]
        [BsonElement("Longitude")]
        [BsonIgnoreIfNull]
        public string Longitude { get; set; }


        [JsonProperty("latitude")]
        [BsonElement("Latitude")]
        [BsonIgnoreIfNull]
        public string Latitude { get; set; }

        [JsonProperty("rating")]
        [BsonElement("Rating")]
        [BsonIgnoreIfNull]
        public string Rating { get; set; }

        [JsonProperty("isApproved")]
        [BsonElement("IsApproved")]
        [BsonIgnoreIfNull]
        public bool IsApproved { get; set; }


        [JsonProperty("resourceType")]
        [BsonElement("ResourceType")]
        [BsonIgnoreIfNull]
        public string ResourceType { get; set; }

        [JsonProperty("pollutionStatus")]
        [BsonElement("PollutionStatus")]
        [BsonIgnoreIfNull]
        public string PollutionStatus { get; set; }


        [JsonProperty("status")]
        [BsonElement("Status")]
        [BsonIgnoreIfNull]
        public string Status { get; set; }



        [JsonProperty("dataCollectedVia")]
        [BsonElement("DataCollectedVia")]
        [BsonIgnoreIfNull]
        public string DataCollectedVia { get; set; }



        [JsonProperty("chancesOfGettingPolluted")]
        [BsonElement("chancesOfGettingPolluted")]
        [BsonIgnoreIfNull]
        public string ChancesOfGettingPolluted { get; set; }


        [JsonProperty("drinkableSource")]
        [BsonElement("DrinkableSource")]
        [BsonIgnoreIfNull]
        public string DrinkableSource { get; set; }



        [JsonProperty("beneficiaries")]
        [BsonElement("Beneficiaries")]
        [BsonIgnoreIfNull]
        public string Beneficiaries { get; set; }


        [JsonProperty("waterLevelSummar")]
        [BsonElement("WaterLevelSummar")]
        [BsonIgnoreIfNull]
        public double WaterLevelSummar { get; set; }

        [JsonProperty("waterLevelRestofTheSeason")]
        [BsonElement("WaterLevelRestofTheSeason")]
        [BsonIgnoreIfNull]
        public double WaterLevelRestofTheSeason { get; set; }

        [JsonProperty("verfiedtoUseFor")]
        [BsonElement("VerfiedtoUseFor")]
        [BsonIgnoreIfNull]
        public string VerfiedtoUseFor { get; set; }

        [JsonProperty("lastVerifiedBy")]
        [BsonElement("LastVerifiedBy")]
        [BsonIgnoreIfNull]
        public string LastVerifiedBy { get; set; }

    }

}
