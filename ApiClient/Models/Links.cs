﻿using System.Text.Json.Serialization;

namespace ApiClient.Models;

public class Links
{
    [JsonPropertyName("self")]
    public Self? Self { get; set; }

    [JsonPropertyName("previousepisode")]
    public Episode? Previousepisode { get; set; }

    [JsonPropertyName("nextepisode")]
    public Episode? Nextepisode { get; set; }
}