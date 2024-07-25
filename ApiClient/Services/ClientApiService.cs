using System.Globalization;
using System.Text;
using System.Text.Json;
using ApiClient.Models;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
using ApiClient.Services.Filters;

namespace ApiClient.Services;

public class ClientApiService : IClientApiService
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;
    private readonly JsonSerializerOptions _jsonOptions;

    private readonly string ApiKeyName = "Shows-ApiKey";
    private readonly string ApiKeyUser = "Shows-User";

    public ClientApiService(HttpClient httpClient, IConfiguration configuration)
    {
        _configuration = configuration;

        _httpClient = httpClient;
        _httpClient.DefaultRequestHeaders.Add(ApiKeyName, _configuration["Api:password"]);
        _httpClient.DefaultRequestHeaders.Add(ApiKeyUser, _configuration["Api:usuario"]);

        _jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
    }

    public async Task<List<Show>> GetAsync()
    {
        try
        {
            var response = await _httpClient.GetAsync("");
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Show>>(responseBody) ?? [];
        }
        catch 
        {
            throw;
        }
    }
    public async Task<List<Show>> GetSearchAsync(Filter filter)
    {

        try
        {
            var response = await _httpClient.GetAsync($"search?{filter.ToString()}");
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Show>>(responseBody) ?? [];
        }
        catch
        {
            throw;
        }
    }

    public async Task<Show?> GetByIdAsync(string id)
    {
        try
        {
            var response = await _httpClient.GetAsync($"{id}");
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Show>(responseBody);
        }
        catch
        {
            throw;
        }
    }

    public async Task SaveShowAsync(Show show)
    {
        try
        {
            var jsonContent = JsonSerializer.Serialize(show);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"", content);

            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
        }
        catch
        {
            throw;
        }
    }

    public async Task UpdateShowAsync(Show show)
    {
        try
        {
            var jsonContent = JsonSerializer.Serialize(show);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"{show.Id}", content);

            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
        }
        catch 
        {
            throw;
        }
    }

    public async Task DeleteShowAsync(string id)
    {
        try
        {
            var response = await _httpClient.DeleteAsync($"{id}");
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
        }
        catch
        {
            throw;
        }
    }

    public async Task<ResultValue> ImportTvMazeAsync()
    {
        try
        {
            var response = await _httpClient.PostAsync($"ImportTvMaze", null);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<ResultValue>(responseBody, _jsonOptions);
        }
        catch
        {
            throw;
        }




        //var request = new HttpRequestMessage(HttpMethod.Post, "ImportTvMaze");
        //request.Headers.Add(ApiKeyName, _configuration["Api:password"]);
        //request.Headers.Add(ApiKeyUser, _configuration["Api:usuario"]);

        //var response = await _httpClient.SendAsync(request);
        //response.EnsureSuccessStatusCode();

        //var responseBody = await response.Content.ReadAsStringAsync();
        //return JsonSerializer.Deserialize<ResultValue>(responseBody, _jsonOptions);
    }

    public async Task<ResultValue> ImportTvMazeByIdAsync(string id)
    {
        try
        {
            var response = await _httpClient.PostAsync($"SaveShow/{id}", null);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<ResultValue>(responseBody, _jsonOptions);
        }
        catch
        {
            throw;
        }




        //var request = new HttpRequestMessage(HttpMethod.Post, $"SaveShow/{id}");
        //request.Headers.Add(ApiKeyName, _configuration["Api:password"]);
        //request.Headers.Add(ApiKeyUser, _configuration["Api:usuario"]);

        //var response = await _httpClient.SendAsync(request);
        //response.EnsureSuccessStatusCode();

        //var responseBody = await response.Content.ReadAsStringAsync();
        //return JsonSerializer.Deserialize<ResultValue>(responseBody, _jsonOptions);
    }


    public async Task ClearDataBaseAsync()
    {
        try
        {
            var response = await _httpClient.PostAsync($"clear", null);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
        }
        catch
        {
            throw;
        }


        //var request = new HttpRequestMessage(HttpMethod.Post, $"clear");
        //request.Headers.Add(ApiKeyName, _configuration["Api:password"]);
        //request.Headers.Add(ApiKeyUser, _configuration["Api:usuario"]);

        //var response = await _httpClient.SendAsync(request);
        //response.EnsureSuccessStatusCode();

        //var responseBody = await response.Content.ReadAsStringAsync();
    }
}