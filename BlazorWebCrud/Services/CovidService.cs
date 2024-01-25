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

        public bool Deletelogs(int logId)
        {
          return covidRepository.Deletelogs(logId);
        }

        public List<CovidLog> GetcovidLogs()
        {
            return covidRepository.GetcovidLogs();
        }

        public bool Savelogs(CovidLog log)
        {
            return covidRepository.Savelogs(log);
        }
    }
}
