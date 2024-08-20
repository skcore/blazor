using BlazorWebCrud.Models;

namespace BlazorWebCrud.Services
{
    public interface ICovidService
    {
        Task <IEnumerable<CovidLog>> GetcovidLogs();

        Task<bool> Savelogs(CovidLog log);

        Task<bool> Deletelogs(int logId);
    }
}
