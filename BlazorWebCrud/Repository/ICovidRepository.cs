using BlazorWebCrud.Models;

namespace BlazorWebCrud.Repository
{
    public interface ICovidRepository
    {
        List<CovidLog> GetcovidLogs();
    }
}
