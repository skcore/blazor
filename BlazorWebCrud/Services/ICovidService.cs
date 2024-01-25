using BlazorWebCrud.Models;

namespace BlazorWebCrud.Services
{
    public interface ICovidService
    {
        List<CovidLog> GetcovidLogs();
    }
}
