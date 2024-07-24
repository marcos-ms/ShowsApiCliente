using System.Text.Json.Serialization;

namespace ApiClient.Models;

public class Self
{
    [JsonPropertyName("href")]
    public Uri Href { get; set; }
}