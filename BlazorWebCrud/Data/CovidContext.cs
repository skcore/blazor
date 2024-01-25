using BlazorWebCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebCrud.Data
{
    public class CovidContext : DbContext
    {
        public CovidContext(DbContextOptions<CovidContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }
        public DbSet<CovidLog> CovidLogs { get; set; }

    }
}
