namespace TelemetryApi.Extensions;

public static class StringExtensions
{
    public const String startFragment = "DEV-";
    public const int MinimumDeviceIdLength = 4; // DEV- + at least 4 digits
    public static bool IsValidDeviceId(this string? input)
    {
        if(string.IsNullOrWhiteSpace(input))
        {
            return false;
        }

        //return input.StartsWith("DEV-") && input.Length > 4;
        bool isValid = input.StartsWith(startFragment);

        if (!isValid)
        {
            return false;
        }

        int stringLength = input.Length - startFragment.Length;
        if(stringLength <= MinimumDeviceIdLength)
        {
            return false;
        }

        //check if its a number after the DEV- prefix
        try
        {
            int deviceNumber = int.Parse(input[startFragment.Length..]);
            return isValid && stringLength > 0;
        }
        catch (Exception)
        {
            return false;
        }

    }
}