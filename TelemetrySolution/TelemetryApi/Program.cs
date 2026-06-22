using TelemetryApi.Extensions;
using TelemetryApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

DeviceReading deviceReading = new()
{
    Id = Guid.NewGuid(),
    DeviceId = null,
    Speed = 60.5,
    Latitude = 37.7749,
    Longitude = -122.4194,
    Timestamp = DateTime.UtcNow
};

Console.WriteLine(deviceReading.DeviceId.IsValidDeviceId());

app.Run();