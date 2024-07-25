using ApiClient.Models;
using ApiClient.Services.Filters;

namespace ApiClient.Services;

public interface IClientApiService
{
    Task<List<Show>> GetAsync();
    Task<List<Show>> GetSearchAsync(Filter filter);
    Task<Show?> GetByIdAsync(string id);
    Task SaveShowAsync(Show show);
    Task UpdateShowAsync(Show show);
    Task DeleteShowAsync(string id);
    Task<ResultValue> ImportTvMazeAsync();
    Task<ResultValue> ImportTvMazeByIdAsync(string id);
    Task ClearDataBaseAsync();
}