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

        public async Task<bool> Deletelogs(int logId)
        {
            return await covidRepository.Deletelogs(logId);
        }

        public async Task<IEnumerable<CovidLog>> GetcovidLogs()
        {
            return await covidRepository.GetcovidLogs();
        }

        public async Task<bool> Savelogs(CovidLog log)
        {
            return await covidRepository.Savelogs(log);
        }
    }
}
