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

        public bool Deletelogs(int logId)
        {
            try
            {
                var covidlog = covidContext.CovidLogs.Find(logId);
                covidContext.CovidLogs.Remove(covidlog);
                covidContext.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<CovidLog> GetcovidLogs()
        {
            return covidContext.CovidLogs.ToList();
        }

        public bool Savelogs(CovidLog log)
        {
            try
            {
                covidContext.CovidLogs.Add(log);
                covidContext.SaveChanges();

                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
