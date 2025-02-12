﻿using Newtonsoft.Json;

namespace VCubWatcher.Models
{
    // VCubStation myDeserializedClass = JsonConvert.DeserializeObject<VCubStation>(myJsonResponse); 
    public class VCubStation
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("bike_count")]
        public int BikeCount { get; set; }

        [JsonProperty("electric_bike_count")]
        public int ElectricBikeCount { get; set; }

        [JsonProperty("bike_count_total")]
        public int BikeCountTotal { get; set; }

        [JsonProperty("slot_count")]
        public int SlotCount { get; set; }

        [JsonProperty("is_online")]
        public bool IsOnline { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }
}
