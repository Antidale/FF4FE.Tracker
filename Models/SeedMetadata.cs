using System.Text.Json.Serialization;

namespace FF4FE.Tracker.Models
{
    public class SeedMetadata
    {
        [JsonPropertyName("version")]
        public string Version { get; set; } = string.Empty;

        [JsonPropertyName("flags")]
        public string Flags { get; set; } = string.Empty;

        [JsonPropertyName("seed")]
        public string Seed { get; set; } = string.Empty;

        [JsonPropertyName("objectives")]
        public List<string> Objectives { get; set; } = new List<string>();
    }
}
