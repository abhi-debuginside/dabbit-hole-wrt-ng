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

        [JsonProperty("isApproved")]
        [BsonElement("IsApproved")]
        public bool IsApproved { get; set; }


        [JsonProperty("resourceType")]
        [BsonElement("ResourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("pollutionStatus")]
        [BsonElement("PollutionStatus")]
        public string PollutionStatus { get; set; }


        [JsonProperty("status")]
        [BsonElement("Status")]
        public string Status { get; set; }



        [JsonProperty("dataCollectedVia")]
        [BsonElement("DataCollectedVia")]
        public string DataCollectedVia { get; set; }



        [JsonProperty("chancesOfGettingPolluted")]
        [BsonElement("chancesOfGettingPolluted")]
        public string ChancesOfGettingPolluted { get; set; }


        [JsonProperty("drinkableSource")]
        [BsonElement("DrinkableSource")]
        public bool DrinkableSource { get; set; }



        [JsonProperty("beneficiaries")]
        [BsonElement("Beneficiaries")]
        public string Beneficiaries { get; set; }


        [JsonProperty("waterLevelSummar")]
        [BsonElement("WaterLevelSummar")]
        public double WaterLevelSummar { get; set; }

        [JsonProperty("waterLevelRestofTheSeason")]
        [BsonElement("WaterLevelRestofTheSeason")]
        public double WaterLevelRestofTheSeason { get; set; }

        [JsonProperty("verfiedtoUseFor")]
        [BsonElement("VerfiedtoUseFor")]
        public string VerfiedtoUseFor { get; set; }

        [JsonProperty("lastVerifiedBy")]
        [BsonElement("LastVerifiedBy")]
        public string LastVerifiedBy { get; set; }

    }

}
