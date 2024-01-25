using BlazorWebCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebCrud.Repository
{
    public interface ICovidRepository
    {
        List<CovidLog> GetcovidLogs();
        bool Savelogs(CovidLog log);

        bool Deletelogs(int logId);


    }
}
