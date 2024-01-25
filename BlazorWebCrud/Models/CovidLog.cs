using System.ComponentModel.DataAnnotations;

namespace BlazorWebCrud.Models
{
    public class CovidLog
    {
        public int Id { get; set; }
        [Required]
        public  string Name { get; set; }
        [Required]
        public  string Covidlogmsg { get; set; }
        public DateTime CreatedDate { get; private set; } = DateTime.Now;
    }
}
