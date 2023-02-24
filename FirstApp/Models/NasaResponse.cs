using System.Text.Json.Serialization;

namespace FirstApp.Models;

public record NasaResponse {
    [JsonPropertyName("copyright")]
    public string copyright {get; init;}
    [JsonPropertyName("explanation")]
    public string explanation {get; init;}
    [JsonPropertyName("hdurl")]
    public string hdurl {get; init;}
    [JsonPropertyName("url")]
    public string url {get; init;}
    [JsonPropertyName("media_type")]
    public string media_type {get; init;}
    [JsonPropertyName("service_version")]
    public string serviceVersion {get; init;}
    [JsonPropertyName("title")]
    public string title {get; init;}
    [JsonPropertyName("date")]
    public string date {get; init;}
}

