using System.Text.Json.Serialization;

namespace SporifyBlazor.Models
{
    public class SpotifyUser
    {
        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }
        public string Email { get; set; }
        [JsonPropertyName("external_urls")]
        public ExternalUrls ExternalUrls { get; set; }
    }
    public class ExternalUrls
    {
        public string Spotify { get; set; }
    }
}
