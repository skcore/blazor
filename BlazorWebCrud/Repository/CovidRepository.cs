using BlazorWebCrud.Data;
using BlazorWebCrud.Models;

namespace BlazorWebCrud.Repository
{
    public class CovidRepository : ICovidRepository
    {
        private readonly CovidContext covidContext;
        public CovidRepository(CovidContext _covidContext)
        {
            covidContext = _covidContext;
        }
        public List<CovidLog> GetcovidLogs()
        {
            return covidContext.CovidLogs.ToList();
        }
    }
}
