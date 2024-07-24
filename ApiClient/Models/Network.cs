using System.Text.Json.Serialization;

namespace ApiClient.Models;

public class Network
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("country")]
    public Country? Country { get; set; }

    [JsonPropertyName("officialSite")]
    public Uri? OfficialSite { get; set; }
}