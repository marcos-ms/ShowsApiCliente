using System.Text.Json.Serialization;

namespace ApiClient.Models;

public class Episode
{
    [JsonPropertyName("href")]
    public Uri? Href { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}