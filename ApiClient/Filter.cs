using System.Globalization;

namespace ApiClient;

public class Filter
{
    private const string InvalidStatus = "Status must be 1, 2, or 3.";
    private const string InvalidMinAverage = "MinAverage must be between 0.0 and 10.0.";
    private const string InvalidMaxAverage = "MaxAverage must be between 0.0 and 10.0.";
    private const string MinGreaterThanMax = "MinAverage cannot be greater than MaxAverage.";

    public int? Id { get; set; }
    public string? Name { get; set; }
    public string? Genres { get; set; }
    public int? Status { get; set; }
    public double? MinAverage { get; set; }
    public double? MaxAverage { get; set; }

    public bool IsValid(out string errorMessage)
    {
        errorMessage = string.Empty;

        if (Status.HasValue && (Status < 1 || Status > 3))
        {
            errorMessage = InvalidStatus;
            return false;
        }

        if (MinAverage.HasValue && (MinAverage < 0.0 || MinAverage > 10.0))
        {
            errorMessage = InvalidMinAverage;
            return false;
        }

        if (MaxAverage.HasValue && (MaxAverage < 0.0 || MaxAverage > 10.0))
        {
            errorMessage = InvalidMaxAverage;
            return false;
        }

        if (MinAverage.HasValue && MaxAverage.HasValue && MinAverage > MaxAverage)
        {
            errorMessage = MinGreaterThanMax;
            return false;
        }

        return true;
    }

    private string ToQueryString()
    {
        var query = new List<string>();

        if (!string.IsNullOrEmpty(Name))
            query.Add($"name={Name}");

        if (!string.IsNullOrWhiteSpace(Genres))
            query.Add($"genres={Genres}");

        if (Status.HasValue && (Status >= 1 || Status <= 3))
            query.Add($"status={Status}");

        if (MinAverage.HasValue)
            query.Add($"MinAverage={MinAverage.Value.ToString(CultureInfo.InvariantCulture)}");

        if (MaxAverage.HasValue)
            query.Add($"MaxAverage={MaxAverage.Value.ToString(CultureInfo.InvariantCulture)}");

        return string.Join("&", query);
    }

}
