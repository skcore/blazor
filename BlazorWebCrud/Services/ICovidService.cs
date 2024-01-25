using BlazorWebCrud.Models;

namespace BlazorWebCrud.Services
{
    public interface ICovidService
    {
        List<CovidLog> GetcovidLogs();

        bool Savelogs(CovidLog log);

        bool Deletelogs(int logId);
    }
}
