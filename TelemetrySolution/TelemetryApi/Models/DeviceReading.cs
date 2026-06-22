namespace TelemetryApi.Models;

public class DeviceReading
{
    public Guid Id { get; set; }
    public string DeviceId { get; set; } = string.Empty;
    public double Speed { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public DateTime Timestamp { get; set; }
}