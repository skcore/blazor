using BlazorWebCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebCrud.Repository
{
    public interface ICovidRepository
    {
        Task<List<CovidLog>> GetcovidLogs();
        Task<bool> Savelogs(CovidLog log);
        Task<bool> Deletelogs(int logId);
    }
}
