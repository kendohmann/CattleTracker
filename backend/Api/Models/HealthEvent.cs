using System.Text.Json.Serialization;

namespace Api.Models;

public class HealthEvent
{
    [JsonPropertyName("cowId")]
    public int CowId { get; set; }

    [JsonPropertyName("veterinarianId")]
    public int VeterinarianId { get; set; }

    [JsonPropertyName("medicineId")]
    public int MedicineId { get; set; }

    [JsonPropertyName("date")]
    public DateTime Date { get; set; }

    [JsonPropertyName("notes")]
    public string Notes { get; set; } = string.Empty;

    [JsonPropertyName("healthEventTypeId")]
    public string HealthEventTypeId { get; set; } = string.Empty;

    [JsonPropertyName("healthEventId")]
    public string HealthEventId { get; set; } = string.Empty;
}
