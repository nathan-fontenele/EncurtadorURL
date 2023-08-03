using System.Text.Json.Serialization;

namespace Encurtador.Model;

public class ApiResponse
{
   [JsonPropertyName("url")]
    public DataModel Url { get; set; }
}
