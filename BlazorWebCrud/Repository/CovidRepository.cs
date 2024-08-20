using BlazorWebCrud.Data;
using BlazorWebCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebCrud.Repository
{
    public class CovidRepository : ICovidRepository
    {
        private readonly CovidContext covidContext;
        public CovidRepository(CovidContext _covidContext)
        {
            covidContext = _covidContext;
        }

        public async Task<bool> Savelogs(CovidLog log)
        {
            try
            {
                covidContext.CovidLogs.Add(log);
                await covidContext.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Deletelogs(int logId)
        {
            try
            {
                var covidlog = await covidContext.CovidLogs.FindAsync(logId);
                if (covidlog != null)
                {
                    covidContext.CovidLogs.Remove(covidlog);
                    await covidContext.SaveChangesAsync();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<CovidLog>> GetcovidLogs()
        {
            try
            {
                return await covidContext.CovidLogs.ToListAsync();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
