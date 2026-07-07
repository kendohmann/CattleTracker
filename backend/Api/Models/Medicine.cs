using System.Text.Json.Serialization;

namespace Api.Models;

public class Medicine
{
    [JsonPropertyName("medicineId")]
    public int MedicineId { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("purpose")]
    public string Purpose { get; set; } = string.Empty;

    [JsonPropertyName("veterinarianId")]
    public string VeterinarianId { get; set; } = string.Empty;

    [JsonPropertyName("instructions")]
    public string Instructions { get; set; } = string.Empty;

    [JsonPropertyName("expirationDate")]
    public DateTime ExpirationDate { get; set; }

    [JsonPropertyName("deliveryMethodID")]
    public string DeliveryMethodId { get; set; } = string.Empty;
}
