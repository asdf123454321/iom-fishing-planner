using System.Globalization;

namespace FishingPlanner.Services;

public static class ExtensionUtils
{
    public static bool EqualsIgnoreCase(this string? str, string? other) => string.Equals(str, other, StringComparison.OrdinalIgnoreCase);

    public static bool StartsWithIgnoreCase(this string? str, string? other) => str?.StartsWith(other ?? string.Empty, StringComparison.OrdinalIgnoreCase) ?? false;

    public static string FormatPercent(this double value) => $"{value.ToString("F0", CultureInfo.InvariantCulture)}%";

    public static string FormatCompact(this int value, int decimalPlaces = 2) => ((double)value).FormatCompact(decimalPlaces);

    public static string FormatCompact(this double value, int decimalPlaces = 2)
    {
        var magnitude = Math.Abs(value);
        var divisor = 1d;
        var suffix = string.Empty;

        if (magnitude >= 1_000_000_000_000_000)
        {
            divisor = 1_000_000_000_000_000;
            suffix = "q";
        }
        else if (magnitude >= 1_000_000_000_000)
        {
            divisor = 1_000_000_000_000;
            suffix = "t";
        }
        else if (magnitude >= 1_000_000_000)
        {
            divisor = 1_000_000_000;
            suffix = "b";
        }
        else if (magnitude >= 1_000_000)
        {
            divisor = 1_000_000;
            suffix = "m";
        }
        else if (magnitude >= 1_000)
        {
            divisor = 1_000;
            suffix = "k";
        }

        return $"{(value / divisor).ToString($"0.{new string('#', decimalPlaces)}", CultureInfo.InvariantCulture)}{suffix}";
    }
}