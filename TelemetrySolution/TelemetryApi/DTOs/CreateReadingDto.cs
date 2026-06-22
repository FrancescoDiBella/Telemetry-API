namespace TelemetryApi.DTOs;

public record CreateReadingDto(
    string DeviceId,
    double Speed,
    double Latitude,
    double Longitude
);