using BlazorWebCrud.Models;
using BlazorWebCrud.Repository;
using BlazorWebCrud.Services;

namespace BlazorServerCrud.Services
{
    public class CovidService : ICovidService
    {
        private readonly ICovidRepository covidRepository;
        public CovidService(ICovidRepository covidRepository)
        {
            this.covidRepository = covidRepository;
        }
        public List<CovidLog> GetcovidLogs()
        {
            return covidRepository.GetcovidLogs();
        }
    }
}
