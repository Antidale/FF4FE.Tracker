using System.Text.Json.Serialization;

namespace FF4FE.Tracker.Models
{
    public class SeedMetadata
    {
        [JsonPropertyName("version")]
        public string Version { get; set; } = string.Empty;

        [JsonPropertyName("flags")]
        public string Flags { get; set; } = string.Empty;

        [JsonPropertyName("binary_flags")]
        public string BinaryFlags { get; set; } = string.Empty;

        [JsonPropertyName("seed")]
        public string Seed { get; set; } = string.Empty;

        //currently default to pre-5.0 style objectives
        //maybe I'll work at a Union later how to handle this?
        [JsonPropertyName("objectives")]
        public List<string> Objectives { get; set; } = [];
    }
}