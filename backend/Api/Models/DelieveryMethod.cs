using System.Text.Json.Serialization;

namespace Api.Models;

public class DeliveryMethod
{
    [JsonPropertyName("deliveryMethodId")]
    public int DeliveryMethodId { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;
}
