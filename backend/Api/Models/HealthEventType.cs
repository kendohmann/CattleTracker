using System.Text.Json.Serialization;

namespace Api.Models;

public class HealthEventType
{
    [JsonPropertyName("healthEventTypeId")]
    public string HealthEventTypeId { get; set; } = string.Empty;

    [JsonPropertyName("shortName")]
    public string ShortName { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;
}
