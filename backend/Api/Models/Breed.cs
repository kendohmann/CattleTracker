using System.Text.Json.Serialization;

namespace Api.Models;

public class Breed
{
    [JsonPropertyName("breedId")]
    public string BreedId { get; set; } = string.Empty;

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
}