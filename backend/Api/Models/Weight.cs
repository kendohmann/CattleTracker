using System.Text.Json.Serialization;

namespace Api.Models;

public class Weight
{
    [JsonPropertyName("cowId")]
    public int CowId { get; set; }

    [JsonPropertyName("weight")]
    public double WeightLb { get; set; }

    [JsonPropertyName("date")]
    public DateTime Date { get; set; }
}