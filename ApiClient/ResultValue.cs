namespace ApiClient;

public class ResultValue
{
    public ResultValue()
    {
        
    }
    public ResultValue(bool success, string message)
    {
        Success = success;
        Message = message;
    }
    public bool Success { get; set; }
    public string Message { get; set; } = null!;
}

public class ErrorResponse
{
    public ErrorResponse(int statusCode, string message)
    {
        StatusCode = statusCode;
        Message = message;
    }

    public ErrorResponse(int statusCode, string message, string details) : this(statusCode, message)
    {
        Details = details;
    }

    public int StatusCode { get; set; }
    public string Message { get; set; }
    public string Details { get; set; }
}