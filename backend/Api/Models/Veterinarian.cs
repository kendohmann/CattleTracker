using System.Text.Json.Serialization;

namespace Api.Models;

public class Veterinarian
{
    [JsonPropertyName("veterinarianId")]
    public int VeterinarianId { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("phoneNumber")]
    public string PhoneNumber { get; set; } = string.Empty;

    [JsonPropertyName("email")]
    public string Email { get; set; } = string.Empty;
}
