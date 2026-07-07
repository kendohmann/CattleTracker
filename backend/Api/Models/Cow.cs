using System.Text.Json.Serialization;

namespace Api.Models;
public class Cow
{
    [JsonPropertyName("cowId")]
    public int CowId { get; set; }

    [JsonPropertyName("rfid")]
    public int Rfid { get; set; }

    [JsonPropertyName("eartag")]
    public int Eartag { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("birthDate")]
    public DateTime BirthDate { get; set; }

    [JsonPropertyName("isFemale")]
    public bool IsFemale { get; set; }

    [JsonPropertyName("isPregnant")]
    public bool IsPregnant { get; set; }

    [JsonPropertyName("deathDate")]
    public DateTime DeathDate { get; set; }

    [JsonPropertyName("breedId")]
    public int BreedId { get; set; }
}
