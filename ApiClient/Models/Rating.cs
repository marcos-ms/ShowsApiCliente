using System.Text.Json.Serialization;

namespace ApiClient.Models;

public class Rating
{
    [JsonPropertyName("average")]
    public double? Average { get; set; }
}