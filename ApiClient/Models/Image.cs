using System.Text.Json.Serialization;

namespace ApiClient.Models;

public class Image
{
    [JsonPropertyName("medium")]
    public Uri? Medium { get; set; }

    [JsonPropertyName("original")]
    public Uri? Original { get; set; }
}